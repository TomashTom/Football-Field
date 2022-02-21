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
    public partial class Splash : Form
    {
        
        public Splash()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Splasch_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            myprogress.Value = startpoint;

            if(myprogress.Value == 100)
            {
                myprogress.Value = 0;
                timer1.Stop();
                this.Hide();
                Login log = new Login();
                log.Show();

            }
        }

        private void myprogress_Click(object sender, EventArgs e)
        {

        }
    }
}
