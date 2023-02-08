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
    public partial class F_Turma : Form
    {
        public F_Turma()
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
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            Turma turma = new Turma();


            turma.id_prof_turma = Convert.ToInt32(cb_idprofessor.SelectedValue);
           // turma.id_prof_turma = 1;
            turma.id_horario_turma = Convert.ToInt32(cb_idhorario.SelectedValue);
            turma.max_alunos_turma = Convert.ToInt32(Math.Round(num_qtdaluno.Value, 0));
            turma.status_turma = cb_status.Text;
            turma.id_curso_turma = Convert.ToInt32(cb_idcurso.SelectedValue);

            Banco.NovaTurma(turma);
        }

        private void F_Turma_Load(object sender, EventArgs e)
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
        }
    }
}
