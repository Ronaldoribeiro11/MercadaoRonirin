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
        //private bool IsValidEmail(string email)
        //{
        //    try
        //    {
        //        var addr = new System.Net.Mail.MailAddress(email);
        //        return addr.Address == email;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
        //private string GerarCodigoAleatorio(int tamanho)
        //{
        //    Random random = new Random();
        //    string codigo = string.Empty;
        //    for (int i = 0; i < tamanho; i++)
        //    {
        //        codigo += random.Next(0, 10).ToString();
        //    }
        //    return codigo;
        //}
        //private bool EnviarEmail(string email, string codigo)
        //{
        //    try
        //    {
        //        var message = new MimeMessage();
        //        message.From.Add(new MailboxAddress("Ronaldo Ribeiro", "cafezinroniro@gmail.com"));
        //        message.To.Add(new MailboxAddress("Destinatário", email));
        //        message.Subject = "Código de Verificação";

        //        message.Body = new TextPart("plain")
        //        {
        //            Text = $"Seu código de verificação é: {codigo}"
        //        };

        //        using (var client = new SmtpClient())
        //        {
        //            client.Connect("smtp.mail.yahoo.com", 465, MailKit.Security.SecureSocketOptions.StartTls);
        //            client.Authenticate("mercadoroniro@yahoo.com", "Rere4321");

        //            client.Send(message);
        //            client.Disconnect(true);
        //        }

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erro ao enviar email: " + ex.Message);
        //        return false;
        //    }
        //}
        //private void label4_Click(object sender, EventArgs e)



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

        private void btnCad_Click(object sender, EventArgs e)
        {
            string login = txtLoginCad.Text;
            string email = txtEmailCad.Text;
            string senha = txtSenhaCad.Text;
            //string tipofuncionario = comboBox1.SelectedItem;
            {

                if (string.IsNullOrEmpty(login))
                {
                    MessageBox.Show("Insira um login");
                    if (string.IsNullOrEmpty(email))
                    {
                        MessageBox.Show("Insira um email");
                        if (string.IsNullOrEmpty(login))
                        {
                            MessageBox.Show("insira uma senha");
                        }



                    }

                }

                else
                { 
                    Funcionarios funcionarios = new Funcionarios(login, email, senha, tipofuncionario);
                    funcionarios.SalvarNoBancoDeDados();
                    Console.WriteLine("Usuario Cadastrado");
                }
        //        {

                    //            // Salvar dados no banco de dados aqui
                    //            string stringConnection = @"Data Source="
                    //          + Environment.MachineName +
                    //          @";Initial Catalog=
                    //           MercadoRonirin;Integrated Security=true";
                    //            using (SqlConnection conexao = new SqlConnection(stringConnection))
                    //            {
                    //                conexao.Open();

                    //                SqlCommand sqlCommand = new SqlCommand();
                    //                sqlCommand.Connection = conexao;
                    //                sqlCommand.CommandText = @"INSERT INTO Funcionario VALUES (@Login, @Email, @Senha)";
                    //                sqlCommand.Parameters.AddWithValue("@Login", login);
                    //                sqlCommand.Parameters.AddWithValue("@Email", email);
                    //                sqlCommand.Parameters.AddWithValue("@Senha", senha);
                    //                sqlCommand.ExecuteNonQuery();
                    //            }
                    //            PanalCad.Location = new Point(360, 60);
                    //            PanalCad.Hide();
                    //            // Outras ações após o cadastro aqui
                    //            MessageBox.Show("Cadastro realizado com sucesso! 😊");


                    //        }
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
    }
}
