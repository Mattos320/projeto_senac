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
    public partial class F_GerenciamentoProfessor : Form
    {
        public F_GerenciamentoProfessor()
        {
            InitializeComponent();
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            tb_id.Text = "";
            tb_nome.Text = "";
            tb_telefone.Text = "";
            tb_turno.Text = "";
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_atualizar_Click(object sender, EventArgs e)
        {
            int linha = dgv_professor.SelectedRows[0].Index;

            Professor prof = new Professor();
            prof.id_professor = Convert.ToInt32(tb_id.Text);
            prof.nome_professor = tb_nome.Text;
            prof.telefone_professor = tb_telefone.Text;
            prof.turno_professor = tb_turno.Text;

            Banco.AtualizarProfessor(prof);


            dgv_professor[1,linha].Value = tb_nome.Text;
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Confirmar Exclusão?", "Excluir Professor", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                Banco.RemoverProfessor(tb_id.Text);
                dgv_professor.Rows.Remove(dgv_professor.CurrentRow);

                tb_nome.Text = "";
                tb_telefone.Text = "";
                tb_turno.Text = "";
                tb_id.Text = "";
            }
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            F_Professor f_newuser = new F_Professor();
            f_newuser.ShowDialog();
            dgv_professor.DataSource = Banco.ObterUserIDProfessor();
        }

        private void dgv_usuario_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            int qtdLinhas = dgv.SelectedRows.Count;

            if (qtdLinhas > 0)
            {
                DataTable dt = new DataTable();
                string profId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosPorIdProf(profId);

                tb_id.Text = dt.Rows[0].Field<Int64>("id_professor").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("nome_professor").ToString();
                tb_telefone.Text = dt.Rows[0].Field<string>("telefone_professor").ToString();
                tb_turno.Text = dt.Rows[0].Field<string>("turno_professor").ToString();
                
            }
    }

        private void dgv_usuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void F_GerenciamentoProfessor_Load(object sender, EventArgs e)
        {
            dgv_professor.DataSource = Banco.ObterUserIDProfessor();

            dgv_professor.Columns[0].Width = 40;
            dgv_professor.Columns[1].Width = 180;
        }
    }
}
