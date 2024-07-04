using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        string directoryPath = @"D:\CodeProject\線下教學\student\C# Basic Tutorial Course File\章節7.如何讀取外部檔案\temp\百貨資料";

        private void button1_Click(object sender, EventArgs e)
        {

            if (!Directory.Exists(directoryPath))
            {
                MessageBox.Show("資料夾不存在");
            }
            else
            {
                MessageBox.Show("資料夾存在");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(directoryPath))
            {
                // 获取目录中的所有文件
                List<string> files = Directory.GetFiles(directoryPath).ToList();


                string x = "";

                foreach (string item in files)
                {
                    x += item + "\r\n";
                }


                textBox1.Text = x;

            }
            else
            {
                MessageBox.Show("資料夾不存在");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(directoryPath))
            {
                // 获取目录中的所有文件
                List<string> files = Directory.GetFiles(directoryPath).ToList();


                string x = "";

                foreach (string item in files)
                {
                    x += item + "\r\n";
                }


                textBox1.Text = x;

            }
            else
            {
                MessageBox.Show("資料夾不存在");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
