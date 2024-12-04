using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MercadaoRonirin.BancoCaixa;

namespace MercadaoRonirin
{
    public partial class PontoVenda : Form
    {
        private int idoperador;
        public PontoVenda(int Idoperador)
        {
            InitializeComponent();
            idoperador = Idoperador;
            this.KeyPreview = true;
        }

        private int? idVendaAtual = null;


        private void PontoVenda_Load(object sender, EventArgs e)
        {
            // Configurando as colunas da ListView
            listViewProdutos.Columns.Add("Código de Barras", 120); // Largura da coluna em pixels
            listViewProdutos.Columns.Add("Nome do Produto", 200);
            listViewProdutos.Columns.Add("Valor Unitário", 100);
            listViewProdutos.Columns.Add("Quantidade", 80);
            listViewProdutos.Columns.Add("Valor Total", 100);

            // Definindo o modo de visualização para Details, necessário para exibir colunas
            listViewProdutos.View = View.Details;
        }


        private void txtCodigoBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Conecte conexao = new Conecte();

                // Usando a classe de conexão Conecte
                {
                    var repository = new ProdutoRepository();
                    var produto = repository.ObterProdutoPorCodigoBarras(txtCodigoBarras.Text);
                    if (produto != null)
                    {
                        txtNomeProduto.Text = produto.Nome;
                        txtValorUnitario.Text = produto.ValorUnitario.ToString("F2");
                        txtQuantidade.Focus();
                    }
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }

                // Evento de pressionar "Enter" no campo Quantidade para adicionar o produto à ListView e salvar na tabela Vendas


        private void AtualizarValorTotalCompra()
        {
            decimal valorTotalCompra = 0;

            // Verifica se a ListView possui itens
            if (listViewProdutos.Items.Count > 0)
            {
                // Percorre os itens na ListView e soma os valores totais de cada item
                foreach (ListViewItem item in listViewProdutos.Items)
                {
                    try
                    {
                        // O índice 4 se refere à coluna de "Valor Total" que deve ser o valor monetário
                        decimal valorTotalItem = decimal.Parse(item.SubItems[4].Text);
                        valorTotalCompra += valorTotalItem; // Soma o valor total de cada item
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Erro ao converter o valor total: " + ex.Message);
                    }
                }

                // Exibe o valor total da compra formatado como moeda
                lblValorTotal.Text = valorTotalCompra.ToString("C"); // Exibe o valor total da compra

                // Atualiza o valor total na tabela Vendas
                Conecte conexao = new Conecte();
                string queryAtualizaVenda = "UPDATE Vendas SET Total_Venda = @Total_Venda WHERE ID_Venda = @ID_Venda";

                using (var cmd = new SqlCommand(queryAtualizaVenda, conexao.ReturnConnection()))
                {
                    cmd.Parameters.Add(new SqlParameter("@Total_Venda", SqlDbType.Decimal) { Value = valorTotalCompra });
                    cmd.Parameters.Add(new SqlParameter("@ID_Venda", SqlDbType.Int) { Value = idVendaAtual });

                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                // Caso não haja itens, o valor total é 0
                lblValorTotal.Text = 0.ToString("C");
            }
        }

        private void AdicionarProduto()
        {
            try
            {
                Conecte conexao = new Conecte(); // Usando a classe de conexão Conecte
                decimal valorUnitario = decimal.Parse(txtValorUnitario.Text);
                int quantidade = int.Parse(txtQuantidade.Text);
                decimal valorTotalItem = valorUnitario * quantidade;

                // Obtém o produto com base no código de barras
                var repository = new ProdutoRepository();
                var produto = repository.ObterProdutoPorCodigoBarras(txtCodigoBarras.Text);

                // Verifica se o produto foi encontrado
                if (produto == null)
                {
                    MessageBox.Show("Produto não encontrado.");
                    return;
                }

                // Verifica se já existe uma venda aberta (idVendaAtual) ou cria uma nova
                if (idVendaAtual == null)
                {
                    string queryVenda = "INSERT INTO Vendas (Data_Venda, Total_Venda, ID_Operador_Caixa) " +
                                        "OUTPUT INSERTED.ID_Venda " + // Obter o ID da venda recém-criada
                                        "VALUES (@Data_Venda, @Total_Venda, @ID_Operador_Caixa)";

                    using (var cmd = new SqlCommand(queryVenda, conexao.ReturnConnection()))
                    {
                        cmd.Parameters.Add(new SqlParameter("@Data_Venda", SqlDbType.DateTime) { Value = DateTime.Now });
                        cmd.Parameters.Add(new SqlParameter("@Total_Venda", SqlDbType.Decimal) { Value = 0 }); // O valor total será atualizado mais tarde
                        cmd.Parameters.Add(new SqlParameter("@ID_Operador_Caixa", SqlDbType.Int) { Value = idoperador}); // Passa o ID do operador logado

                        // Executa a query e obtém o ID da nova venda
                        idVendaAtual = (int)cmd.ExecuteScalar();
                    }
                }

                // Agora adiciona o item à tabela Itens_Venda
                string queryItemVenda = "INSERT INTO Itens_Venda (ID_Venda, ID_Produto, Quantidade, Preco_Venda_Unitario) " +
                                        "VALUES (@ID_Venda, @ID_Produto, @Quantidade, @Preco_Venda_Unitario)";

                using (var cmd = new SqlCommand(queryItemVenda, conexao.ReturnConnection()))
                {
                    cmd.Parameters.Add(new SqlParameter("@ID_Venda", SqlDbType.Int) { Value = idVendaAtual });
                    cmd.Parameters.Add(new SqlParameter("@ID_Produto", SqlDbType.Int) { Value = produto.ID_Produto }); // Usa o ID do produto
                    cmd.Parameters.Add(new SqlParameter("@Quantidade", SqlDbType.Int) { Value = quantidade });
                    cmd.Parameters.Add(new SqlParameter("@Preco_Venda_Unitario", SqlDbType.Decimal) { Value = valorUnitario });

                    cmd.ExecuteNonQuery(); // Insere o item da venda
                }

                // Adiciona o produto à ListView
                var item = new ListViewItem(new[]
                {
            txtCodigoBarras.Text,
            txtNomeProduto.Text,
            valorUnitario.ToString("F2"),
            quantidade.ToString(),
            valorTotalItem.ToString("F2") // Valor total do item
        });
                listViewProdutos.Items.Add(item); // Adiciona à ListView

                AtualizarValorTotalCompra(); // Atualiza o valor total da compra

                // Limpa os campos e foca novamente no campo de código de barras
                txtCodigoBarras.Clear();
                txtNomeProduto.Clear();
                txtValorUnitario.Clear();
                txtQuantidade.Clear();
                txtCodigoBarras.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar produto: " + ex.Message + "\n" + ex.StackTrace); // Mensagem de erro com mais detalhes
            }
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mercadoRonirinDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigoBarras_TextChanged(object sender, EventArgs e)
        {

        }

        private void listViewProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
                // Verifica se algum item foi selecionado
                if (listViewProdutos.SelectedItems.Count > 0)
                {
                    // Preenche os campos com os dados do produto selecionado
                    var itemSelecionado = listViewProdutos.SelectedItems[0];
                    txtCodigoBarras.Text = itemSelecionado.SubItems[0].Text; // Código de barras
                    txtNomeProduto.Text = itemSelecionado.SubItems[1].Text; // Nome do produto
                    txtValorUnitario.Text = itemSelecionado.SubItems[2].Text; // Valor unitário
                    txtQuantidade.Text = itemSelecionado.SubItems[3].Text; // Quantidade
                }
            
        }

        private void txtQuantidade_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AdicionarProduto();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Enter)
                {
                    // Calcula o troco
                    CalcularTroco();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }
        private void CalcularTroco()
        {

            
                // Verifica se o valor total está disponível
                if (decimal.TryParse(lblValorTotal.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal valorTotal) &&
                    decimal.TryParse(TxtValPag.Text, out decimal valorRecebido))
                {
                    if (valorRecebido >= valorTotal)
                    {
                        // Calcula o troco
                        decimal troco = valorRecebido - valorTotal;

                        // Exibe o troco formatado como moeda
                        TrocoTxt.Text = troco.ToString("C");

                        // Atualiza a tabela Pagamentos
                        Conecte conexao = new Conecte();
                        string queryPagamento = "INSERT INTO Pagamentos (ID_Venda, Metodo_Pagamento, Valor_Pago, Troco) " +
                                                "VALUES (@ID_Venda, @Metodo_Pagamento, @Valor_Pago, @Troco)";

                        using (var cmd = new SqlCommand(queryPagamento, conexao.ReturnConnection()))
                        {
                            cmd.Parameters.Add(new SqlParameter("@ID_Venda", SqlDbType.Int) { Value = idVendaAtual });
                            cmd.Parameters.Add(new SqlParameter("@Metodo_Pagamento", SqlDbType.VarChar) { Value = "Dinheiro" }); // Pode ser ajustado conforme necessário
                            cmd.Parameters.Add(new SqlParameter("@Valor_Pago", SqlDbType.Decimal) { Value = valorRecebido });
                            cmd.Parameters.Add(new SqlParameter("@Troco", SqlDbType.Decimal) { Value = troco });

                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        MessageBox.Show("O valor recebido não pode ser menor que o valor total.");
                    }
                }
                else
                {
                    MessageBox.Show("Valores inválidos. Por favor, insira corretamente o valor recebido.");
                }
            

        }

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PontoVenda_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // Verifica se a tecla pressionada foi "Enter"
            if (e.KeyCode == Keys.Enter && listViewProdutos.SelectedItems.Count > 0)
            {
                // Preenche os campos com os dados do item selecionado
                var itemSelecionado = listViewProdutos.SelectedItems[0];
                txtCodigoBarras.Text = itemSelecionado.SubItems[0].Text;
                txtNomeProduto.Text = itemSelecionado.SubItems[1].Text;
                txtValorUnitario.Text = itemSelecionado.SubItems[2].Text;
                txtQuantidade.Text = itemSelecionado.SubItems[3].Text;
            }

            // Verifica se a tecla pressionada foi "Delete"
            if (e.KeyCode == Keys.Delete && listViewProdutos.SelectedItems.Count > 0)
            {
                // Remove o item selecionado da ListView
                listViewProdutos.Items.Remove(listViewProdutos.SelectedItems[0]);
                AtualizarValorTotalCompra(); // Atualiza o valor total após a remoção
            }
        }
        private void PreencherCamposParaEdicao()
        {
            if (listViewProdutos.SelectedItems.Count > 0)
            {
                var itemSelecionado = listViewProdutos.SelectedItems[0];

                // Preenche os campos com os dados do item
                txtCodigoBarras.Text = itemSelecionado.SubItems[0].Text;
                txtNomeProduto.Text = itemSelecionado.SubItems[1].Text;
                txtValorUnitario.Text = itemSelecionado.SubItems[2].Text;
                txtQuantidade.Text = itemSelecionado.SubItems[3].Text;

                // Remove o item da ListView (opcional, para evitar duplicação ao salvar novamente)
                listViewProdutos.Items.Remove(itemSelecionado);

                MessageBox.Show("Campos preenchidos para edição. Faça as alterações e clique em salvar.");
            }
            else
            {
                MessageBox.Show("Selecione um item para editar.");
            }
        }
        private void RemoverItemSelecionado()
        {
            if (listViewProdutos.SelectedItems.Count > 0)
            {
                var itemSelecionado = listViewProdutos.SelectedItems[0];

                // Confirmação de exclusão
                DialogResult confirmacao = MessageBox.Show(
                    "Deseja realmente excluir o item selecionado?",
                    "Excluir Item",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmacao == DialogResult.Yes)
                {
                    listViewProdutos.Items.Remove(itemSelecionado); // Remove o item
                    MessageBox.Show("Item excluído com sucesso.");
                }
            }
            else
            {
                MessageBox.Show("Selecione um item para excluir.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listViewProdutos.SelectedItems.Count > 0)
            {
                // Obtém o item selecionado
                var itemSelecionado = listViewProdutos.SelectedItems[0];

                // Atualiza os valores no item selecionado
                itemSelecionado.SubItems[0].Text = txtCodigoBarras.Text;   // Atualiza o código de barras
                itemSelecionado.SubItems[1].Text = txtNomeProduto.Text;     // Atualiza o nome do produto
                itemSelecionado.SubItems[2].Text = txtValorUnitario.Text;   // Atualiza o valor unitário
                itemSelecionado.SubItems[3].Text = txtQuantidade.Text;      // Atualiza a quantidade

                // Limpa os campos após a edição
                txtCodigoBarras.Clear();
                txtNomeProduto.Clear();
                txtValorUnitario.Clear();
                txtQuantidade.Clear();

                // Refoca no campo Código de Barras
                txtCodigoBarras.Focus();
            }
            else
            {
                MessageBox.Show("Selecione um produto para editar.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listViewProdutos.SelectedItems.Count > 0)
            {
                // Remove o item selecionado da ListView
                listViewProdutos.Items.Remove(listViewProdutos.SelectedItems[0]);

                // Atualiza o valor total da compra (caso haja essa funcionalidade)
                AtualizarValorTotalCompra();
            }
            else
            {
                MessageBox.Show("Selecione um produto para deletar.");
            }
        }
    }
}

