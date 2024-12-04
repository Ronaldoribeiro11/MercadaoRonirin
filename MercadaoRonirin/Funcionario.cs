using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadaoRonirin
{
    internal class Funcionario
    {
    }


    // Método para salvar dados no banco de dados
    public class OperadorCaixa
    {
        public string NomeOperador { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int FuncFuncionario { get; set; } // Inteiro que representa a função do funcionário
    }

    public class OperadorCaixaService
    {
        // Método para inserir operador de caixa com senha criptografada

        private bool OperadorJaExiste(string nome, string email)
        {
            using (var conexao = new Conecte().ReturnConnection())
            {
                string query = "SELECT COUNT(*) FROM Operadores_Caixa " +
                               "WHERE Nome_Operador = @Nome_Operador OR Email = @Email";

                using (var cmd = new SqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@Nome_Operador", nome);
                    cmd.Parameters.AddWithValue("@Email", email);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0; // Retorna verdadeiro se já existir um registro
                }
            }
        }


        public void InserirOperadorCaixa(OperadorCaixa operador)
        {
            try
            {
                // Verifica se o operador já existe
                if (OperadorJaExiste(operador.NomeOperador, operador.Email))
                {
                    Console.WriteLine("Um operador com o mesmo nome ou e-mail já está cadastrado.");
                    MessageBox.Show("Erro: Nome ou e-mail já cadastrado. Insira informações únicas.");
                    return; // Interrompe o processo se o operador já existir
                }

                using (var conexao = new Conecte().ReturnConnection())
                {
                    string query = "INSERT INTO Operadores_Caixa (Nome_Operador, Email, Senha, Func_Funcionario) " +
                                   "VALUES (@Nome_Operador, @Email, @Senha, @Func_Funcionario)";

                    using (var cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Nome_Operador", operador.NomeOperador);
                        cmd.Parameters.AddWithValue("@Email", operador.Email);
                        cmd.Parameters.AddWithValue("@Senha", CriptografarSenha(operador.Senha));
                        cmd.Parameters.AddWithValue("@Func_Funcionario", operador.FuncFuncionario);

                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Operador de caixa inserido com sucesso!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir operador de caixa: " + ex.Message);
            }
        }

        // Método para criptografar a senha usando SHA-256
        private string CriptografarSenha(string senha)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));
                StringBuilder builder = new StringBuilder();

                // Converte cada byte do hash em uma string hexadecimal
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }
        public int? LogarOperadorCaixa(string email, string senha)
        {
            try
            {
                using (var conexao = new Conecte().ReturnConnection())
                {
                    string query = "SELECT ID_Operador_Caixa, Senha, Func_Funcionario " +
                                   "FROM Operadores_Caixa " +
                                   "WHERE Nome_Operador = @Nome_Operador";

                    using (var cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Nome_Operador", email);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string senhaCriptografadaBanco = reader["Senha"].ToString();
                                int funcFuncionario = (int)reader["Func_Funcionario"];
                                int idOperador = (int)reader["ID_Operador_Caixa"];

                                // Criptografa a senha fornecida para comparar com a armazenada
                                string senhaCriptografadaInput = CriptografarSenha(senha);

                                if (senhaCriptografadaInput == senhaCriptografadaBanco)
                                {
                                    // Salva o ID do operador de caixa para o uso dentro do sistema
                                    SessaoOperador.IDOperadorLogado = idOperador;

                                    // Redireciona o operador de acordo com o campo Func_Funcionario
                                    switch (funcFuncionario)
                                    {
                                        case 1:
                                            // Abrir tela 1
                                            PontoVenda pontoVenda = new PontoVenda(idOperador);
                                            pontoVenda.Show();
                                            break;
                                        case 2:
                                            // Abrir tela 2
                                            AbrirTela2();
                                            break;
                                        case 3:
                                            // Abrir tela 3
                                            AbrirTela3();
                                            break;
                                        default:
                                            MessageBox.Show("Função não reconhecida.");
                                            break;
                                    }

                                    return idOperador;
                                }
                                else
                                {
                                    MessageBox.Show("Senha incorreta.");
                                    return null;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Usuário não encontrado.");
                                return null;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar logar: " + ex.Message);
                return null;
            }
        }


        // Classe para manter a sessão do operador logado
        public static class SessaoOperador
        {
            public static int? IDOperadorLogado { get; set; }
        }

        // Métodos para abrir as telas de acordo com o tipo de função
        private void AbrirTela1()
        {
            // Código para abrir a tela 1
        }

        private void AbrirTela2()
        {
            // Código para abrir a tela 2
        }

        private void AbrirTela3()
        {
            // Código para abrir a tela 3
        }

    }
}



