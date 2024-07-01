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
            button1.Text = textBox2.Text; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var x = textBox1.Lines;

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

        private void textBox7_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox7.Copy();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HI");

        }


        //事件 是一種行為 代表你對這個控制項做了甚麼事情
        //依照多年經驗 你只會用到click 


    }
}
