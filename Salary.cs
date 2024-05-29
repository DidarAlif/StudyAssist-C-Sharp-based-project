using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyAssist
{
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
            DisplaySalary();
            FillManagerId();
            GetManagerName();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=ALIFS-STATION\SQLEXPRESS;Initial Catalog=StudyAssistDb;Persist Security Info=True;User ID=sa;Password=alif123");
        private void DisplaySalary()
        {
            Con.Open();
            string Query = "Select * from SlryTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder bldr = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SlryDgv.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void FillManagerId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT MgrId FROM ManagerTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("MgrId", typeof(int));
            dt.Load(rdr);
            MgrIdtb.ValueMember = "MgrId";
            MgrIdtb.DataSource = dt;
            Con.Close();
        }
        private void GetManagerName()
        {
            Con.Open();
            SqlCommand Cmd = new SqlCommand("SELECT * FROM ManagerTbl WHERE MgrId=@Key", Con);
            Cmd.Parameters.AddWithValue("@Key", MgrIdtb.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                MgrNmNb.Text = dr["MgrName"].ToString();
                MgrAmntMb.Text= dr["MgrSalary"].ToString();
            }
            Con.Close();

        }
        private void Reset()
        {
            MgrAmntMb.Text = "";
            MgrNmNb.Text = "";
            MgrIdtb.SelectedIndex = -1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MgrNmNb.Text == "" || MgrAmntMb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                string paymentperiode;
                paymentperiode = MgrDrnRb.Value.Month.ToString() +"/"+ MgrDrnRb.Value.Year.ToString();
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select COUNT (*) from SlryTbl where MgrId='" + MgrIdtb.SelectedValue.ToString() + "' and Month = '" + paymentperiode.ToString() + "'", Con);
                DataTable dt =new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("There is No Due for This Month");
                }
                else
                {
                    //Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into SlryTbl(MgrId,MgrName,Month,Amt)values (@MaId,@Mname,@Mmnth,@MAmnt)", Con);
                    cmd.Parameters.AddWithValue("@MaId", MgrIdtb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Mname", MgrNmNb.Text);
                    cmd.Parameters.AddWithValue("@Mmnth", paymentperiode);
                    cmd.Parameters.AddWithValue("@MAmnt", MgrAmntMb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fees Paid ");
                }
                Con.Close();
                DisplaySalary();
                Reset();
            }
        }

        private void SlryDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MgrIdtb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetManagerName();
        }

        private void BckBtn_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }
    }
}
