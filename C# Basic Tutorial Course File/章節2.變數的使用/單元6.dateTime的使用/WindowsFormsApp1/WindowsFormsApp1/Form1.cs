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
            DateTime i = DateTime.Now;

            MessageBox.Show(i.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime i = Convert.ToDateTime("2024/10/31");

            MessageBox.Show(i.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime i = Convert.ToDateTime("2024/10/32");

            MessageBox.Show(i.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime i = new DateTime(2024, 10, 31);

            MessageBox.Show(i.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime i = new DateTime(2024, 10, 31, 13, 59, 03);

            MessageBox.Show(i.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DateTime i = DateTime.Now;

            //新的值 沒有被賦予
            i.AddDays(1);

            MessageBox.Show(i.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DateTime i = DateTime.Now.AddDays(1);


            MessageBox.Show(i.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DateTime i = DateTime.Now;

            i = i.AddDays(1);

            MessageBox.Show(i.ToString());
        }
    }
}
