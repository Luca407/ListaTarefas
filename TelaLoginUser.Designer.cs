namespace ListaTarefas
{
    partial class TelaLoginUser
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label3 = new Label();
            llblCadastrar = new LinkLabel();
            txtUser = new TextBox();
            txtSenha = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnEntrar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(llblCadastrar);
            groupBox1.Controls.Add(txtUser);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnEntrar);
            groupBox1.Location = new Point(95, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 293);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 228);
            label3.Name = "label3";
            label3.Size = new Size(118, 15);
            label3.TabIndex = 7;
            label3.Text = "Não tem uma conta?";
            // 
            // llblCadastrar
            // 
            llblCadastrar.AutoSize = true;
            llblCadastrar.Location = new Point(85, 243);
            llblCadastrar.Name = "llblCadastrar";
            llblCadastrar.Size = new Size(69, 15);
            llblCadastrar.TabIndex = 5;
            llblCadastrar.TabStop = true;
            llblCadastrar.Text = "Cadastre-se";
            llblCadastrar.LinkClicked += llblCadastrar_LinkClicked;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(41, 62);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(166, 23);
            txtUser.TabIndex = 4;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(41, 116);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(166, 23);
            txtSenha.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 95);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Senha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 41);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 1;
            label1.Text = "Usuário:";
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(83, 170);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.TextAlign = ContentAlignment.BottomCenter;
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // TelaLoginUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 352);
            Controls.Add(groupBox1);
            Name = "TelaLoginUser";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnEntrar;
        private Label label3;
        private LinkLabel llblCadastrar;
        private TextBox txtUser;
        private TextBox txtSenha;
        private Label label2;
        private Label label1;
    }
}
