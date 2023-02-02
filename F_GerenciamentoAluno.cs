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
    public partial class F_GerenciamentoAluno : Form
    {
        public F_GerenciamentoAluno()
        {
            InitializeComponent();
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            F_Aluno f_aluno = new F_Aluno();
            f_aluno.ShowDialog();
            dgv_aluno.DataSource = Banco.ObterAlunoID();
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            tb_nome.Text = "";
            tb_sobrenome.Text = "";
            tb_telefone.Text = "";
            tb_id.Text = "";
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Confirmar Exclusão?", "Excluir Aluno", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                Banco.RemoverAluno(tb_id.Text);
                dgv_aluno.Rows.Remove(dgv_aluno.CurrentRow);

                tb_nome.Text = "";
                tb_sobrenome.Text = "";
                tb_telefone.Text = "";
                tb_id.Text = "";
            }
        }

        private void bt_atualizar_Click(object sender, EventArgs e)
        {
            int linha = dgv_aluno.SelectedRows[0].Index;

            Aluno aluno = new Aluno();
            aluno.id_aluno = Convert.ToInt32(tb_id.Text);
            aluno.nome_aluno = tb_nome.Text;
            aluno.sobrenome_aluno = tb_sobrenome.Text;
            aluno.telefone_aluno = tb_telefone.Text;


            Banco.AtualizarAluno(aluno);


            dgv_aluno[1, linha].Value = tb_nome.Text;
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_GerenciamentoAluno_Load(object sender, EventArgs e)
        {
            dgv_aluno.DataSource = Banco.ObterAlunoID();

            dgv_aluno.Columns[0].Width = 40;
            dgv_aluno.Columns[1].Width = 180;
        }

        private void dgv_aluno_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            int qtdLinhas = dgv.SelectedRows.Count;

            if (qtdLinhas > 0)
            {
                DataTable dt = new DataTable();
                string alunoid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosPorIdAluno(alunoid);

                tb_id.Text = dt.Rows[0].Field<Int64>("id_aluno").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("nome_aluno").ToString();
                tb_sobrenome.Text = dt.Rows[0].Field<string>("sobrenome_aluno").ToString();
                tb_telefone.Text = dt.Rows[0].Field<string>("telefone_aluno").ToString();

            }
        }

        private void tb_telelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_aluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
