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

            //for (初始設定; 條件; 每次迴圈結束後的執行動作)
            //{
            //    // 迴圈內執行的程式碼
            //}

            //從db取資料
            //塞資料到db

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                MessageBox.Show(i.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string x = "1" + "\r\n";

            string x2 = "2" + "\r\n";
            string x3 = "3" + "\r\n";
            string x4 = "4" + "\r\n";
            string x5 = "5";




            textBox1.Text = x + x2 + x3 + x4 + x5;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string x = "";

            for (int i = 0; i < 8; i++)
            {
                x = x + i.ToString() + "\r\n";
            }

            textBox1.Text = x;
        }

      

    

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i = i + 1)
            {
                MessageBox.Show(i.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i = i + 2)
            {
                MessageBox.Show(i.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10;)
            {
                MessageBox.Show(i.ToString());

                i = i + 2;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i = i * 2)
            {
                MessageBox.Show(i.ToString());
            }
        }
    }
}
