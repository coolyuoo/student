﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            int i = 12222222222;
            long l = 12222222222222222;
            short s = 122222;

            MessageBox.Show(i.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 1222222222;
            long l = 12222222222222222;
            short s = 12222;

            long x = i + l + s;

            MessageBox.Show(x.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            long i = Convert.ToInt64("122");

            MessageBox.Show(i.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            long i = Convert.ToInt64("122a");

            //會失敗
            MessageBox.Show(i.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            long i = -1000000;

            MessageBox.Show(i.ToString());
        }
    }
}
