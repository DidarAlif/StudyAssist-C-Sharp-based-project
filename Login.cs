using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyAssist
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            UserName.Text = "";
            PassWord.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Log_Click(object sender, EventArgs e)
        {
            if (UserName.Text == "" || PassWord.Text == "")
            {
                MessageBox.Show("Enter UserName and Password");
            }
            else if (UserName.Text == "Admin" && PassWord.Text == "Password")
            {
                MainMenu Obj = new MainMenu();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("rong Username or Password");
                UserName.Text = "";
                PassWord.Text = "";
            }
        }
    }
}
