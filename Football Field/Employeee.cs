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
    public partial class Employeee : Form
    {
        public Employeee()
        {
            InitializeComponent();
            populatee();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (EmpidTb.Text == "" || EmpNameTb.Text == "" || EmpPhoneTb.Text == "" || EmpAddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");


            }
            else
            {
                try
               {

                   employs emp = new employs();
            emp.reg(Convert.ToInt32(EmpidTb.Text), EmpNameTb.Text,EmpAddressTb.Text, EmpPossitionTb.Text, EmpDob.Text, EmpPhoneTb.Text, EmpEducTb.Text, EmpGenderTb.SelectedItem.ToString());
            MessageBox.Show("Added");
                    populatee();
               } catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            populate a = new populate();
            List<populate> c1 = a.get_all_employee();
            dataGridView1.DataSource = c1;

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populatee()
        {
           
        }

        private void Employeee_Load(object sender, EventArgs e)
        {
            populatee();
        }
        private void reset()
        {
            EmpidTb.Text = "";
            EmpAddressTb.Text = "";
            EmpNameTb.Text = "";
            EmpPhoneTb.Text = "";
            EmpPossitionTb.SelectedIndex = 0;
            EmpDob.Text = "";
            EmpEducTb.SelectedIndex = 0;
            EmpGenderTb.SelectedIndex = 0;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            
        {

            EmpidTb.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            EmpNameTb.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            EmpAddressTb.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            EmpEducTb.SelectedItem = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            EmpPossitionTb.SelectedItem = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            EmpPhoneTb.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            EmpGenderTb.SelectedItem = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            EmpDob.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

            if(EmpidTb.Text == "")
            {
                MessageBox.Show("Enter Employee Id");


            }
            else
            {
                try
                {
                    deleteEmp del = new deleteEmp();
            del.delete(Convert.ToInt32(EmpidTb.Text));
                    populatee();
                    reset();

                }catch(Exception Ex)

                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {



            if (EmpidTb.Text == "" || EmpNameTb.Text == "" || EmpPhoneTb.Text == "" || EmpAddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {


                    edite edd = new edite();
            edd.edd( Convert.ToInt32(EmpidTb.Text), EmpNameTb.Text, EmpAddressTb.Text, EmpPossitionTb.Text, EmpDob.Text, EmpPhoneTb.Text, EmpEducTb.Text, EmpGenderTb.SelectedItem.ToString());
                populatee();
                
                } catch (Exception Ex)
               {
                MessageBox.Show(Ex.Message);
               }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        

        private void Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-A78BTSK\SQLEXPRESS;Initial Catalog=EmployeeMyOwn;Integrated Security=True");
            if(Search.Text != "")
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                SqlDataAdapter adap = new SqlDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();
                string Command = "select * from Employeee where EmpName like '%" + Search.Text + "%';";
                Con.Open();
                adap = new SqlDataAdapter(Command, Con);
                adap.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                dataGridView1.DataSource = dv;
                Con.Close();
            }
            else if(Search.Text == "")
            {
                dataGridView1.Refresh();
            }
        }

        
    }
}
