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

        string x = "123";

        public Form1()
        {
            InitializeComponent();

            MessageBox.Show(x);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(x + "456");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(x+"a");
        }
    }
}
