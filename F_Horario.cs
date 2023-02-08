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
    public partial class F_Horario : Form
    {
        public F_Horario()
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
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            Horario horario = new Horario();
            horario.descricao_horario = tb_horario.Text;
            Banco.NovoHorario(horario);
        }
    }
}
