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


        private void button1_Click(object sender, EventArgs e)
        {
            File.Create("D:\\CodeProject\\線下教學\\C# Basic Tutorial Course File\\章節7.如何讀取外部檔案\\temp\\文具.txt");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText("D:\\CodeProject\\線下教學\\C# Basic Tutorial Course File\\章節7.如何讀取外部檔案\\temp\\文具2.txt", textBox1.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.WriteAllText("D:\\CodeProject\\線下教學\\C# Basic Tutorial Course File\\章節7.如何讀取外部檔案\\temp\\文具2.txt", textBox1.Text);
        }



        private void button4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
