﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //create

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Validate credentials
            
            // if valid, open main program window
            Form2 f1 = new Form2(); // Instantiate a Form3 object.
            f1.Show(); // Show Form3 and
            //this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] login = {(textBox1.Text), (textBox2.Text)};
            System.IO.File.WriteAllLines(@"C:\Users\Public\WriteLines.txt", login);
            button2_Click(button1, null);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
