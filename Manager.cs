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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
            DisplayManager();

        }

        SqlConnection Con = new SqlConnection(@"Data Source=ALIFS-STATION\SQLEXPRESS;Initial Catalog=StudyAssistDb;Persist Security Info=True;User ID=sa;Password=alif123");
        private void DisplayManager()
        {
            Con.Open();
            string Query = "Select * from ManagerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder bldr = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            MgrDvg.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void CrtBtn_Click(object sender, EventArgs e)
        {
            if (MgrNameTb.Text == "" || Salary.Text =="" || MgrGenGb.SelectedIndex==-1 || DobPb.Text=="" || branchCb.SelectedIndex== -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into ManagerTbl(MgrName,MgrGen,MgrDob,MgrBranch,MgrSalary)values (@Mname,@MGen,@MDob,@MBranch,@MSalary)", Con);
                    cmd.Parameters.AddWithValue("@Mname", MgrNameTb.Text);
                    cmd.Parameters.AddWithValue("@MGen", MgrGenGb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@MDob", DobPb.Value.Date);
                    cmd.Parameters.AddWithValue("@MBranch", branchCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@MSalary", SalarySb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Manager Added");
                    Con.Close();
                    DisplayManager();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }
            
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Reset()
        {
             Key = 0;
             MgrNameTb.Text = "";
             SalarySb.Text = "";
             MgrGenGb.SelectedIndex = 0;
             branchCb.SelectedIndex = 0;
        }
        int Key = 0;

        public object MgrId { get; private set; }

        private void MgrDvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             MgrNameTb.Text = MgrDvg.Rows[e.RowIndex].Cells[1].Value.ToString(); ;
             MgrGenGb.SelectedItem = MgrDvg.Rows[e.RowIndex].Cells[2].Value.ToString();
             DobPb.Text = MgrDvg.Rows[e.RowIndex].Cells[3].Value.ToString();
             branchCb.SelectedItem = MgrDvg.Rows[e.RowIndex].Cells[4].Value.ToString();
             SalarySb.Text = MgrDvg.Rows[e.RowIndex].Cells[5].Value.ToString();



            if (MgrNameTb.Text== "")
             {
                 Key = 0;
             }
             else
             {
                 Key = Convert.ToInt32(MgrDvg.Rows[e.RowIndex].Cells[0].Value.ToString());
             }
            

        }

        private void DltBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0) 
            {
                MessageBox.Show("Select Manager");
            }
            else
            {
               try
               {
                    SqlCommand cmd = new SqlCommand("DELETE FROM ManagerTbl where MgrId=@Key", Con);
                    Con.Open();
                    cmd.Parameters.AddWithValue("@Key", Key);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Manager Deleted");
                    DisplayManager();
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
            if (MgrNameTb.Text == "" || Salary.Text == "" || MgrGenGb.SelectedIndex == -1 || DobPb.Text == "" || branchCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE ManagerTbl SET MgrName=@Mname,MgrGen=@MGen,MgrDob=@MDob,MgrBranch=@MBranch,MgrSalary=@MSalary WHERE MgrId=@Key", Con);
                    cmd.Parameters.AddWithValue("@Key", Key);
                    cmd.Parameters.AddWithValue("@Mname", MgrNameTb.Text); 
                    cmd.Parameters.AddWithValue("@MGen", MgrGenGb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@MDob", DobPb.Value.Date);
                    cmd.Parameters.AddWithValue("@MBranch", branchCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@MSalary", SalarySb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Manager Data Updated");
                    Con.Close();
                    DisplayManager();
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
