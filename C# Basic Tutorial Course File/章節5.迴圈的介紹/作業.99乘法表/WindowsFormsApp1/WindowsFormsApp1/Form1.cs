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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n = "";

            for (int j = 1; j <= 9; j++)
            {
                string y = 2.ToString() + " * " + j.ToString() + " = " + (2 * j);

                n = n + y + "\r\n";
            }

            textBox1.Text = n;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string n2 = "";

            for (int j = 1; j <= 9; j++)
            {
                string y = 2.ToString() + " * " + j.ToString() + " = " + (2 * j);

                n2 = n2 + y + "\r\n";
            }

            //---------------------------------------------

            string n3 = "" + "\r\n";

            for (int j = 1; j <= 9; j++)
            {
                string y = 3.ToString() + " * " + j.ToString() + " = " + (3 * j);

                n3 = n3 + y + "\r\n";
            }

            //---------------------------------------------

            textBox1.Text = n2+ n3;
        }
    }
}
