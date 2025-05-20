namespace ListaTarefas
{
    partial class TelaCadastroUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtCadastroNome = new TextBox();
            label4 = new Label();
            label3 = new Label();
            llblVoltar = new LinkLabel();
            txtCadastroUser = new TextBox();
            txtCadastroSenha = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnCadastrar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCadastroNome);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(llblVoltar);
            groupBox1.Controls.Add(txtCadastroUser);
            groupBox1.Controls.Add(txtCadastroSenha);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnCadastrar);
            groupBox1.Location = new Point(99, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 293);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // txtCadastroNome
            // 
            txtCadastroNome.Location = new Point(41, 42);
            txtCadastroNome.Name = "txtCadastroNome";
            txtCadastroNome.Size = new Size(166, 23);
            txtCadastroNome.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 21);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 8;
            label4.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 243);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 7;
            label3.Text = "Já tem uma conta?";
            // 
            // llblVoltar
            // 
            llblVoltar.AutoSize = true;
            llblVoltar.Location = new Point(91, 258);
            llblVoltar.Name = "llblVoltar";
            llblVoltar.Size = new Size(61, 15);
            llblVoltar.TabIndex = 5;
            llblVoltar.TabStop = true;
            llblVoltar.Text = "Tela Login";
            llblVoltar.LinkClicked += llblVoltar_LinkClicked;
            // 
            // txtCadastroUser
            // 
            txtCadastroUser.Location = new Point(41, 91);
            txtCadastroUser.Name = "txtCadastroUser";
            txtCadastroUser.Size = new Size(166, 23);
            txtCadastroUser.TabIndex = 4;
            // 
            // txtCadastroSenha
            // 
            txtCadastroSenha.Location = new Point(41, 145);
            txtCadastroSenha.Name = "txtCadastroSenha";
            txtCadastroSenha.PasswordChar = '*';
            txtCadastroSenha.Size = new Size(166, 23);
            txtCadastroSenha.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 124);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Senha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 70);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 1;
            label1.Text = "Usuário:";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(83, 199);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.TextAlign = ContentAlignment.BottomCenter;
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // TelaCadastroUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 352);
            Controls.Add(groupBox1);
            Name = "TelaCadastroUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaCadastroUser";
            FormClosed += TelaCadastroUser_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private LinkLabel linkLabel2;
        private TextBox txtCadastroUser;
        private TextBox txtCadastroSenha;
        private Label label2;
        private Label label1;
        private Button btnCadastrar;
        private Label label3;
        private LinkLabel llblVoltar;
        private TextBox txtCadastroNome;
        private Label label4;
    }
}