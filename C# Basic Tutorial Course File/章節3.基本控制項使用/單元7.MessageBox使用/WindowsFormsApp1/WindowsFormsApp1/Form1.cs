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
            MessageBox.Show("hi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There are something wrong!", "ERROR~");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There are something wrong!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There are something wrong!", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There are something wrong!", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);

        }
    }
}
