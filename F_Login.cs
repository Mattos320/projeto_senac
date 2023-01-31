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
    public partial class F_Login : Form
    {
        F_escola F_login;
        DataTable dt = new DataTable ();

        public F_Login(F_escola f)
        {
            InitializeComponent();
            F_login= f;
        }


        public F_Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string senha = textBox2.Text;

            if (username == "" || senha == "")
            {
                MessageBox.Show("Preencha todos os campos");
                textBox1.Focus();
                return;
            }
            // fim do IF

            //string sql = "SELECT * FROM tb_usuario WHERE username_usuario='"+username+"' AND senha_usuario'"+senha+"'";
              string sql = "SELECT * FROM tb_usuario WHERE username_usuario = '"+username+"' AND senha_usuario = '"+senha+"'";

            dt = Banco.ConsultaSql(sql);
            if (dt.Rows.Count == 1)
            {
                F_login.lb_nivel.Text = dt.Rows[0].ItemArray[0].ToString();
                F_login.lb_Usuario.Text = dt.Rows[0].Field<string>("username_usuario");
                F_login.pb_login.Image = Properties.Resources.bverde;

                Globais.nivel = int.Parse(dt.Rows[0].Field<Int64>("nivel_usuario").ToString());
                Globais.logado = true;
                this.Close();
            }

            else
            {
                MessageBox.Show("Usuário ou Senha incorretos");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
