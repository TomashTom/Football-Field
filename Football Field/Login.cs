using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_Field
{
    public partial class Login : Form
    {
        public static Login instance;
        

        public Login()
        {
            InitializeComponent();
            instance = this;
            
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            if(userid.Text == "" || userpass.Text == "")
            {
                MessageBox.Show("Enter User Name or Ures Password");
            }
            else if(userid.Text == "Admin" && userpass.Text == "Admin123")
            {
                this.Hide();
                Home home = new Home();
                home.Show();

            }
            else
            {
                MessageBox.Show("Wrong user name or password");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userid.Clear();
            userpass.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Registration_steps step = new Registration_steps();
            step.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
