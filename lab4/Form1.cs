﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usr = "admin";
            string psr = "Password";
            if (textBox1.Text == usr && textBox2.Text == psr)
            {
                Form2 form2 = new Form2(usr);
                this.Visible = false;
                form2.Show();
            }
                
                
            else
                MessageBox.Show("Error Login");
        }
    }
}
