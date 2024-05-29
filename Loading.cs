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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        int startpoint = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint +=1;
            LoadProgress.Value = startpoint;
            Percentage.Text = startpoint +"%";
            if (LoadProgress.Value== 100)
            {
                LoadProgress.Value = 0;
                timer1.Stop();
                Login Obj = new Login();
                this.Hide();
                Obj.Show();
            }
         

        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }
    }
}
