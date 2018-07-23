using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login_Marksheet_Display
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "LOGIN_FORM";
            
            this.label1.Text="USERNAME";
            this.label2.Text = "PASSWORD";

            this.button1.Text = "OKAY";
            this.button2.Text = "CLEAR";
            this.button3.Text = "EXIT";

            this.textBox1.Text = "Enter Your Name";
            this.textBox2.Text = "Enter Password";

            this.textBox1.CharacterCasing = CharacterCasing.Upper;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = " ";
            this.textBox2.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  if (this.textBox1.Text == "MISHEL" && this.textBox2.Text == "1234")
           // {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
           // }
           // else
           // {
           //     MessageBox.Show("Invalid UserName or Password!");
           // }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = " ";

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = " ";
            
        }


    }
}
