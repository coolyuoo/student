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
            //這是每行有幾個星星的容器
            int n =Convert.ToInt32(textBox1.Text);
            char x =Convert.ToChar(textBox2.Text);

            string t = textBox4.Text;

            int dataCount = t.Count();

            string y = "";

            for (int i = 0; i < n- dataCount; i++)
            {
                y = x + y;
            }

            textBox3.Text = y+ t;  
        }

        //加入判斷
        private void button2_Click(object sender, EventArgs e)
        {
            //這是每行有幾個星星的容器
            int n = Convert.ToInt32(textBox1.Text);
            char x = Convert.ToChar(textBox2.Text);


            string r= textBox4.Text.PadLeft(n, x);

            textBox3.Text = r;
        }
    }
}
