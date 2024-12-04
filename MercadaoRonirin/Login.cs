using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MercadaoRonirin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        public string CodigoInserido { get; private set; }
        public static string GerarCodigoVerificacao()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        private bool ValidarCamposOperador()
        {
            if (string.IsNullOrWhiteSpace(txtNomeCad.Text))
            {
                MessageBox.Show("O campo Nome do Operador é obrigatório.");
                txtNomeCad.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmailCad.Text) || !EmailValido(txtEmailCad.Text))
            {
                MessageBox.Show("Por favor, insira um e-mail válido.");
                txtEmailCad.Focus();
            }
            else
            {
                MessageBox.Show("E-mail válido!");
                // Continue com o restante da lógica de cadastro ou login
            }

            if (string.IsNullOrWhiteSpace(txtSenhaCad.Text))
            {
                MessageBox.Show("O campo Senha é obrigatório.");
                txtSenhaCad.Focus();
                return false;
            }

            return true; // Todos os campos estão preenchidos
        }
        private bool EmailValido(string email)
        {
            // Expressão regular para validar o e-mail
            string padraoEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            // Verifica se o e-mail corresponde ao padrão
            return Regex.IsMatch(email, padraoEmail);
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PanalCad.Location = new Point(306, 60);
            PanalCad.Show();
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            CodigoInserido = txtcod.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            if (ValidarCamposOperador())
            {
                int FuncFuncionari = CbServico.SelectedIndex + 1; //se for pra ediçao colocar sempre mais um
                var operador = new OperadorCaixa
                {
                    NomeOperador = txtNomeCad.Text, // Obtém o valor do campo de nome
                    Email = txtEmailCad.Text,               // Obtém o valor do campo de email
                    Senha = txtSenhaCad.Text,
                    FuncFuncionario = FuncFuncionari

                };

                var operadorService = new OperadorCaixaService();
                operadorService.InserirOperadorCaixa(operador);

                MessageBox.Show("Operador de caixa salvo com sucesso!");
                PanalCad.Hide();

            } // Código para inserir os dados no banco de dados

            else
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
            }

        }
    

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PanelRecEmail.Location = new Point(306, 60);
            PanelRecEmail.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void pancod_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            // Obtenha os valores dos campos de entrada
            string email = txtNomeLog.Text;
            string senha = txtSenhaLog.Text;

            // Instancia o serviço de OperadorCaixaService
            var operadorService = new OperadorCaixaService();

            // Chama o método LogarOperadorCaixa e verifica o retorno
            int? idOperador = operadorService.LogarOperadorCaixa(email, senha);

            if (idOperador.HasValue)
            {
                // Login bem-sucedido e operador logado com sucesso
                MessageBox.Show("Login realizado com sucesso!");

                // A função da próxima tela é automaticamente chamada no método LogarOperadorCaixa
            }
            else
            {
                // Exibe mensagem de erro para o usuário
                MessageBox.Show("Falha no login. Verifique suas credenciais.");
            }
        }

            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtLoginCad_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btncod_Click(object sender, EventArgs e)
        {

        }

        private void BtnRecEmail_Click(object sender, EventArgs e)
        {

        }
    }
}
