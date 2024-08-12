using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            textBox1.ScrollBars = ScrollBars.Vertical;

            string x = "";

            for (int i = 10; i > 0; i--)
            {
                string v = "".PadRight(i, '*') + "\r\n";

                x += v;
            }

            



            textBox2.Text = x;


        }

        private void button1_Click(object sender, EventArgs e)
        {


        }


    }
}
