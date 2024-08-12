using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox4.MaxLength = 5;
            textBox3.PasswordChar = '*';
            textBox10.ForeColor = Color.Red;
            textBox12.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = textBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = textBox3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = textBox4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = textBox5.Text;
        }

        //每個控制項按.會有一百多個可以用的東西
        //放心 寫了十年 用不到五個
        private void button6_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox7.Copy();
        }



        private void button8_Click(object sender, EventArgs e)
        {
            string x = textBox9.Text;

            int c = x.Length;

            button8.Text = c.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            string c = textBox8.Text.Substring(1, 5);

            button9.Text = c.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            button10.Text = textBox10.Text;


        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox11.BackColor = Color.Plum;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox12.Enabled = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string x = textBox13.Text;

            int c = Convert.ToInt32(x);

            string x2 = Convert.ToString(c, 16);

            button13.Text = x2;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Text = Convert.ToString(Convert.ToInt32(textBox14.Text), 2); 
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var ff = "x".PadLeft(10, '0');

            var ffx = ff.PadRight(5, '1');

            int c = ffx.Count();

            MessageBox.Show(ffx);
        }


        //事件 是一種行為 代表你對這個控制項做了甚麼事情
        //依照多年經驗 你只會用到click 


    }
}
