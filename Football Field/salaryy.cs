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

namespace Football_Field
{
    public partial class salaryy : Form
    {
        public salaryy()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-A78BTSK\SQLEXPRESS;Initial Catalog=EmployeeMyOwn;Integrated Security=True");
        private void button3_Click(object sender, EventArgs e)
        {
            fetdata();
        }

        private void teamm_Load(object sender, EventArgs e)
        {

        }
        private void fetdata()
        {
            Con.Open();
            String query = "select * from Employeee where EmpId='" + EmpidTb.Text + "' ";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            Con.Close();
            foreach (DataRow dr in dt.Rows)
            {
                EmpNameTb.Text = dr["EmpName"].ToString();
                
                EEmpposs.SelectedItem = dr["EmpPos"].ToString();





                 
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        int Dailybase, total;

        private void button1_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("=====Employeeee Salary Document=====", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(180));
            e.Graphics.DrawString("Employee ID: " + EmpidTb.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Red, new Point(10, 100));
            e.Graphics.DrawString("Employee Name: " + EmpNameTb.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Red, new Point(10, 140));
            e.Graphics.DrawString("Employee Position: " + EEmpposs.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Red, new Point(10, 180));
            e.Graphics.DrawString("Worked Day: " + workedH.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Red, new Point(10, 220));
            e.Graphics.DrawString("Daily Pay: " + Dailybase, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Red, new Point(10, 260));
            e.Graphics.DrawString("Daily Salary: " + total, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Red, new Point(10, 300));
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { 
            
     
            if (EEmpposs.Text == "")
            {
                MessageBox.Show("Select an Employeee");
            }
            else if (workedH.Text == "" || Convert.ToInt32(workedH.Text) > 28)
            {
                MessageBox.Show("Enter valid number of day");
            }
            else
            { 

                if (EEmpposs.Text == "ST")
                {
                    Dailybase = 10550;
                }else if(EEmpposs.Text == "LW")
                {                                                 
                    Dailybase = 19999;
                }else if(EEmpposs.Text == "RW")
                {
                    Dailybase = 1010;
                }else if (EEmpposs.Text == "CAM")
                {
                    Dailybase = 1000;
                }
                else if (EEmpposs.Text == "CA")
                {
                    Dailybase = 10050;
                }
                else if (EEmpposs.Text == "CDM")
                {

                    Dailybase = 10009;
                }
                else if (EEmpposs.Text == "LB")
                {
                    Dailybase = 25000;
                }
                else if (EEmpposs.Text == "RB")
                {
                    Dailybase = 16500;
                }
                else if (EEmpposs.Text == "CB")
                {
                    Dailybase = 68950;
                }
                else if (EEmpposs.Text == "GR")
                {
                    Dailybase = 86502;
                }
                else if (EEmpposs.Text == "Doctor")
                {
                    Dailybase = 856;
                }
                else if (EEmpposs.Text == "Developer")
                {
                    Dailybase = 560;
                }
                else if (EEmpposs.Text == "President")
                {
                    Dailybase = 1520;
                }
                else if (EEmpposs.Text == "Coach")
                {
                    Dailybase = 1751;
                }

                total = Dailybase * Convert.ToInt32(workedH.Text);
                salary.Text = "Employee ID: "+ EmpidTb.Text + "\n" +"Employee Name: "+ EmpNameTb.Text + "\n" +"Employee Position:  "+ EEmpposs.Text + "\n" +"Employee Day worked: "+ workedH.Text + "\n" +"Daily Salary:  "+ Dailybase + "\n" +"Total Amount: "+ total;
               
              
            }

        }
    }
}
