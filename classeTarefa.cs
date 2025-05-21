using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTarefas
{
    class classeTarefa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        
        public bool InserirTarefa() 
        {
            try
            {
                using MySqlConnection conexaoBanco = new ConexaoBD().Conectar();
                {
                    string inserir = "INSERT INTO Tarefas (Nome, Descricao, DataCriacao) VALUES (@Nome, @Descricao, @DataCriacao)";
                    MySqlCommand comando = new MySqlCommand(inserir, conexaoBanco);
                    comando.Parameters.AddWithValue("@Nome", Nome);
                    comando.Parameters.AddWithValue("@Descricao", Descricao);
                    comando.Parameters.AddWithValue("@DataCriacao", DateTime.Now);
                    int resultado = comando.ExecuteNonQuery();
                    return resultado > 0;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
