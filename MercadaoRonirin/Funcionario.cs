using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MercadaoRonirin
{
    internal class Funcionario
    {
    }
        public class Funcionarios
        {
            // Propriedades
            public string Login { get; set; }
            public string Email { get; set; }
            private string Senha { get; set; } // Senha criptografada
            private string TipoFuncionario { get; set; }

        // Construtor
        public Funcionarios(string login, string email, string senha,string tipofuncionario)
            {
                Login = login;
                Email = email;
                Senha = CriptografarSenha(senha);
                TipoFuncionario = tipofuncionario;
            }

            // Método para criptografar a senha
            private string CriptografarSenha(string senha)
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(senha);
                    byte[] hashBytes = sha256.ComputeHash(bytes);
                    return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                }
            }

            // Método para salvar dados no banco de dados
            public void SalvarNoBancoDeDados()
            {
                string stringConnection = @"Data Source=" + Environment.MachineName +
                    @";Initial Catalog=MercadoRonirin;Integrated Security=true";

                using (SqlConnection conexao = new SqlConnection(stringConnection))
                {
                    conexao.Open();

                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = conexao;
                    sqlCommand.CommandText = @"INSERT INTO Funcionarios VALUES (@Login, @Email, @Senha, @TipoServico)";
                    sqlCommand.Parameters.AddWithValue("@Login", Login);
                    sqlCommand.Parameters.AddWithValue("@Email", Email);
                    sqlCommand.Parameters.AddWithValue("@Senha", Senha);
                    sqlCommand.Parameters.AddWithValue("@TipoServico", TipoFuncionario);
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
}
