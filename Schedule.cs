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
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
            DisplaySchedule();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=ALIFS-STATION\SQLEXPRESS;Initial Catalog=StudyAssistDb;Persist Security Info=True;User ID=sa;Password=alif123");
        private void DisplaySchedule()
        {
            Con.Open();
            string Query = "Select * from SdlTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder bldr = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ScdlDgv.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            Key = 0;
            EdescEb.Text = "";
            EddWb.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (EdescEb.Text == "" || EddWb.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into SdlTbl(EDesc,EDate,EDuration)values (@Evdesc,@Evdate,@Evdrn)", Con);
                    cmd.Parameters.AddWithValue("@Evdesc", EdescEb.Text);
                    cmd.Parameters.AddWithValue("@Evdate", EdtMe.Value.Date);
                    cmd.Parameters.AddWithValue("@Evdrn", EddWb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Schedule Added");
                    Con.Close();
                    DisplaySchedule();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        int Key = 0;

        private void ScdlDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EdescEb.Text = ScdlDgv.Rows[e.RowIndex].Cells[1].Value.ToString(); ;
            EdtMe.Text = ScdlDgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            EddWb.Text = ScdlDgv.Rows[e.RowIndex].Cells[3].Value.ToString();



            if (EdescEb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ScdlDgv.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void BckBtn_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }

        private void DltBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select Schedule of Event");
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM SdlTbl where EId=@Key", Con);
                    Con.Open();
                    cmd.Parameters.AddWithValue("@Key", Key);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Schedule Deleted");
                    DisplaySchedule();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void EdtBtn_Click(object sender, EventArgs e)
        {
            if (EdescEb.Text == "" || EddWb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE SdlTbl SET EDesc=@Evdesc,EDate=@Evdate,EDuration=@Evdrn WHERE EId=@EvId", Con);
                    cmd.Parameters.AddWithValue("@EvId", Key);
                    cmd.Parameters.AddWithValue("@Evdesc", EdescEb.Text);
                    cmd.Parameters.AddWithValue("@Evdate", EdtMe.Value.Date);
                    cmd.Parameters.AddWithValue("@Evdrn", EddWb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Schedule Updated");
                    Con.Close();
                    DisplaySchedule();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
