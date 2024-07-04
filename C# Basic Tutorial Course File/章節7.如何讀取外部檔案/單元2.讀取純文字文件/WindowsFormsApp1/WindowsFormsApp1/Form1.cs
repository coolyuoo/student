using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string xx = "D:\\CodeProject\\線下教學\\C# Basic Tutorial Course File\\章節7.如何讀取外部檔案\\temp\\水果商品.txt";

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> x = File.ReadAllLines(xx).ToList();

            foreach (var line in x)
            {
                MessageBox.Show(line);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string x = File.ReadAllText(xx);
            
            MessageBox.Show(x);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool b = File.Exists(xx);

            if (b)
            {
                MessageBox.Show("有該檔案");
            }
            else
            {
                MessageBox.Show("無檔案");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string fileName = Path.GetFileName(xx);

            MessageBox.Show(fileName);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string fileName = Path.GetExtension(xx);

            MessageBox.Show(fileName);
        }
    }
}
