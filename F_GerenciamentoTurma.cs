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
    public partial class F_GerenciamentoTurma : Form
    {
        public F_GerenciamentoTurma()
        {
            InitializeComponent();
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            cb_idprofessor.Text = "";
            cb_idhorario.Text = "";
            cb_idcurso.Text = "";
            num_qtdaluno.Text = "";
            cb_status.Text = "";
            tb_id.Text = "";
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            F_Turma f_turma = new F_Turma();
            f_turma.ShowDialog();
            dgv_turma.DataSource = Banco.ObterTurmaID();
        }

        private void bt_atualizar_Click(object sender, EventArgs e)
        {
            int linha = dgv_turma.SelectedRows[0].Index;

            Turma turma = new Turma();
            turma.id_turma = Convert.ToInt32(tb_id.Text);
            turma.id_prof_turma = Convert.ToInt32(cb_idprofessor.Text);
            turma.id_horario_turma = Convert.ToInt32(cb_idhorario.Text);
            turma.max_alunos_turma = Convert.ToInt32(num_qtdaluno.Text);
            turma.status_turma = cb_status.Text;
            turma.id_curso_turma = Convert.ToInt32(cb_idcurso.Text);


            Banco.AtualizarTurma(turma);


            dgv_turma[1, linha].Value = cb_idprofessor.Text;
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Confirmar Exclusão?", "Excluir Turma", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                Banco.RemoverTurma(tb_id.Text);
                dgv_turma.Rows.Remove(dgv_turma.CurrentRow);

                cb_idprofessor.Text = "";
                cb_idhorario.Text = "";
                cb_idcurso.Text = "";
                num_qtdaluno.Text = "";
                cb_status.Text = "";
                tb_id.Text = "";
            }
        }

        private void F_GerenciamentoTurma_Load(object sender, EventArgs e)
        {
            string sql = @"
                    SELECT 
                           tt.id_turma AS Id,
                           tt.desc_turma  AS Turma,
                           th.descricao_horario AS Horário
                       FROM
                         tb_turmas as tt
                       INNER JOIN  tb_horarios as th on th.id_horario = tt.id_horario_turma
                      
                     ";



            // Popular ComboBox
            string sqlProf = @"
                            SELECT
                                    id_professor,
                                    nome_professor
                                FROM
                                    tb_professor
                                    ORDER BY
                                    id_professor                                
                        
                    ";
            cb_idprofessor.Items.Clear();
            cb_idprofessor.DataSource = Banco.Dql(sqlProf);
            cb_idprofessor.DisplayMember = "nome_professor";
            cb_idprofessor.ValueMember = "id_professor";

            //Popular ComboBox Status
            Dictionary<string, string> status = new Dictionary<string, string>();
            status.Add("A", "Ativa");
            status.Add("F", "Finalizada");
            status.Add("I", "Inscrição");
            cb_status.Items.Clear();
            cb_status.DataSource = new BindingSource(status, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";



            // Popular ComboBoxHorarios
            string sqlHorario = @"
                            SELECT
                                    *
                                FROM
                                    tb_horario
                                    ORDER BY
                                    descricao_horario                              
                        
                    ";
            cb_idhorario.Items.Clear();
            cb_idhorario.DataSource = Banco.Dql(sqlHorario);
            cb_idhorario.DisplayMember = "descricao_horario";
            cb_idhorario.ValueMember = "id_horario";

            string sqlCurso = @"
                            SELECT
                                    id_curso,
                                    nome_curso
                                FROM
                                    tb_curso
                                    ORDER BY
                                    id_curso
                        
                    ";
            cb_idcurso.Items.Clear();
            cb_idcurso.DataSource = Banco.Dql(sqlCurso);
            cb_idcurso.DisplayMember = "nome_curso";
            cb_idcurso.ValueMember = "id_curso";

            dgv_turma.DataSource = Banco.ObterTurmaID();

            dgv_turma.Columns[0].Width = 40;
            dgv_turma.Columns[1].Width = 180;

          

        }

        private void dgv_turma_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            int qtdLinhas = dgv.SelectedRows.Count;

            if (qtdLinhas > 0)
            {
                DataTable dt = new DataTable();
                string turmaId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosPorIdTurma(turmaId);

                tb_id.Text = dt.Rows[0].Field<Int64>("id_turma").ToString();
                cb_idprofessor.Text = dt.Rows[0].Field<Int64>("id_prof_turma").ToString();
                cb_idhorario.Text = dt.Rows[0].Field<Int64>("id_horario_turma").ToString();
                num_qtdaluno.Text = dt.Rows[0].Field<Int64>("max_alunos_turma").ToString();
                cb_status.Text = dt.Rows[0].Field<string>("status_turma").ToString();
                cb_idcurso.Text = dt.Rows[0].Field<Int64>("id_curso_turma").ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }
    }
}
    




