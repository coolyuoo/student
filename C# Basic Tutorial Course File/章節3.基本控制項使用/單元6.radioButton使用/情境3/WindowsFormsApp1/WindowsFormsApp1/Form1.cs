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

        private void button1_Click(object sender, EventArgs e)
        {
            bool r = radioButton1.Checked;

            MessageBox.Show(r.ToString());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
            {
                if (radioButton1.Checked) { 
                    MessageBox.Show(radioButton1.Text);

                }
                if (radioButton2.Checked)
                {
                    MessageBox.Show(radioButton2.Text);

                }
                if (radioButton3.Checked)
                {
                    MessageBox.Show(radioButton2.Text);

                }

            }


            if (radioButton4.Checked || radioButton6.Checked )
            {
                if (radioButton4.Checked)
                {
                    MessageBox.Show(radioButton4.Text);

                }
                if (radioButton6.Checked)
                {
                    MessageBox.Show(radioButton6.Text);
                }
               

            }
        }
    }
}
