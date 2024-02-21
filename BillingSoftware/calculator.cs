using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSoftware
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }
        //calculation variable

        double fstNum, secNum;
        string oper;

        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "0")
                textBox1.Text = "1";
              
            else
                textBox1.Text += "1";
            textBox3.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "2";
               // textBox3.Text = "2";
            else
                textBox1.Text += "2";
            textBox3.Text += "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "3";

            else
                textBox1.Text += "3";
            textBox3.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "4";

            else
                textBox1.Text += "4";
            textBox3.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "5";

            else
                textBox1.Text += "5";
            textBox3.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "6";

            else
                textBox1.Text += "6";
            textBox3.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "7";

            else
                textBox1.Text += "7";
            textBox3.Text += "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "8";

            else
                textBox1.Text += "8";
            textBox3.Text += "8";
        }

        private void button16_Click(object sender, EventArgs e) //plus
        {
            fstNum = double.Parse(textBox1.Text);
            oper = "+";
            textBox1.Text = "";
            textBox2.Text = "+";
           // textBox2.Text = "";
        }

        private  void button15_Click(object sender, EventArgs e) //EQUAL BUTON
        {

            secNum = double.Parse (textBox1.Text);


            switch (oper)
            {
                case "+":
                    textBox1.Text = (fstNum + secNum).ToString();
                    textBox2.Text = "+";
                    textBox3.Text = (fstNum +secNum).ToString();
                    break;

                case "-":
                    textBox1.Text = (fstNum - secNum).ToString();
                    textBox2.Text = "-";
                    break;
                case "*":
                    textBox1.Text = (fstNum * secNum).ToString();
                    textBox2.Text = "*";
                    break;
                case "/":
                    textBox1.Text = (fstNum / secNum).ToString();
                    textBox2.Text = "/";
                    break;

            }
            
           
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "9";

            else
                textBox1.Text += "9";
            textBox3.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)//(-)
        {
            fstNum = double.Parse(textBox1.Text);
            oper = "-";
            textBox1.Text = "";
           // textBox2.Text = "-";
        }

        private void button8_Click(object sender, EventArgs e) //(*)
        {
            fstNum = double.Parse(textBox1.Text);
            oper = "*";
            textBox1.Text = "";
           // textBox2.Text = "*";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            fstNum = double.Parse(textBox1.Text);
            oper = "/";
            textBox1.Text = "";
           // textBox2.Text = "/";
        }

        private void button14_Click(object sender, EventArgs e)
        {

            if(!string.IsNullOrWhiteSpace(textBox1.Text))
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            fstNum = 0.0;
            secNum = 0.0;
            i = 0;
        }

      

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "0";

            else
                textBox1.Text += "0";
            textBox3.Text += "0";
        }
    }
}
