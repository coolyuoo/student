using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double i = 122.6;

            //MessageBox.Show(i);
            MessageBox.Show(i.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double i = 12.99250;
            double b = 12.9;
            double x = i + b;

            MessageBox.Show(x.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double i = Convert.ToDouble("122.65");

            MessageBox.Show(i.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double i = Convert.ToDouble("122a");

            //會失敗
            MessageBox.Show(i.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double i = -100.8;

            MessageBox.Show(i.ToString());
        }

      
    }
}
