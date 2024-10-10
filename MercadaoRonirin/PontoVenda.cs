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
        public PontoVenda()
        {
            InitializeComponent();

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
                TxtValTroco.Text = valorTotalCompra.ToString("C"); // Exibe o valor total da compra
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

                // Query de inserção
                string query = "INSERT INTO Vendas (CodigoBarras, Quantidade, ValorTotal) " +
                               "VALUES (@CodigoBarras, @Quantidade, @ValorTotal)";

                using (var cmd = new SqlCommand(query, conexao.ReturnConnection()))
                {
                    // Adicionando parâmetros
                    cmd.Parameters.Add(new SqlParameter("@CodigoBarras", SqlDbType.VarChar) { Value = txtCodigoBarras.Text });
                    cmd.Parameters.Add(new SqlParameter("@Quantidade", SqlDbType.Int) { Value = quantidade });
                    cmd.Parameters.Add(new SqlParameter("@ValorTotal", SqlDbType.Decimal) { Value = valorTotalItem });

                    // Executa a query
                    cmd.ExecuteNonQuery();
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
    }
}

