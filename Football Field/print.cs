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
    public class print

    {
        public int CustId { get; set; }
        public string CusName { get; set; }
        public string CusPH { get; set; }
        public string OrdDate { get; set; }
        public string SeatPla { get; set; }
        public string TeamName { get; set; }
        public string TeamName2 { get; set; }
        public int Qty { get; set; }
        public int total { get; set; }
        public int Taxes { get; set; }
        public double Prices { get; set; }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-A78BTSK\SQLEXPRESS;Initial Catalog=EmployeeMyOwn;Integrated Security=True");
        public void  printed(string text, System.Drawing.Printing.PrintPageEventArgs e)
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


    }
       
}
