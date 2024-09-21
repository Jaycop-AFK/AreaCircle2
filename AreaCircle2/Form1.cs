using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaCircle2
{
    public partial class Form1 : Form
    {
        double radius;
        double circum;
        double area;
        double pi = 3.14;
        public Form1()
        {
            InitializeComponent();
        }

        private void bArea_Click(object sender, EventArgs e)
        {
            radius = double.Parse(tRadius.Text);
            area = pi * Math.Pow(radius, 2);
            laArea.Text = area.ToString();
        }

        private void bCircum_Click(object sender, EventArgs e)
        {
            radius = double.Parse(tRadius.Text);
            circum = 2 * pi * radius;
            laCircum.Text = circum.ToString();
        }
    }
}
