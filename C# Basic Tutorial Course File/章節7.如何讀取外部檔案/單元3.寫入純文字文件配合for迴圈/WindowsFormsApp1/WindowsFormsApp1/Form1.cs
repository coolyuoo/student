using System;
using System.Collections.Generic;
using System.IO;
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
            string x = "";

            for (int i = 0; i < 5; i++)
            {
                x += i.ToString();
            }


            File.WriteAllText("D:\\CodeProject\\線下教學\\C# Basic Tutorial Course File\\章節7.如何讀取外部檔案\\temp\\文具2.txt", x);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> x = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                x.Add(i.ToString());
            }


            string x2 = "";

            foreach (var item in x)
            {
                x2 += item;
            }


            File.WriteAllText("D:\\CodeProject\\線下教學\\C# Basic Tutorial Course File\\章節7.如何讀取外部檔案\\temp\\文具2.txt", x2);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> x = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                x.Add(i.ToString());
            }

            //陣列轉字串的語法
            string y = string.Join("", x);


            File.WriteAllText("D:\\CodeProject\\線下教學\\C# Basic Tutorial Course File\\章節7.如何讀取外部檔案\\temp\\文具2.txt", y);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> x = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                x.Add(i.ToString());
            }

            //陣列轉字串的語法
            string y = string.Join("\n", x);


            File.WriteAllText("D:\\CodeProject\\線下教學\\C# Basic Tutorial Course File\\章節7.如何讀取外部檔案\\temp\\文具2.txt", y);

        }
    }
}
