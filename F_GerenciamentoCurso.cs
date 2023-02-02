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
    public partial class F_GerenciamentoCurso : Form
    {
        public F_GerenciamentoCurso()
        {
            InitializeComponent();
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            tb_nome.Text = "";
            tb_area.Text = "";
            tb_status.Text = "";
            tb_id.Text = "";
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Confirmar Exclusão?", "Excluir Curso", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                Banco.RemoverCurso(tb_id.Text);
                dgv_curso.Rows.Remove(dgv_curso.CurrentRow);

                tb_nome.Text = "";
                tb_area.Text = "";
                tb_status.Text = "";
                tb_id.Text = "";
            }
        }

        private void bt_atualizar_Click(object sender, EventArgs e)
        {
            int linha = dgv_curso.SelectedRows[0].Index;

            Curso curso = new Curso();
            curso.id_curso = Convert.ToInt32(tb_id.Text);
            curso.nome_curso = tb_nome.Text;
            curso.area_curso = tb_area.Text;
            curso.status_curso = tb_status.Text;

            Banco.AtualizarCurso(curso);


            dgv_curso[1, linha].Value = tb_nome.Text;
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            F_GerenciamentoCurso f_gerenciamentocurso = new F_GerenciamentoCurso();
            f_gerenciamentocurso.ShowDialog();
            dgv_curso.DataSource = Banco.ObterUserIDCurso();
        }

        private void dgv_curso_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            int qtdLinhas = dgv.SelectedRows.Count;

            if (qtdLinhas > 0)
            {
                DataTable dt = new DataTable();
                string cursoid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosPorIdCurso(cursoid);

                tb_id.Text = dt.Rows[0].Field<Int64>("id_curso").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("nome_curso").ToString();
                tb_area.Text = dt.Rows[0].Field<string>("area_curso").ToString();
                tb_status.Text = dt.Rows[0].Field<string>("status_curso").ToString();
            }
        }

        private void F_GerenciamentoCurso_Load(object sender, EventArgs e)
        {
            dgv_curso.DataSource = Banco.ObterUserIDCurso();

            dgv_curso.Columns[0].Width = 40;
            dgv_curso.Columns[1].Width = 180;
        }
    }
}

