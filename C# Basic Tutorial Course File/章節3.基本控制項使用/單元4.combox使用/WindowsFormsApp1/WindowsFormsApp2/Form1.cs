using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox6.Text = "請選擇:";
        }

        private void comboBox6_TextChanged(object sender, EventArgs e)
        {
            label6.Text = comboBox6.Text;
        }

     
    }
}
