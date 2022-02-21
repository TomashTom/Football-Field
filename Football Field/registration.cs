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
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            Registration_steps regstep = new Registration_steps();
            regstep.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            name.Clear();
            surname.Clear();
        }

        private void registration_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            for_customers cus= new for_customers();
            cus.Show();
            this.Hide();

            DB db = new DB();

            String password = name.Text;
            String username = surname.Text;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("Select * FROM registration WHERE Customer_Surname = @sur and Customer_Name =@name", db.GetConnection());
            command.Parameters.Add("@sur", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = password;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            //check if the user exisc ot not

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("yes");

            }
            else
            {
                if(username.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your Surname to log in", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (password.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your Password to log in", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void registration_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            name.Clear();
            surname.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Registration_steps regstep = new Registration_steps();
            regstep.Show();
            this.Hide();
        }
    }
}
