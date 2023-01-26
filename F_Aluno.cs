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
    public partial class F_Aluno : Form
    {
        F_escola F_aluno;
        DataTable dt = new DataTable();

        public F_Aluno(F_escola f)
        {
            InitializeComponent();
            F_aluno = f;
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            tb_nome.Text = "";
            tb_sobrenome.Text = "";
            tb_tel.Text = "";
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.nome_aluno = tb_nome.Text;
            aluno.sobrenome_aluno = tb_sobrenome.Text;
            aluno.telefone_aluno = tb_tel.Text;
            Banco.NovoAluno(aluno);
        }
    }
}
