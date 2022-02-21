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
    public partial class displayusers : Form
    {
        public displayusers()
        {
            InitializeComponent();
            display();
        }
       


        private void display()
        {

            display u = new display();
            List<display> c1 = u.get_users();
            datagrip.DataSource = c1;
            
        }

        private void displayusers_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void datagrip_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
