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
    public partial class Match : Form
    {
        public Match()
        {
            InitializeComponent();
            
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-A78BTSK\SQLEXPRESS;Initial Catalog=EmployeeMyOwn;Integrated Security=True");

        private void Match_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            populate();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(TeamName1.Text == "" || PlayDate.Text == "" || PlayArea.Text == "")
            {
                MessageBox.Show("Missing Information");
            }else
            {
                try
                {
                    Con.Open();
                    string query = "Insert into Match_TME values('" + TeamName1.SelectedItem.ToString() + "','" + PlayArea.SelectedItem.ToString() + "','" + PlayDate.Value.Date +"')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    populate();
                    reset();
                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populate()
        {
            string query = "Select * from Match_TME";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            datagrip.DataSource = ds.Tables[0];
            
            Con.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IdTeam1.Text == "" || Team2Id.Text == "" || TeamName1.Text == "" || TeamName2.Text =="" || PlayDate.Text =="" || PlayArea.Text =="" || VS.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into Match_TME values ('" + IdTeam1.Text.ToString() + "','" + TeamName1.SelectedItem.ToString() + "','" + PlayDate.Value.Date + "','" +VS.SelectedItem.ToString() + "','"+PlayArea.SelectedItem.ToString() +"','"+Team2Id.Text.ToString()+ "','"+TeamName2.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdTeam1.Text = datagrip.SelectedRows[0].Cells[0].Value.ToString();
            TeamName1.SelectedItem = datagrip.SelectedRows[0].Cells[1].Value.ToString();
            PlayDate.Text = datagrip.SelectedRows[0].Cells[2].Value.ToString();
            VS.SelectedItem = datagrip.SelectedRows[0].Cells[3].Value.ToString();
            PlayArea.SelectedItem = datagrip.SelectedRows[0].Cells[4].Value.ToString();
            Team2Id.Text = datagrip.SelectedRows[0].Cells[5].Value.ToString();
            TeamName2.SelectedItem = datagrip.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void reset()
        {
            IdTeam1.Text = "";
            TeamName1.Text = "";
            Team2Id.Text = "";
            TeamName2.Text = "";
            PlayArea.SelectedIndex = 0;
            PlayDate.Text = "";
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if(IdTeam1.Text == "")
            {
                MessageBox.Show("Enter  Team ID");
            }
            else
            {
                Con.Open();
                String query = "Delete from Match_TME where IdTeam1='" + IdTeam1.Text + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Team Delete Successfully");
                Con.Close();
                populate();
                reset();
                

            }
        }

        private void Search1_KeyPress(object sender, KeyPressEventArgs e)
        {

            SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-A78BTSK\SQLEXPRESS;Initial Catalog=EmployeeMyOwn;Integrated Security=True");
            if (Search1.Text != "")
            {
                datagrip.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                SqlDataAdapter adap = new SqlDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();
                string Command = "select * from Match_TME where TeamName like '%" + Search1.Text + "%';";
                Con.Open();
                adap = new SqlDataAdapter(Command, Con);
                adap.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                datagrip.DataSource = dv;
                Con.Close();
            }
            else if (Search1.Text == "")
            {
                datagrip.Refresh();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Search1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
