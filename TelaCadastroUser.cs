using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaTarefas
{
    public partial class TelaCadastroUser : Form
    {
        public TelaCadastroUser()
        {
            InitializeComponent();
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCadastroNome.Text.Equals("") && !txtCadastroSenha.Text.Equals("") && !txtCadastroUser.Text.Equals("") )
                {
                    usuario novoUsuario = new usuario();
                    novoUsuario.Nome = txtCadastroNome.Text;
                    novoUsuario.Usuario = txtCadastroUser.Text;
                    novoUsuario.Senha = txtCadastroSenha.Text;

                    string validacao = novoUsuario.ValidarCadastro();

                    if(validacao != null)
                    {
                        MessageBox.Show(validacao);
                        return;
                    }

                    if (novoUsuario.CadastroUser())
                    {
                        MessageBox.Show("Cadastro realizado com sucesso");
                        TelaLoginUser telaLogin = new TelaLoginUser();
                        telaLogin.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar usuário");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o usuário: " + ex.Message);
                throw;
            }
        }

        private void TelaCadastroUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void llblVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaLoginUser telaLogin = new TelaLoginUser();
            telaLogin.Show();
            this.Hide();
        }
    }
}
