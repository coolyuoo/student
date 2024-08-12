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
            // 設置過濾器來允許特定文件類型
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            //有點無聊 不使用沒關係
            openFileDialog1.FilterIndex = 2; // 預設選擇第一個過濾器

            openFileDialog1.InitialDirectory = @"D:\CodeProject\線下教學\student\C# Basic Tutorial Course File\章節3.基本控制項使用\temp"; // 更改為你的初始路徑

            // 如果用戶選擇了一個文件，則顯示其路徑
            openFileDialog1.ShowDialog();

        }

    }
}
