using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = a + b;
                textBox3.Text = c.ToString();
            }
            else
            {
                if (radioButton2.Checked)
                {
                    double a = Convert.ToDouble(textBox1.Text);
                    double b = Convert.ToDouble(textBox2.Text);
                    double c = a - b;
                    textBox3.Text = c.ToString();
                }
                else
                {
                    if (radioButton3.Checked)
                    {
                        double a = Convert.ToDouble(textBox1.Text);
                        double b = Convert.ToDouble(textBox2.Text);
                        double c = a * b;
                        textBox3.Text = c.ToString();
                    }
                    else
                    {
                        if (radioButton4.Checked)
                        {
                            double a = Convert.ToDouble(textBox1.Text);
                            double b = Convert.ToDouble(textBox2.Text);
                            double c = a / b;
                            textBox3.Text = c.ToString();
                        }
                    }
                }
            }
        }

    }
}

