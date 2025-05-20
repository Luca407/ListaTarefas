using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ListaTarefas
{
    class usuario
    {
        public int Id_usuario { get; set; }
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }

        private bool CadastroUser()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoBD().Conectar())
                {
                    string inserir = "insert into Usuarios (Nome, Usuario, Senha) values (@Nome, @Usuario, @Senha)";

                    MySqlCommand comando = new MySqlCommand(inserir, conexaoBanco);

                    comando.Parameters.AddWithValue("@Nome", Nome);
                    comando.Parameters.AddWithValue("@Usuario", Usuario);
                    comando.Parameters.AddWithValue("@Senha", Senha);

                    int resultado = comando.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível cadastrar usuário -> " + ex.Message, "Erro - Verificar Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private bool VerificarLogin()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoBD().Conectar())
                {

                    //Consultando se o usuário e senha informados existem no banco de dados
                    string consultaUsuarios = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario AND Senha = @Senha";
                    MySqlCommand comando = new MySqlCommand(consultaUsuarios, conexaoBanco);

                    comando.Parameters.AddWithValue("@Nome", Nome);
                    comando.Parameters.AddWithValue("@Usuario", Usuario);
                    comando.Parameters.AddWithValue("@Senha", Senha);

                    int resultado = Convert.ToInt32(comando.ExecuteScalar());

                    if (resultado > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível verificar login -> " + ex.Message, "Erro - Verificar Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

    }
}
