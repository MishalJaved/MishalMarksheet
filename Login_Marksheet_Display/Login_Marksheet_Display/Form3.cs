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
    public partial class Form3 : Form
    {
        Form2 f2;
        public Form3(Form2 ff2)
        {
            f2 = ff2;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "MarkSheet";

            this.label1.Text = "VP";
            this.label2.Text = "DS";
            this.label3.Text = "DBMS";
            this.label4.Text = "COA";
            this.label5.Text = "URDU";
 
            this.button1.Text = "CLEAR";
            this.button2.Text = "OKAY";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = " ";
            this.textBox2.Text = " ";
            this.textBox3.Text = " ";
            this.textBox4.Text = " ";
            this.textBox5.Text = " ";
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sum;
            double per;

            int a = Convert.ToInt32(this.textBox1.Text);
            int b = Convert.ToInt32(this.textBox2.Text);
            int c = Convert.ToInt32(this.textBox3.Text);
            int d = Convert.ToInt32(this.textBox4.Text);
            int f = Convert.ToInt32(this.textBox5.Text);

           

            sum = a + b + c + d + f;
            per = (sum / 500) * 100;

            if (per >= 70 )
            {
                f2.textBox7.Text = "GRADE IS A";

            }

           else if (per >= 60 && per <= 70)
            {
                f2.textBox7.Text = "GRADE IS B";

            }

            else if (per >= 50 && per <= 60)
            {
                f2.textBox7.Text = "GRADE IS C";

            }

            else if (per >= 40 && per <= 50)
            {
                f2.textBox7.Text = "GRADE IS D";

            }

           else
            {
               f2.textBox7.Text = "FAIL";
            }
            f2.textBox5.Text = Convert.ToString(per);

                f2.textBox6.Text += "NAME:"+f2.textBox1.Text+Environment.NewLine;
                f2.textBox6.Text += "CLASS:" + f2.textBox2.Text + Environment.NewLine;
                f2.textBox6.Text +="SECTION:"+f2.textBox3.Text+Environment.NewLine;
                f2.textBox6.Text +="YEAR:"+f2.textBox4.Text+Environment.NewLine;
                f2.textBox6.Text += "MARKS" + Environment.NewLine;
                f2.textBox6.Text += "VP:" + this.textBox1.Text + Environment.NewLine;
                f2.textBox6.Text += "DS" + this.textBox2.Text + Environment.NewLine;
                f2.textBox6.Text += "DBMS:" + this.textBox3.Text + Environment.NewLine;
                f2.textBox6.Text += "COA:" + this.textBox4.Text + Environment.NewLine;
                f2.textBox6.Text += "URDU" + this.textBox5.Text + Environment.NewLine;
                f2.textBox6.Text +="PER%:"+per.ToString()+f2.textBox5.Text+Environment.NewLine;
                f2.textBox6.Text += "GRADE:" + f2.textBox7.Text + Environment.NewLine;

                this.Hide();
           
        }
    }
}
