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
            int linha = dgv_usuario.SelectedRows[0].Index;

            Usuario user = new Usuario();
            user.id_usuario = Convert.ToInt32(tb_id.Text);
            user.nome_usuario = tb_nome.Text;
            user.username_usuario = tb_username.Text;
            user.senha_usuario = tb_senha.Text;
            user.status_usuario = cb_status.Text;
            user.nivel_usuario = Convert.ToInt32(Math.Round(num_nivel.Value,0));

            Banco.AtualizarUsuario(user);


            dgv_usuario[1,linha].Value = tb_nome.Text;
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
            DialogResult resposta = MessageBox.Show("Confirmar Exclusão?", "Excluir Usuário", MessageBoxButtons.YesNo);

                if(resposta == DialogResult.Yes)
            {
                Banco.RemoverUsuario(tb_id.Text);
                dgv_usuario.Rows.Remove(dgv_usuario.CurrentRow);

                tb_nome.Text = "";
                tb_username.Text = "";
                tb_senha.Text = "";
                cb_status.Text = "";
                num_nivel.Text = "";
                tb_id.Text = "";
            }
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
           DataGridView dgv = sender as DataGridView;
           int qtdLinhas = dgv.SelectedRows . Count;

            if(qtdLinhas > 0 )
            {
                DataTable dt = new DataTable();
                string userId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosPorId(userId);

                tb_id.Text = dt.Rows[0].Field<Int64>("id_usuario").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("nome_usuario").ToString();
                tb_username.Text = dt.Rows[0].Field<string>("username_usuario").ToString();
                tb_senha.Text = dt.Rows[0].Field<string>("senha_usuario").ToString();
                cb_status.Text = dt.Rows[0].Field<string>("status_usuario").ToString();        
                num_nivel.Text = dt.Rows[0].Field<Int64>("nivel_usuario").ToString();

            }
        }
    }
}
