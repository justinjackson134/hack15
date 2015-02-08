using System;
using System.Collections;
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
        ArrayList dates = new ArrayList();
        ArrayList cal_in = new ArrayList();
        ArrayList cal_burn = new ArrayList();
        ArrayList min_active = new ArrayList();

        public Form2()
        {            
            InitializeComponent();
            label1.Text = monthCalendar1.SelectionStart.ToShortDateString();
            check_for_and_init_date();
        }

        public void check_for_and_init_date()
        {
            int i = -1;
            int myInt = 1;


            i = dates.IndexOf(monthCalendar1.SelectionStart.ToShortDateString());

            if (i != -1)
            {
                // date exists in list
                textBox1.Text = (string)cal_in[i];
                textBox3.Text = (string)cal_burn[i];
                textBox2.Text = (string)min_active[i];
            }
            else
            {
                // date does not exist in list
                dates.Add(monthCalendar1.SelectionStart.ToShortDateString());
                i = dates.IndexOf(monthCalendar1.SelectionStart.ToShortDateString());

                cal_in.Add("0");
                cal_burn.Add("0");
                min_active.Add("0");
            }

            // calculate_burn
            myInt = System.Convert.ToInt32(min_active[i]);
            cal_burn[i] = ((double)myInt * .55 * /*weight*/ 1).ToString();

            label1.Text = monthCalendar1.SelectionStart.ToShortDateString();
            textBox1.Text = (string)cal_in[i];
            textBox3.Text = (string)cal_burn[i];
            textBox2.Text = (string)min_active[i];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            check_for_and_init_date(); // calcs burn

            button4_Click(monthCalendar1, null);
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
            int i = -1;

            i = dates.IndexOf(monthCalendar1.SelectionStart.ToShortDateString());

            cal_in[i] = (System.Convert.ToInt32(cal_in[i]) + System.Convert.ToInt32(textBox4.Text)).ToString();

            check_for_and_init_date();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // minutes of activity box
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // + 5 min button
            int i = 0;

            min_active[i] = (System.Convert.ToInt32(min_active[i]) + 5).ToString();

            check_for_and_init_date();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // - 5 min button
            int i = 0;

            min_active[i] = (System.Convert.ToInt32(min_active[i]) - 5).ToString();
            
            check_for_and_init_date();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f1 = new Form3(); // Instantiate a Form3 object.
            f1.Show(); // Show Form3
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Save button
            int i = 0;

            i = dates.IndexOf(monthCalendar1.SelectionStart.ToShortDateString());

            cal_in[i] = textBox1.Text;
            cal_burn[i] = textBox3.Text;
            min_active[i] = textBox2.Text;

            check_for_and_init_date();   
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // + 30 button
            int i = 0;

            min_active[i] = (System.Convert.ToInt32(min_active[i]) + 30).ToString();

            check_for_and_init_date();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int i = 0;

            min_active[i] = (System.Convert.ToInt32(min_active[i]) - 30).ToString();

            check_for_and_init_date();
        }
    }
}