using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //label2.Text = checkBox2.Checked.ToString();

            MessageBox.Show("456");
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("123");
        }
    }
}
