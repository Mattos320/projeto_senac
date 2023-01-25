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
    public partial class F_NewUser : Form
    {
        F_escola F_newuser;
        DataTable dt = new DataTable();

        public F_NewUser(F_escola f)
        {
            InitializeComponent();
            F_newuser = f;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.nome_usuario = tb_nome.Text;
            usuario.username_usuario = tb_username.Text;
            usuario.senha_usuario = tb_senha.Text;
            usuario.status_usuario = cb_status.Text;
            //usuario.nivel_usuario = (Int32)nud_nivel.Value;
            usuario.nivel_usuario = Convert.ToInt32(Math.Round(num_nivel.Value,0));
            Banco.NovoUser(usuario);


        }

        private void tb_nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
