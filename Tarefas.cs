﻿using System;
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
    public partial class Tarefas : Form
    {
        private Form telaLogin;
        public Tarefas(Form telaLogin)
        {
            InitializeComponent();
             
        }

        private void Tarefas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }
    }
}
