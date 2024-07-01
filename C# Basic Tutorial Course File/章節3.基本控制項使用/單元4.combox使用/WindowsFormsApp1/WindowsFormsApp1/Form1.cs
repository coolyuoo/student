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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //ctrl+D 快速複製

            comboBox3.Items.Add("香蕉");
            comboBox3.Items.Add("蘋果");
            comboBox3.Items.Add("哈密瓜");
            comboBox3.Items.Add("櫻桃");


        }

        private void button1_Click(object sender, EventArgs e)
        {


            label1.Text = comboBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox4.Items.Add("香蕉");
            comboBox4.Items.Add("蘋果");
            comboBox4.Items.Add("哈密瓜");
            comboBox4.Items.Add("櫻桃");

            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            int i = comboBox5.SelectedIndex;

            label5.Text = i.ToString();
        }

        private void comboBox6_TextChanged(object sender, EventArgs e)
        {
            label6.Text = comboBox6.Text;
        }
    }
}
