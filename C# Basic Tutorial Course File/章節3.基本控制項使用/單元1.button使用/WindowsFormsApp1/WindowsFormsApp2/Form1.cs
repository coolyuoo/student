using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button4_MouseMove_1(object sender, MouseEventArgs e)
        {
            MessageBox.Show("滑動");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("點擊");
        }

        private void button3_KeyUp(object sender, KeyEventArgs e)
        {
            MessageBox.Show("放開");
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("點擊2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("點擊3");
        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {

            MessageBox.Show("666");
        }

        private void button5_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("您按下了" + e.KeyCode + "键!");
        }

        private void button7_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("666");
        }
    }
}
