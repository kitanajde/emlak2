﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emlak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "gazi" && textBox2.Text == "12345") {
                Form2 emlakkayit = new Form2();
                
                emlakkayit.Show();
                this.Hide();
                    
                    
                    }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
