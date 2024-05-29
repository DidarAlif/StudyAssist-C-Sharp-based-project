using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace StudyAssist
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=ALIFS-STATION\SQLEXPRESS;Initial Catalog=StudyAssistDb;Persist Security Info=True;User ID=sa;Password=alif123");
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }
        private void CountManager()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from ManagerTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MgrNm.Text = dt.Rows[0][0].ToString();
            Con.Close();

        }
        private void CountTutor()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from Ttrtbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            TtrNm.Text = dt.Rows[0][0].ToString();
            Con.Close();

        }
        private void CountSchedule()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from SdlTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ScdlNm.Text = dt.Rows[0][0].ToString();
            Con.Close();

        }
        private void CountSalary()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Sum(Amt) from SlryTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            TtlSl.Text = dt.Rows[0][0].ToString();
            Con.Close();

        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            CountManager();
            CountTutor();
            CountSchedule();
            CountSalary();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
