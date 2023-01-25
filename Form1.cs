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
    public partial class F_escola : Form
    {
        public F_escola()
        {
            InitializeComponent();
            F_Login f_login = new F_Login(this);
            f_login.ShowDialog();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logoofToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Login f_login = new F_Login(this);
            f_login.ShowDialog();
        }

        private void f_escola_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lb_Usuario_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NewUser f_newuser = new F_NewUser(this);
            f_newuser.ShowDialog();
        }
    }
}
