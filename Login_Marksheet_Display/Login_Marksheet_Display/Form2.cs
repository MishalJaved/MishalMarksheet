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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "BioData";

            this.label1.Text = "NAME:";
            this.label2.Text = "CLASS:";
            this.label3.Text = "SECTION:";
            this.label4.Text = "YEAR:";
            this.label5.Text = "PER%:";
            this.label6.Text = "RESULT:";
            this.label7.Text = "GRADE";

            this.button1.Text = "CLEAR";
            this.button2.Text = "EXIT";
            this.button3.Text = "ENTER MARKS";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = " ";
            this.textBox2.Text = " "; 
            this.textBox3.Text = " ";
            this.textBox4.Text = " ";
            this.textBox5.Text = " ";
            this.textBox6.Text = " ";
            this.textBox7.Text = " ";

            this.textBox6.ScrollBars = ScrollBars.Horizontal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this);
            f3.Show();
            
        }
    }
}
