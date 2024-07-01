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

        //button 的name


        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text="OK";
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            TestButton.BackColor = SystemColors.Control;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Red;
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("456");
        }
    }
}
