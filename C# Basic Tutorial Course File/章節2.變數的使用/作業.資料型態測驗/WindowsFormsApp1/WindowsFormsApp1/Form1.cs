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



            if (textBox1.Text == "int")
            {
                q1_1.ForeColor = Color.Green;
                q1_1.Text = "正確";
            }
            else if (textBox1.Text == "")
            {
                q1_1.ForeColor = Color.Green;
                q1_1.Text = "請填寫答案";
            }
            else
            {

                q1_1.ForeColor = Color.Red;
                q1_1.Text = "錯誤 A:int";

            }

            if (textBox2.Text.ToLower() == "string")
            {
                q1_2.ForeColor = Color.Green;
                q1_2.Text = "正確";
            }
            else if (textBox2.Text == "")
            {
                q1_2.ForeColor = Color.Green;
                q1_2.Text = "請填寫答案";
            }
            else
            {
                q1_2.ForeColor = Color.Red;
                q1_2.Text = "錯誤 A:string";
            }

            if (textBox3.Text.ToLower() == "string")
            {
                q1_3.ForeColor = Color.Green;
                q1_3.Text = "正確";
            }
            else if (textBox3.Text == "")
            {
                q1_3.ForeColor = Color.Green;
                q1_3.Text = "請填寫答案";
            }
            else
            {
                q1_3.ForeColor = Color.Red;
                q1_3.Text = "錯誤 A:string";
            }

            if (textBox4.Text.ToLower() == "double")
            {
                q1_4.ForeColor = Color.Green;
                q1_4.Text = "正確";
            }
            else if (textBox4.Text == "")
            {
                q1_4.ForeColor = Color.Green;
                q1_4.Text = "請填寫答案";
            }
            else
            {
                q1_4.ForeColor = Color.Red;
                q1_4.Text = "錯誤 A:double";
            }

            if (textBox5.Text.ToLower() == "bool")
            {
                q1_5.ForeColor = Color.Green;
                q1_5.Text = "正確";
            }
            else if (textBox5.Text == "")
            {
                q1_5.ForeColor = Color.Green;
                q1_5.Text = "請填寫答案";
            }
            else
            {
                q1_5.ForeColor = Color.Red;
                q1_5.Text = "錯誤 A:bool";
            }

            if (textBox6.Text.ToLower() == "bool")
            {
                q1_6.ForeColor = Color.Green;
                q1_6.Text = "正確";
            }
            else if (textBox6.Text == "")
            {
                q1_6.ForeColor = Color.Green;
                q1_6.Text = "請填寫答案";
            }
            else
            {
                q1_6.ForeColor = Color.Red;
                q1_6.Text = "錯誤 A:bool";
            }

            if (textBox7.Text.ToLower() == "string")
            {
                q1_7.ForeColor = Color.Green;
                q1_7.Text = "正確";
            }
            else if (textBox7.Text == "")
            {
                q1_7.ForeColor = Color.Green;
                q1_7.Text = "請填寫答案";
            }
            else
            {
                q1_7.ForeColor = Color.Red;
                q1_7.Text = "錯誤 A:string";
            }

            if (textBox8.Text == "DateTime")
            {
                q1_8.ForeColor = Color.Green;
                q1_8.Text = "正確";
            }
            else if (textBox8.Text == "")
            {
                q1_8.ForeColor = Color.Green;
                q1_8.Text = "請填寫答案";
            }
            else
            {
                q1_8.ForeColor = Color.Red;
                q1_8.Text = "錯誤 A:DateTime";
            }

            if (textBox9.Text.ToLower() == "string")
            {
                q1_9.ForeColor = Color.Green;
                q1_9.Text = "正確";
            }
            else if (textBox9.Text == "")
            {
                q1_9.ForeColor = Color.Green;
                q1_9.Text = "請填寫答案";
            }
            else
            {
                q1_9.ForeColor = Color.Red;
                q1_9.Text = "錯誤 A:string";
            }


            if (textBox10.Text.ToLower() == "123456")
            {
                q2_1.ForeColor = Color.Green;
                q2_1.Text = "正確";
            }
            else if (textBox10.Text == "")
            {
                q2_1.ForeColor = Color.Green;
                q2_1.Text = "請填寫答案";
            }
            else
            {
                q2_1.ForeColor = Color.Red;
                q2_1.Text = "錯誤 A:123456";
            }

            if (textBox11.Text.ToLower() == "123456")
            {
                q2_2.ForeColor = Color.Green;
                q2_2.Text = "正確";
            }
            else if (textBox11.Text == "")
            {
                q2_2.ForeColor = Color.Green;
                q2_2.Text = "請填寫答案";
            }
            else
            {
                q2_2.ForeColor = Color.Red;
                q2_2.Text = "錯誤 A:123456";
            }


            if (textBox12.Text.ToLower() == "false")
            {
                q2_3.ForeColor = Color.Green;
                q2_3.Text = "正確";
            }
            else if (textBox12.Text == "")
            {
                q2_3.ForeColor = Color.Green;
                q2_3.Text = "請填寫答案";
            }
            else
            {
                q2_3.ForeColor = Color.Red;
                q2_3.Text = "錯誤 A:false";
            }


            if (textBox13.Text.ToLower() == "decimal")
            {
                q1_10.ForeColor = Color.Green;
                q1_10.Text = "正確";
            }
            else if (textBox13.Text == "")
            {
                q1_10.ForeColor = Color.Green;
                q1_10.Text = "請填寫答案";
            }
            else
            {
                q1_10.ForeColor = Color.Red;
                q1_10.Text = "錯誤 A:decimal";
            }

            if (textBox14.Text.ToLower() == "decimal")
            {
                q1_11.ForeColor = Color.Green;
                q1_11.Text = "正確";
            }
            else if (textBox14.Text == "")
            {
                q1_11.ForeColor = Color.Green;
                q1_11.Text = "請填寫答案";
            }
            else
            {
                q1_11.ForeColor = Color.Red;
                q1_11.Text = "錯誤 A:decimal";
            }


            if (textBox15.Text.ToLower() == "true")
            {
                q2_4.ForeColor = Color.Green;
                q2_4.Text = "正確";
            }
            else if (textBox15.Text == "")
            {
                q2_4.ForeColor = Color.Green;
                q2_4.Text = "請填寫答案";
            }
            else
            {
                q2_4.ForeColor = Color.Red;
                q2_4.Text = "錯誤 A:true";
            }


            if (textBox16.Text.ToLower() == "false")
            {
                q2_5.ForeColor = Color.Green;
                q2_5.Text = "正確";
            }
            else if (textBox16.Text == "")
            {
                q2_5.ForeColor = Color.Green;
                q2_5.Text = "請填寫答案";
            }
            else
            {
                q2_5.ForeColor = Color.Red;
                q2_5.Text = "錯誤 A:false";
            }

            if (textBox17.Text.ToLower() == "false")
            {
                q2_6.ForeColor = Color.Green;
                q2_6.Text = "正確";
            }
            else if (textBox17.Text == "")
            {
                q2_6.ForeColor = Color.Green;
                q2_6.Text = "請填寫答案";
            }
            else
            {
                q2_6.ForeColor = Color.Red;
                q2_6.Text = "錯誤 A:false";
            }

        }

       
    }
}
