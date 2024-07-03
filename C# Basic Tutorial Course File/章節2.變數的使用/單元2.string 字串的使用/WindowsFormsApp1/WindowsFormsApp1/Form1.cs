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
            string s = "哈囉!";

            MessageBox.Show(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = "哈囉!";

            //新的容器去裝- 你做了一碗麵 想加料 放回去平底鍋 炒一炒之後放在新的盤子
            string x = s.Replace("!", "?");

            MessageBox.Show(x);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = "哈囉!";

            //覆蓋掉舊的容器- 你做了一碗麵 想加料 放回去平底鍋 炒一炒之後放回舊的盤子
            s = s.Replace("!", "?");

            MessageBox.Show(s);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s = "哈囉!";


            s = s.PadLeft(10,'-');

            MessageBox.Show(s);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string s = "aaabbb!";


            s = s.ToUpper();

            MessageBox.Show(s);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string s = "BBBWWWEEE!";


            s = s.ToLower();

            MessageBox.Show(s);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string s = "哈囉!";
            string b = "你好嗎!";


            MessageBox.Show(s + b);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string s = "哈囉!";
            string b = "你好嗎!";
            string y = s + b;

            MessageBox.Show(y);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string s = "哈囉!";
            s = s + "妳好!";
            s = s + "嗎!";

            MessageBox.Show(s);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string s = "哈囉!"+"\r\n";
            s = s + "妳好!" + "\r\n";
            s = s + "嗎!";

            MessageBox.Show(s);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //路徑

            string s = "C:\\YOUR\\JOB";

            MessageBox.Show(s);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string s = @"C:\YOUR\JOB";

            MessageBox.Show(s);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //打一個 會錯
            string s = "C:\YOUR\JOB";

            MessageBox.Show(s);
        }
    }
}
