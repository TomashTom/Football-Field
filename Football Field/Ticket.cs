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
    public partial class Ticket : Form
    {
        

        public Ticket()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-A78BTSK\SQLEXPRESS;Initial Catalog=EmployeeMyOwn;Integrated Security=True");
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       
        

        private void button2_Click(object sender, EventArgs e)
        {
           

            if (CustId.Text == "" || CusName.Text == "" || CusPH.Text == "" || OrdDate.Text == "" || SeatPla.Text == "" ||  TeamName.Text =="" ||TeamName2.Text== "" || Qty.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {

                    Con.Open();
                    string query = "insert into Ticket values('" + CustId.Text + "','" + CusName.Text + "','" + CusPH.Text + "','" + OrdDate.Value.Date + "','" + SeatPla.Text + "','" + TeamName.SelectedItem.ToString() + "','"  + Qty.Text + "','" + TeamName2.SelectedItem.ToString() +  "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" successfully added");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

            

            }

        private void button5_Click(object sender, EventArgs e)
        {
            

        }

        private void Details_TextChanged(object sender, EventArgs e)
        {

        }
        double total;
        double Taxes;
        double Prices;
        int qty;
        double TicketPrice;
        private void button6_Click(object sender, EventArgs e)
        {
             if (CustId.Text == "" || CusName.Text == "" || CusPH.Text == "" || OrdDate.Text == "" || SeatPla.Text == "" || TeamName2.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            if (TeamName.Text == "" || TeamName2.Text == "")
            {
                MessageBox.Show("Select an Teams Name");
            }

            if (TeamName.Text == " Manchester City" )
            {
                Prices = 250;
                Taxes = 1.3;

            }
            else if (TeamName.Text == "Manchester United")
            {
                Prices = 320;
                Taxes = 1.6;
            }
            else if (TeamName.Text == "Liverpool FC")
            {
                Prices = 170;
                Taxes = 1.2;

            }
            else if(TeamName.Text == "Lids United")
            {
                Prices = 280;
                Taxes = 1.1;

            }
            else if (TeamName.Text == "Bayern MünchenGermany")
            {
                Prices = 295;
                Taxes = 1.6;
            }
            else if (TeamName.Text == "Barcelona")
            {
                Prices = 450;
                Taxes = 1.7;
            }
            else if( TeamName.Text == "Real Madrid")
            {
                Prices = 435;
                Taxes = 1.5;
            }
            else if ( TeamName.Text == "Chelsea")
            {
                Prices = 410;
                Taxes = 1.1;
            }
            else if (TeamName.Text == "Arsenal")
            {
                Prices = 298;
                Taxes = 1.3;
            }
            else if ( TeamName.Text == "PSG")
            {
                Prices = 360;
                Taxes = 1.3;
            }
            if (TeamName2.Text == " Manchester City")
            {
                Prices = 250;
                Taxes = 1.3;

            }
            else if (TeamName2.Text == "Manchester United")
            {
                Prices = 320;
                Taxes = 1.6;
            }
            else if (TeamName2.Text == "Liverpool FC")
            {
                Prices = 170;
                Taxes = 1.2;

            }
            else if (TeamName2.Text == "Lids United")
            {
                Prices = 280;
                Taxes = 1.1;

            }
            else if (TeamName2.Text == "Bayern MünchenGermany")
            {
                Prices = 295;
                Taxes = 1.6;
            }
            else if (TeamName2.Text == "Barcelona")
            {
                Prices = 450;
                Taxes = 1.7;
            }
            else if (TeamName2.Text == "Real Madrid")
            {
                Prices = 435;
                Taxes = 1.5;
            }
            else if (TeamName2.Text == "Chelsea")
            {
                Prices = 410;
                Taxes = 1.1;
            }
            else if (TeamName2.Text == "Arsenal")
            {
                Prices = 298;
                Taxes = 1.3;
            }
            else if (TeamName2.Text == "PSG")
            {
                Prices = 360;
                Taxes = 1.3;
            }
            //TicketPrice = Convert.ToInt32(TeamName.Text) +  Convert.ToInt32(TeamName2.Text);
            //total = Convert.ToInt32(TicketPrice) * Convert.ToInt32(Qty.Text) * Taxes;
            total = Prices * Convert.ToInt32(Qty.Text) * Taxes;
            Details.Text = "Customers ID: " + CustId.Text + "\n" + "Custumers Name: " + CusName.Text + " \n" + "Custumers Phone: " + CusPH.Text + "\n" + "Custumers Seat Place: " + SeatPla.Text + "\n" + "Team Name: " + TeamName.Text + "\n" + "TeamName: " +TeamName2.Text + "\n" + "Ticket Qty: " + Qty.Text + "\n" + "Order Date: " + OrdDate.Value.Date +"\n" + "Ticket Price:  " + Prices +"$" + "\n" + "Ticket Tax: " + Taxes+"%" + "\n" + "Total Cost: " +"$"+ total; 
        }
        private void populate()
        {
            Con.Open();
            string query = "Select * from Ticket";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            grid.DataSource = ds.Tables[0];

            Con.Close();
            //reset();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CustId.Text = "";
            CusName.Text = "";
            CusPH.Text = "";
            TeamName.Text = "";
            SeatPla.Text = "";
            Qty.Text = "0";
            TeamName2.Text = "";
            
            
        }

        private void control_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            populate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* CustId.Text = grid.SelectedRows[0].Cells[0].Value.ToString();
            CusName.Text = grid.SelectedRows[0].Cells[1].Value.ToString();
            CusPH.Text = grid.SelectedRows[0].Cells[2].Value.ToString();
            OrdDate.Text = grid.SelectedRows[0].Cells[3].Value.ToString();
            SeatPla.Text = grid.SelectedRows[0].Cells[4].Value.ToString();
            TeamName.SelectedItem = grid.SelectedRows[0].Cells[5].Value.ToString();
            Qty.Text = grid.SelectedRows[0].Cells[6].Value.ToString();*/
            
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustId.Text = grid.SelectedRows[0].Cells[0].Value.ToString();
            CusName.Text = grid.SelectedRows[0].Cells[1].Value.ToString();
            CusPH.Text = grid.SelectedRows[0].Cells[2].Value.ToString();
            OrdDate.Text = grid.SelectedRows[0].Cells[3].Value.ToString();
            SeatPla.Text = grid.SelectedRows[0].Cells[4].Value.ToString();
            TeamName.SelectedItem = grid.SelectedRows[0].Cells[5].Value.ToString();
            Qty.Text = grid.SelectedRows[0].Cells[6].Value.ToString();
            TeamName2.SelectedItem = grid.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CustId.Text == "")
            {
                MessageBox.Show("Enter Customers Id");


            }
            else
            {
                try
                {
                    Con.Open();
                    String query = "Delete from Ticket where Customer_Id='" + CustId.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Delete Successfully");
                    Con.Close();
                    populate();
                    //reset();

                }
                catch (Exception Ex)

                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void printPreviewDialog1_Load(object sender, System.Drawing.Printing.PrintPageEventArgs e )
        {
            
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (print.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void print_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("=====Customers Ticket Details=====", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(180));
            e.Graphics.DrawString("Customer ID: " + CustId, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Red, new Point(10, 100));
            e.Graphics.DrawString("Customer Name: " + CusName + "\t Customers Phone" + CusPH, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Red, new Point(10, 140));
            e.Graphics.DrawString("Customers Order Date: " + OrdDate, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Red, new Point(10, 180));
            e.Graphics.DrawString("Customer Seat Place: " + SeatPla, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Red, new Point(10, 220));
            e.Graphics.DrawString("Team Name: " + TeamName, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Red, new Point(10, 260));
            e.Graphics.DrawString("Team Name: " + TeamName2, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Red, new Point(10, 300));
            e.Graphics.DrawString("Ticket Qty: " + Qty, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Red, new Point(10, 340));
            e.Graphics.DrawString("Order Date: " + OrdDate, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Red, new Point(10, 380));
            e.Graphics.DrawString("Ticket Price: " + Prices, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Red, new Point(15, 420));
            e.Graphics.DrawString("Ticket Tax: " + Taxes, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Red, new Point(18, 460));
            e.Graphics.DrawString("Total Cost: " + total, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Red, new Point(20, 500));
            
        }

        

        

        private void abc_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-A78BTSK\SQLEXPRESS;Initial Catalog=EmployeeMyOwn;Integrated Security=True");
            if (abc.Text != "")
            {
                grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                SqlDataAdapter adap = new SqlDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();
                string command = "Select * From Ticket Where Customer_Id like '%" + abc.Text + "%';";
                Con.Open();
                adap = new SqlDataAdapter(command, Con);
                adap.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                grid.DataSource = dv;
                Con.Close();
            }
            else if (abc.Text == "")
            {
                grid.Refresh();
            }
        }

        private void Ticket_Load(object sender, EventArgs e)
        {

        }
    }
    }

