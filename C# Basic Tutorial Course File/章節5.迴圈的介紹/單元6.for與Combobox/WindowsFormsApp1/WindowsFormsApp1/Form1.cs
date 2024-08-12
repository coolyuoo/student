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

      

        private void button2_Click(object sender, EventArgs e)
        {
            

            for (int i = 1; i <= 12; i++)
            {
                //算月
                int month = i;

                if (month <= DateTime.Now.Month)
                {
                    //算日
                    int d = DateTime.DaysInMonth(2024, month);

                    string dd = $"{i}月  天數{d}" + "\r\n";


                    comboBox1.Items.Add(dd);

                }
                else
                {
                    break;
                    //直接跳出這個迴圈
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            


        }
    }
}
