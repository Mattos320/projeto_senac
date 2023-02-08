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
    public partial class F_escola : Form
    {
        public F_escola()
        {
            InitializeComponent();
            F_Login f_login = new F_Login(this);
            f_login.ShowDialog();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logoofToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que desaja sair? ", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lb_nivel.Text = "--";

                lb_Usuario.Text = "--";

                pb_login.Image = Properties.Resources.bamarela;

                Globais.nivel = 0;
                Globais.logado = false;
            }

        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Login f_login = new F_Login(this);
            f_login.ShowDialog();
        }

        private void f_escola_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lb_Usuario_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 2)
                {
                    F_NewUser f_NewUser = new F_NewUser();
                    f_NewUser.ShowDialog();

                }
                else { MessageBox.Show("Nível de acesso não permitido"); }
            }
            else
            {
                MessageBox.Show("É necessário logar no sistema");
            }
            
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_Curso F_curso = new F_Curso();
            F_curso.ShowDialog();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            F_Professor F_professor = new F_Professor();
            F_professor.ShowDialog();
        }

        private void novoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            F_Aluno F_aluno = new F_Aluno();
            F_aluno.ShowDialog();
        }

        private void gerenciamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GerenciamentodeUsuarios F_gerenciamentousuario = new F_GerenciamentodeUsuarios();
            F_gerenciamentousuario.ShowDialog();
        }

        private void lb_nivel_Click(object sender, EventArgs e)
        {

        }

        private void gestãoDeProfessoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GerenciamentoProfessor F_gerenciamentoprofessor = new F_GerenciamentoProfessor();
            F_gerenciamentoprofessor.ShowDialog();

        }

        private void gestãoDeCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GerenciamentoCurso f_gerenciamentocurso = new F_GerenciamentoCurso();
            f_gerenciamentocurso.ShowDialog();
            
        }

        private void gestãoDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GerenciamentoAluno f_gerenciamentoaluno = new F_GerenciamentoAluno();
            f_gerenciamentoaluno.ShowDialog();
        }

        private void gestãoDeTurmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GerenciamentoTurma f_gerenciamentoturma = new F_GerenciamentoTurma();
            f_gerenciamentoturma.ShowDialog();
        }

        private void novoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            F_Turma F_turma = new F_Turma();
            F_turma.ShowDialog();
        }

        private void novoToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            F_Horario F_horario = new F_Horario();
            F_horario.ShowDialog();
        }

        private void gestãoDeHoráriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GerenciamentoHorario f_gerenciamentohorario = new F_GerenciamentoHorario();
            f_gerenciamentohorario.ShowDialog();
        }
    }
}
