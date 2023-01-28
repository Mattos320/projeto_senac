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
    public partial class F_GerenciamentodeUsuarios : Form
    {
        F_escola F_gerenciamentousuario;
        DataTable dt = new DataTable();

        public F_GerenciamentodeUsuarios(F_escola f)
        {
            InitializeComponent();
            F_gerenciamentousuario = f;
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
         
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_limpar_Click_1(object sender, EventArgs e)
        {
            tb_nome.Text = "";
            tb_username.Text = "";
            tb_senha.Text = "";
            cb_status.Text = "";
            num_nivel.Text = "";
            tb_id.Text = "";
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {

        }

        private void F_GerenciamentodeUsuarios_Load(object sender, EventArgs e)
        {
            dgv_usuario.DataSource = Banco.ObterUserID();

            dgv_usuario.Columns[0].Width = 40;
            dgv_usuario.Columns[1].Width = 180;
        }

        private void dgv_usuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            F_NewUser f_newuser = new F_NewUser();
            f_newuser.ShowDialog();
            dgv_usuario.DataSource= Banco.ObterUserID();
        }

        private void dgv_usuario_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
