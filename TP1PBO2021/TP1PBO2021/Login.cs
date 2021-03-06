using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1PBO2021
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = textusername.Text;
            string password = textpassword.Text;

            if (username == "")
            {
                MessageBox.Show("Username Kosong");
            }
            else if (password != "pbo123")
            {
                MessageBox.Show("Password Salah");
            }
            else
            {
                Form1 home = new Form1();
                this.Hide();
                home.Show();
            }
        }
    }
}
