﻿using System;
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
    public partial class Splasch : Form
    {
        public Splasch()
        {
            InitializeComponent();
        }

        private void Splasch_Load(object sender, EventArgs e)
        {

            timer1.Start();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            progressBar1.Value = startpoint;
            if(progressBar1.Value ==100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                this.Hide();
                Registration_steps reg = new Registration_steps();
                reg.Show();
            }
        }
    }
}