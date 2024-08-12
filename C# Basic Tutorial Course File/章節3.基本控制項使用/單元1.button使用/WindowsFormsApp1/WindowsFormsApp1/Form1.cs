using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            toolTip1.SetToolTip(button3, "This is a label.");
        }

        //button 的name


        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "OK";
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            TestButton.BackColor = SystemColors.Control;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Red;
        }

    
        private void button5_Click(object sender, EventArgs e)
        {
            button1.Text = "哈囉" + "\r\n" + "你好嗎";
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //情境
            //基本資料沒填完 詳細閱讀使用者權益


            button6.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button12.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button12.Visible = false;
        }

     
    }
}
