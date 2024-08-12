using System;
using System.Drawing;
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
            //ALT+ENTER 跳出引用指示語

            //D:\CodeProject\線下教學\student\C# Basic Tutorial Course File\章節3.基本控制項使用\temp\dog.jpg

            String x = textBox1.Text;

            Image img = Image.FromFile(x);

            pictureBox1.Image = img;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // 縮放圖像以填滿PictureBox的整個區域
         
        }

   

        //事件 是一種行為 代表你對這個控制項做了甚麼事情
        //依照多年經驗 你只會用到click 


    }
}
