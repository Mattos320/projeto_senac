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
    public partial class F_GerenciamentoHorario : Form
    {
        public F_GerenciamentoHorario()
        {
            InitializeComponent();
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            tb_horario.Text = "";
            tb_id.Text = "";   
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            F_Horario f_horario = new F_Horario();
            f_horario.ShowDialog();
            dgv_horario.DataSource = Banco.ObterHorarioID();
        }

        private void dgv_horario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_atualizar_Click(object sender, EventArgs e)
        {
            int linha = dgv_horario.SelectedRows[0].Index;

            Horario horario = new Horario();
            horario.id_horario = Convert.ToInt32(tb_id.Text);
            horario.descricao_horario = tb_horario.Text;
            


            Banco.AtualizarHorario(horario);


            dgv_horario[1, linha].Value = tb_horario.Text;
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Confirmar Exclusão?", "Excluir Horário", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                Banco.RemoverHorario(tb_id.Text);
                dgv_horario.Rows.Remove(dgv_horario.CurrentRow);

                tb_horario.Text = "";
                tb_id.Text = "";
            }
        }

        private void F_GerenciamentoHorario_Load(object sender, EventArgs e)
        {
            dgv_horario.DataSource = Banco.ObterHorarioID();

            dgv_horario.Columns[0].Width = 40;
            dgv_horario.Columns[1].Width = 180;
        }

        private void dgv_horario_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            int qtdLinhas = dgv.SelectedRows.Count;

            if (qtdLinhas > 0)
            {
                DataTable dt = new DataTable();
                string horarioId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterHorarioPorId(horarioId);

                tb_id.Text = dt.Rows[0].Field<Int64>("id_horario").ToString();
                tb_horario.Text = dt.Rows[0].Field<string>("descricao_horario").ToString();
      
            }
        }
    }
}
