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
    }
}
