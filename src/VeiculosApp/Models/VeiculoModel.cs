using System.Data.SqlClient;

namespace VeiculosApp.Models
{
    public class VeiculoModel
    {
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
            var connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=VeiculosDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
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
    }
}
