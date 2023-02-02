﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEscola2
{
    public partial class F_Professor : Form
    {

        public F_Professor()
        {
            InitializeComponent();

        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            tb_nome.Text = "";
            tb_tel.Text = "";
            tb_turno.Text = "";
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor();
            professor.nome_professor = tb_nome.Text;
            professor.telefone_professor = tb_tel.Text;
            professor.turno_professor = tb_turno.Text;
            Banco.NovoProfessor(professor);
        }

        private void tb_nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
