using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 設定初始值、最大值和最小值
            numericUpDown2.Minimum = 30;
            numericUpDown2.Maximum = 400;
            numericUpDown2.Value = 120;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox2.Text);

            i = i + 10;

            button1.Text = i.ToString(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal n = numericUpDown1.Value;

            n = n + 10;

            button2.Text = n.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal n = numericUpDown2.Value;


            button3.Text = n.ToString();
        }

     

      
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            label5.Text = numericUpDown3.Value.ToString();
        }


        //事件 是一種行為 代表你對這個控制項做了甚麼事情
        //依照多年經驗 你只會用到click 


    }
}
