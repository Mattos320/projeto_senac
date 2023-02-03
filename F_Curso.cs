using System;
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
    public partial class F_Curso: Form
    {
       

        public F_Curso()
        {
            InitializeComponent();
            
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            tb_curso.Text = "";
            tb_acurso.Text = "";
            cb_status.Text = "";
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            curso.nome_curso = tb_curso.Text;
            curso.area_curso = tb_acurso.Text;
            curso.status_curso = cb_status.Text;
            Banco.NovoCurso(curso);
        }

        private void tb_acurso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
