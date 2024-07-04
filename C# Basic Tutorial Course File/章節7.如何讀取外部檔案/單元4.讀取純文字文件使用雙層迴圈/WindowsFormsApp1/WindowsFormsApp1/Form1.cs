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




        private void button4_Click_1(object sender, EventArgs e)
        {
            string xx2 = @"D:\CodeProject\線下教學\student\C# Basic Tutorial Course File\章節7.如何讀取外部檔案\temp\會員資料.txt";

            List<string> x = File.ReadAllLines(xx2).ToList();

            foreach (var line in x)
            {
                MessageBox.Show(line);
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            string xx2 = @"D:\CodeProject\線下教學\student\C# Basic Tutorial Course File\章節7.如何讀取外部檔案\temp\會員資料.txt";

            List<string> x = File.ReadAllLines(xx2).ToList();

            int i = 0;

            foreach (var line in x)
            {
                //if (i == 0)
                //{

                //}
                //else
                //{
                //    MessageBox.Show(line);
                //}

                //i = i + 1;

                if (i > 0)
                {
                    MessageBox.Show(line);
                }

                i++;
            }





        }
    }
}
