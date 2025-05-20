namespace ListaTarefas
{
    partial class Tarefas
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
            dgvTarefas = new DataGridView();
            groupBox1 = new GroupBox();
            cbStatus = new ComboBox();
            txtNome = new TextBox();
            label4 = new Label();
            txtDesc = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnCadastrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTarefas).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTarefas
            // 
            dgvTarefas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTarefas.Location = new Point(290, 25);
            dgvTarefas.Name = "dgvTarefas";
            dgvTarefas.Size = new Size(359, 305);
            dgvTarefas.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbStatus);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDesc);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnCadastrar);
            groupBox1.Location = new Point(12, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 293);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Pendente", "Concluido" });
            cbStatus.Location = new Point(41, 176);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(90, 23);
            cbStatus.TabIndex = 10;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(41, 42);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(166, 23);
            txtNome.TabIndex = 9;
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
            // txtDesc
            // 
            txtDesc.Location = new Point(41, 91);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(166, 64);
            txtDesc.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 158);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "Situação:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 70);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 1;
            label1.Text = "Descrição:";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(87, 228);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.TextAlign = ContentAlignment.BottomCenter;
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // Tarefas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 352);
            Controls.Add(groupBox1);
            Controls.Add(dgvTarefas);
            Name = "Tarefas";
            Text = "Tarefas";
            FormClosed += Tarefas_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dgvTarefas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTarefas;
        private GroupBox groupBox1;
        private TextBox txtNome;
        private Label label4;
        private TextBox txtDesc;
        private Label label2;
        private Label label1;
        private Button btnCadastrar;
        private ComboBox cbStatus;
    }
}