using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(button1, "這是按鈕");
            toolTip1.SetToolTip(label1, "這是label");
        }


     

    }
}
