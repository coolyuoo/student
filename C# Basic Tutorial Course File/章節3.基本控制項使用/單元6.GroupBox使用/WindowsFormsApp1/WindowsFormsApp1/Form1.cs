using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            comboBox1.Items.Add("groupBox1");
            comboBox1.Items.Add("groupBox2");
            comboBox1.Items.Add("groupBox3");



        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

            bool b = comboBox1.Text == "groupBox1";

            if (b) {
                groupBox1.Visible = false;
            } 
        }


        //事件 是一種行為 代表你對這個控制項做了甚麼事情
        //依照多年經驗 你只會用到click 


    }
}
