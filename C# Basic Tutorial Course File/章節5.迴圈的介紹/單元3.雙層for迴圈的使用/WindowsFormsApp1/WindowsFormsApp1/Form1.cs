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
            string n = "";

            //2.再印出五個*
            for (int j = 0; j < 5; j++)
            {
                string y = "*";

                n = n + y;
            }

            textBox1.Text = n;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string x = "";//這是裝*的容器

            for (int i = 0; i < 8; i++)
            {
                string n = "*" + "\r\n";

                x = x + n;
            }

            textBox1.Text = x;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string x = "";//這是裝*的容器

            for (int i = 0; i < 8; i++)
            {
                string n = "*****";

                x = x + n + "\r\n";
            }

            textBox1.Text = x;
        }

        //這邊搞懂 你迴圈就會80%了
        private void button4_Click(object sender, EventArgs e)
        {


            string x = "";//這是裝行數的容器

            //2.先印出八行
            for (int i = 0; i < 8; i++)
            {
                //這是每行有幾個星星的容器
                string n = "";

                //1.再印出五個* 
                for (int j = 0; j < 5; j++)
                {
                    string y = "*";

                    n = n + y;
                }



                x = x + n + "\r\n";
            }

            textBox1.Text = x;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string x = "";//這是裝行數的容器

            //1.先印出八行
            for (int i = 0; i < 8; i++)
            {
                //這是每行有幾個星星的容器
                string n = "";

                //2.再印出五個*
                for (int j = 0; j < 8; j++)
                {

                    string y = "*";

                    n = n + y;

                    if (i == j)
                    {
                        break;
                    }
                }



                x = x + n + "\r\n";
            }

            textBox1.Text = x;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string x = "";//這是裝行數的容器

            //1.先印出八行
            for (int i = 0; i < 8; i++)
            {
                //這是每行有幾個星星的容器
                string n = "";

                //2.再印出五個*
                for (int j = 0; j < 8; j++)
                {

                    string y = "*";

                    n = n + y;

                    if (i == j)
                    {
                        break;
                    }
                }



                x = x + n + "\r\n";
            }

            textBox1.Text = x;

        }
    }
}
