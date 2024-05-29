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
    public partial class Tutor : Form
    {
        public Tutor()
        {
            InitializeComponent();
            DisplayTutor();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=ALIFS-STATION\SQLEXPRESS;Initial Catalog=StudyAssistDb;Persist Security Info=True;User ID=sa;Password=alif123");
        private void DisplayTutor()
        {
            Con.Open();
            string Query = "Select * from TtrTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder bldr = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TtrDgv.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (TnameTb.Text == "" || TGenGb.SelectedIndex == -1 || TDobDb.Text == "" || TSubSb.SelectedIndex == -1 || TsalSa.Text == ""  || TPhnPb.Text == "" || TAddFb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into TtrTbl(Tname,TGen,TDob,TSub,TSal,TPhone,TAdd)values (@Ttrname,@TtrGen,@TtrDob,@Ttrsub,@Ttrsal,@Ttrphn,@Ttradd)", Con);
                    cmd.Parameters.AddWithValue("@Ttrname", TnameTb.Text);
                    cmd.Parameters.AddWithValue("@TtrGen", TGenGb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TtrDob", TDobDb.Value.Date);
                    cmd.Parameters.AddWithValue("@Ttrsub", TSubSb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Ttrsal", TsalSa.Text);
                    cmd.Parameters.AddWithValue("@Ttrphn", TPhnPb.Text);
                    cmd.Parameters.AddWithValue("@Ttradd", TAddFb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tutor Added");
                    Con.Close();
                    DisplayTutor();
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
        private void Reset()
        {
            Key = 0;
            TnameTb.Text = "";
            TsalSa.Text = "";
            TPhnPb.Text = "";
            TAddFb.Text = "";
            TGenGb.SelectedIndex = 0;
            TSubSb.SelectedIndex = 0;
        }
        int Key = 0;

        public object MgrId { get; private set; }

        

        private void TtrDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TnameTb.Text = TtrDgv.Rows[e.RowIndex].Cells[1].Value.ToString(); ;
            TGenGb.SelectedItem = TtrDgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            TDobDb.Text = TtrDgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            TSubSb.SelectedItem = TtrDgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            TsalSa.Text = TtrDgv.Rows[e.RowIndex].Cells[5].Value.ToString();
            TPhnPb.Text = TtrDgv.Rows[e.RowIndex].Cells[6].Value.ToString();
            TAddFb.Text = TtrDgv.Rows[e.RowIndex].Cells[7].Value.ToString();


            if (TnameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(TtrDgv.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void DltBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select Tutor");
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM TtrTbl where TId=@Key", Con);
                    Con.Open();
                    cmd.Parameters.AddWithValue("@Key", Key);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Tutor Deleted");
                    DisplayTutor();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (TnameTb.Text == "" || TGenGb.SelectedIndex == -1 || TDobDb.Text == "" || TSubSb.SelectedIndex == -1 || TsalSa.Text == "" || TPhnPb.Text == "" || TAddFb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE TtrTbl SET Tname=@Ttrname,TGen=@TtrGen,TDob=@TtrDob,TSub=@Ttrsub,TSal=@Ttrsal,TPhone=@Ttrphn,TAdd=@Ttradd WHERE TId=@Key", Con);
                    cmd.Parameters.AddWithValue("@Key", Key);
                    cmd.Parameters.AddWithValue("@Ttrname", TnameTb.Text);
                    cmd.Parameters.AddWithValue("@TtrGen", TGenGb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TtrDob", TDobDb.Value.Date);
                    cmd.Parameters.AddWithValue("@Ttrsub", TSubSb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Ttrsal", TsalSa.Text);
                    cmd.Parameters.AddWithValue("@Ttrphn", TPhnPb.Text);
                    cmd.Parameters.AddWithValue("@Ttradd", TAddFb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tutor Updated");
                    Con.Close();
                    DisplayTutor();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
           
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }
    }
}
