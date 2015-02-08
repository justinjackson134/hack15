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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.chart1.Series["WEIGHT"].Points.AddXY(1, 250);
            this.chart1.Series["WEIGHT"].Points.AddXY(2, 245);
            this.chart1.Series["WEIGHT"].Points.AddXY(3, 242);
            this.chart1.Series["WEIGHT"].Points.AddXY(4, 234);
            this.chart1.Series["WEIGHT"].Points.AddXY(5, 235);
        }
    }
}
