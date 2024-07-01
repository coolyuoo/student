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
            bool b = checkBox1.Checked;

            label1.Text = b.ToString();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            bool b = checkBox2.Checked;

            label2.Text = b.ToString();
        }
    }
}
