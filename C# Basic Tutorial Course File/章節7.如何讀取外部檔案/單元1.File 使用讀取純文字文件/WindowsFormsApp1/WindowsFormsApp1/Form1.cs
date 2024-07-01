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

        string xx = "D:\\CodeProject\\線下教學\\C# Basic Tutorial Course File\\章節7.如何讀取外部檔案\\temp\\水果商品.txt";

        private void button1_Click(object sender, EventArgs e)
        {
            var x = File.ReadAllLines(xx);

            foreach (var line in x)
            {
                MessageBox.Show(line);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var x = File.ReadAllText(xx);
            
            MessageBox.Show(x);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists(xx))
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

        }
    }
}
