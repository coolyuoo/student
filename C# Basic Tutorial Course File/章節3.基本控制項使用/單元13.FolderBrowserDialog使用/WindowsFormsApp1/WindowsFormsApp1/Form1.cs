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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 設置描述
            folderBrowserDialog1.Description = "AAAAAA";

            // 設置根文件夾為桌面
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;

            folderBrowserDialog1.ShowDialog();
        }

    }
}
