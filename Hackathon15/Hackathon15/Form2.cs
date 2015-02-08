using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label1.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label1.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            // Curr date label
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Calories Consumed Box
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Calories burned box
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // add calories box
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // add calories button
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // minutes of activity box
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // + 5 min button
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // + 30 min button
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f1 = new Form3(); // Instantiate a Form3 object.
            f1.Show(); // Show Form3
        }
    }
}
