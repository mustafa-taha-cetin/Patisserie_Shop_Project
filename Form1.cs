using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastane_Uygulaması
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int çlpAdet, çkpAdet, frpAdet, mpAdet, lmpAdet, tutar;
            çlpAdet = Convert.ToInt32(textBox1.Text);
            çkpAdet = Convert.ToInt32(textBox2.Text);
            frpAdet = Convert.ToInt32(textBox3.Text);
            mpAdet = Convert.ToInt32(textBox4.Text);
            lmpAdet = Convert.ToInt32(textBox5.Text);
            tutar = çlpAdet * 24 + çkpAdet * 38 + frpAdet * 48 + mpAdet * 16 + lmpAdet * 44;
            label8.Text = "Tutar: " + tutar;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            label8.Text = "Tutar: 0";
        }
    }
}
