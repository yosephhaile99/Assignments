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

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            
            if (username == "admin" && password == "password")
            {
                Form2 form = new Form2(username);
                MessageBox.Show("valid login");
                form.Show();
                this.Hide();
                //newpage

            }
            else 
              MessageBox.Show("incorrect");
        }
    }
}
