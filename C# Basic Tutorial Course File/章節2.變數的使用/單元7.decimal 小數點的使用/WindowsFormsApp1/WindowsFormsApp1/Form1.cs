using System;
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
            decimal i = 122.6M;

            //MessageBox.Show(i);
            MessageBox.Show(i.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal i = 122.6m;
            decimal b = 122.6M;
            decimal x = i + b;

            MessageBox.Show(x.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal i = Convert.ToDecimal("122.65");

            MessageBox.Show(i.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal i = Convert.ToDecimal("122a");

            //會失敗
            MessageBox.Show(i.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            decimal i = -100.8M;

            MessageBox.Show(i.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //除了金錢以外的 就用double
            double i = 0.333;

            MessageBox.Show("double:"+i.ToString());

            //金錢的用這個
            decimal d = 0.333M;

            MessageBox.Show("decimal:" + d.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            decimal i = 122.6m;
            double b = 12.6;
            int x = 50;

            decimal y = i + Convert.ToDecimal(b) + x;

            MessageBox.Show(y.ToString());
        }
    }
}
