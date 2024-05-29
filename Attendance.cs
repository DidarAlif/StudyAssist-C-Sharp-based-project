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
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
            DisplayAttendance();
            FillTutorID();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {

        }
        private void FillTutorID()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT TId FROM TtrTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TId", typeof(int));
            dt.Load(rdr);
            TtrIdIb.ValueMember = "TId";
            TtrIdIb.DataSource = dt;
            Con.Close();
        }
        private void GetTutorName()
        {
            Con.Open();
            SqlCommand Cmd = new SqlCommand("SELECT * FROM TtrTbl WHERE TId=@Key", Con);
            Cmd.Parameters.AddWithValue("@Key", TtrIdIb.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows) 
            {
                TnameTb.Text=dr["Tname"].ToString();
            }
            Con.Close();

        }

        SqlConnection Con = new SqlConnection(@"Data Source=ALIFS-STATION\SQLEXPRESS;Initial Catalog=StudyAssistDb;Persist Security Info=True;User ID=sa;Password=alif123");
        private void DisplayAttendance()
        {
            Con.Open();
            string Query = "Select * from AttnTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder bldr = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AttnDgv.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            Key = 0;
            AttSttsSb.SelectedIndex = -1;
            TnameTb.Text = "";
            TtrIdIb.SelectedIndex = -1;
        }
        int Key = 0;
        private void AttnDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TtrIdIb.SelectedItem = AttnDgv.Rows[e.RowIndex].Cells[1].Value.ToString(); ;
            TnameTb.Text = AttnDgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            AttnDatePc.Text = AttnDgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            AttSttsSb.SelectedItem = AttnDgv.Rows[e.RowIndex].Cells[4].Value.ToString();


            if (TnameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(AttnDgv.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void CrtBtn_Click(object sender, EventArgs e)
        {
            if ( TnameTb.Text == ""  || AttSttsSb.SelectedIndex == -1 )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into AttnTbl(AttTid,AttTName,AttDate,AttStatus)values (@AId,@Aname,@ADate,@AStatus)", Con);
                    cmd.Parameters.AddWithValue("@AId", TtrIdIb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Aname", TnameTb.Text);
                    cmd.Parameters.AddWithValue("@ADate", AttnDatePc.Value.Date);
                    cmd.Parameters.AddWithValue("@AStatus", AttSttsSb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendance Taken");
                    Con.Close();
                    DisplayAttendance();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TtrIdIb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTutorName();
        }

        private void RstBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (TnameTb.Text == "" || AttSttsSb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE AttnTbl SET AttTid=@AId,AttTName=@Tname,AttDate=@ADate,AttStatus=@AttStatus WHERE AttnNum=@ANum", Con);
                    cmd.Parameters.AddWithValue("@ANum", Key);
                    cmd.Parameters.AddWithValue("@AId", TtrIdIb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Tname", TnameTb.Text);
                    cmd.Parameters.AddWithValue("@ADate", AttnDatePc.Value.Date);
                    cmd.Parameters.AddWithValue("@AttStatus", AttSttsSb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendance Updated");
                    Con.Close();
                    DisplayAttendance();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void BckBtn_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }
    }
}
