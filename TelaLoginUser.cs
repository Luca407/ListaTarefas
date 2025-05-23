namespace ListaTarefas
{
    public partial class TelaLoginUser : Form
    {
        public TelaLoginUser()
        {
            InitializeComponent();
        }

        private void llblCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaCadastroUser telaCadastro = new TelaCadastroUser();
            telaCadastro.Show();
            this.Hide();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtSenha.Text.Equals("") && !txtUser.Text.Equals(""))
                {
                    usuario novoUsuario = new usuario();
                    novoUsuario.Usuario = txtUser.Text;
                    novoUsuario.Senha = txtSenha.Text;
                    if (novoUsuario.VerificarLogin())
                    {
                        string nomeLogado = novoUsuario.BuscarNome();
                        Tarefas telaTarefas = new Tarefas();
                        telaTarefas.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Usu�rio ou senha inv�lidos");
                        txtSenha.Clear();
                        txtUser.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("N�o foi possivel acessar o sistema! " + ex.Message, "Erro - M�todo btnEntrar_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
