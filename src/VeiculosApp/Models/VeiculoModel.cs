using System.Data;
using System.Data.SqlClient;

namespace VeiculosApp.Models
{
    public class VeiculoModel
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=VeiculosDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public int AnoFab { get; set; }
        public string Placa { get; set; }
        public double Valor { get; set; }


        public string ValidarCadastro()
        {
            var mensagemErro = "";

            if (string.IsNullOrEmpty(Titulo))
            {
                mensagemErro += "Título não pode ser vazio.";
            }
            if (string.IsNullOrEmpty(Marca))
            {
                mensagemErro += "Marca não pode ser vazia.";
            }
            if (string.IsNullOrEmpty(Modelo))
            {
                mensagemErro += "Modelo não pode ser vazio.";
            }
            if (AnoFab < 1900 || AnoFab > DateTime.Now.Year)
            {
                mensagemErro += "Ano de fabricação inválido.";
            }
            if (string.IsNullOrEmpty(Placa))
            {
                mensagemErro += "Placa não pode ser vazia.";
            }
            if (Valor <= 0)
            {
                mensagemErro += "Valor deve ser maior que zero.";
            }

            return mensagemErro;
        }

        // Método para salvar no banco de dados usando ADO.NET
        public bool Gravar()
        {
            
            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Veiculos (Titulo, Marca, Modelo, Cor, AnoFab, Placa, Valor) " +
                                   "VALUES ( @Titulo, @Marca, @Modelo, @Cor, @AnoFab, @Placa, @Valor)";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Titulo", Titulo);
                        cmd.Parameters.AddWithValue("@Marca", Marca);
                        cmd.Parameters.AddWithValue("@Modelo", Modelo);
                        cmd.Parameters.AddWithValue("@Cor", Cor);
                        cmd.Parameters.AddWithValue("@AnoFab", AnoFab);
                        cmd.Parameters.AddWithValue("@Placa", Placa);
                        cmd.Parameters.AddWithValue("@Valor", Valor);

                        conexao.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (SqlException ex)
            {
                //mensagemErro = "Erro ao salvar no banco de dados: " + ex.Message;
                return false;
            }
        }

        public bool Excluir()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Veiculos WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Id", Id);

                        conexao.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (SqlException ex)
            {
                //mensagemErro = "Erro ao excluir no banco de dados: " + ex.Message;
                return false;
            }
        }

        public List<VeiculoModel> Listar()
        {
            List<VeiculoModel> veiculos = new List<VeiculoModel>();

            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    string query = "SELECT Id, Titulo, Marca, Modelo, Cor, AnoFab, Placa, Valor FROM Veiculos " +
                        "  order by Titulo, Valor";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        conexao.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                VeiculoModel veiculo = new VeiculoModel
                                {
                                    Id = reader.GetInt32(0),
                                    Titulo = reader.GetString(1),
                                    Marca = reader.GetString(2),
                                    Modelo = reader.GetString(3),
                                    Cor = reader.GetString(4),
                                    AnoFab = reader.GetInt32(5),
                                    Placa = reader.GetString(6),
                                    Valor = Convert.ToDouble(reader.GetDecimal(7))
                                };
                                veiculos.Add(veiculo);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                //mensagemErro = "Erro ao listar no banco de dados: " + ex.Message;
            }

            return veiculos;
        }

        public bool Consultar()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    string query = "SELECT Id, Titulo, Marca, Modelo, Cor, AnoFab, Placa, Valor FROM Veiculos " +
                        "  where Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Id", Id);

                        conexao.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                Id = reader.GetInt32(0);
                                Titulo = reader.GetString(1);
                                Marca = reader.GetString(2);
                                Modelo = reader.GetString(3);
                                Cor = reader.GetString(4);
                                AnoFab = reader.GetInt32(5);
                                Placa = reader.GetString(6);
                                Valor = Convert.ToDouble(reader.GetDecimal(7));
                                return true;
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                //mensagemErro = "Erro ao listar no banco de dados: " + ex.Message;
            }

            return false;
        }
        public bool Atualizar()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Veiculos SET Titulo = @Titulo, Marca = @Marca, Modelo = @Modelo, Cor = @Cor, " +
                        "AnoFab = @AnoFab, Placa = @Placa, Valor = @Valor WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Titulo", Titulo);
                        cmd.Parameters.AddWithValue("@Marca", Marca);
                        cmd.Parameters.AddWithValue("@Modelo", Modelo);
                        cmd.Parameters.AddWithValue("@Cor", Cor);
                        cmd.Parameters.AddWithValue("@AnoFab", AnoFab);
                        cmd.Parameters.AddWithValue("@Placa", Placa);
                        cmd.Parameters.AddWithValue("@Valor", Valor);
                        cmd.Parameters.AddWithValue("@Id", Id);

                        conexao.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (SqlException ex)
            {
                //mensagemErro = "Erro ao atualizar no banco de dados: " + ex.Message;
                return false;
            }
        }
    }
}
