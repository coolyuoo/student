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

   

        private void button4_Click(object sender, EventArgs e)
        {
            string x = "";

            for (int i = 0; i < 8; i++)
            {

                if (i % 2 == 0)//偶數
                {
                    x = x + i.ToString() + "\r\n";
                }


            }

            textBox1.Text = x;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string x = "";
            string y = "";

            for (int i = 0; i < 8; i++)
            {
                if (i % 2 == 0)//偶數
                {
                    x = x + i.ToString() + "\r\n";
                }
                else
                {
                    y = y + i.ToString() + "\r\n";
                }
            }

            textBox1.Text = x + y;
        }

  
    }
}
