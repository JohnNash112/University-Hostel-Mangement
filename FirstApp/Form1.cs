﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FirstApp
{  
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();
            f2.ShowDialog();
            if (data.v == 1)
            {
                this.Hide();
                Form3 f3 = new Form3();
                f3.Show();                
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmh cmh = new cmh();
            cmh.Show();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nmh nmh = new nmh();
            nmh.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nwh nwh = new nwh();
            nwh.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pmh pmh = new pmh();
            pmh.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    public static class data
    {//This is to share status of correct password between form1 and form2
        public static Int32 v;
    }
}
