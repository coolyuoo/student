using System;
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
            string x = dateTimePicker1.Text;

            MessageBox.Show(x);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Short;
         
        }






    }
}
