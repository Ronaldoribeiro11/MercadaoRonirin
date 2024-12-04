using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadaoRonirin
{
    internal class BancoCaixa
    {
        public class ProdutoRepository
        {
            private string stringConnection = @"Data Source=" + Environment.MachineName +
                                @";Initial Catalog=MercadoRonirin;Integrated Security=true";

                
            public Produtin ObterProdutoPorCodigoBarras(string codigoBarras)
            {
                using (SqlConnection conexao = new SqlConnection(stringConnection))
                {
                    var query = "SELECT * FROM Produtos WHERE CodigoBarras = @CodigoBarras";
                    var command = new SqlCommand(query, conexao);
                    command.Parameters.AddWithValue("@CodigoBarras", codigoBarras);
                    conexao.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Produtin
                            {

                                CodigoBarras = reader["CodigoBarras"].ToString(),
                                Nome = reader["Nome"].ToString(),
                                ValorUnitario = (decimal)reader["ValorUnitario"],
                                ID_Produto = (int)reader["Id"]
                            };
                        }
                    }
                }
                return null;
            }

            public void AdicionarProduto(Produtin produto)
            {
                using (var connection = new SqlConnection(stringConnection))
                {
                    var query = "INSERT INTO Produtos (CodigoBarras, Nome, ValorUnitario) VALUES (@CodigoBarras, @Nome, @ValorUnitario)";
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CodigoBarras", produto.CodigoBarras);
                    command.Parameters.AddWithValue("@Nome", produto.Nome);
                    command.Parameters.AddWithValue("@ValorUnitario", produto.ValorUnitario);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            // Outros métodos para buscar, atualizar e deletar produtos
        }

    }

}
