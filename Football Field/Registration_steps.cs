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
    public partial class Registration_steps : Form
    {
        public Registration_steps()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            registration reg = new registration();
            reg.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User_reg userreg = new User_reg();
            userreg.Show();
            this.Hide();

        }
    }
}
