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
            string x = "aaa";
            int y = 123;
            double d = 12.5;

            //當輸出結果有字串 任何數值都會被認定為字串
            MessageBox.Show(x + y + d);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int y = 123;
            double d = 12.5;

            MessageBox.Show((y + d).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int y = 123;
            int d = 12;

            MessageBox.Show((y - d).ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int y = 123;
            int d = 12;

            MessageBox.Show((y * d).ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int y = 123;
            int d = 12;

            MessageBox.Show((y / d).ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int y = 123;
            int d = 12;

            MessageBox.Show((y % d).ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool b = 1 == 2;

            //= --> 指定值
            //== --> 人類社會上的等於


            MessageBox.Show(b.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bool b = 1 == 1;

            //= --> 指定值
            //== --> 人類社會上的等於


            MessageBox.Show(b.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bool b = 1 != 2;

            //= --> 指定值
            //== --> 人類社會上的等於
            //!= --> 人類社會上的不等於

            MessageBox.Show(b.ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bool b = 1 != 1;

            //= --> 指定值
            //== --> 人類社會上的等於
            //!= --> 人類社會上的不等於

            MessageBox.Show(b.ToString());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int y = 10;

            y = y + 1;

            MessageBox.Show(y.ToString());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int y = 10;

            y += 1;

            MessageBox.Show(y.ToString());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int y = 10;

            y++;

            MessageBox.Show(y.ToString());
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int y = 10;

            y = y - 1;

            MessageBox.Show(y.ToString());

        }

        private void button14_Click(object sender, EventArgs e)
        {
            int y = 10;

            y -= 1;

            MessageBox.Show(y.ToString());

        }

        private void button15_Click(object sender, EventArgs e)
        {
            int y = 10;

            y--;

            MessageBox.Show(y.ToString());

        }

        private void button17_Click(object sender, EventArgs e)
        {
            int i = 10;
            int x = 20;

            bool b = i < x;


            MessageBox.Show(b.ToString());
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int i = 10;
            int x = 20;

            bool b = i > x;


            MessageBox.Show(b.ToString());
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int i = 10;
            int x = 20;

            bool b = i <= x;


            MessageBox.Show(b.ToString());
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int i = 20;
            int x = 20;

            bool b = i >= x;


            MessageBox.Show(b.ToString());
        }

        private void button21_Click(object sender, EventArgs e)
        {

        }
    }
}
