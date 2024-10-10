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

        private async void btnCad_Click(object sender, EventArgs e)
        {
         

            string login = txtLoginCad.Text;
            string email = txtEmailCad.Text;
            string senha = txtSenhaCad.Text;

            //string tipofuncionario = comboBox1.SelectedItem;


            if (string.IsNullOrEmpty(login))
            {

                MessageBox.Show("Insira um login");
                if (string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Insira um email");
                    if (string.IsNullOrEmpty(senha))
                    {
                        MessageBox.Show("insira uma senha");
                    }
                    else
                    {
                        Funcionarios novoFuncionario = new Funcionarios("Login", "Email", "Senha");

                        // Salvando o funcionário no banco de dados
                        novoFuncionario.SalvarNoBancoDeDados();

                        Console.WriteLine("Funcionário salvo com sucesso!");
                    }
                }

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
            PontoVenda pontoVenda = new PontoVenda();
            pontoVenda.Show();
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
