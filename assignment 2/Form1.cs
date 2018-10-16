using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Rt=0;

            if (comboBox1.SelectedIndex == 0)
            {
                double R1 = Convert.ToDouble(textBox1.Text);
                double R2 = Convert.ToDouble(textBox2.Text);
            
                Rt = R1 + R2;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                double R1 = Convert.ToDouble(textBox1.Text);
                double R2 = Convert.ToDouble(textBox2.Text);
                double R3 = Convert.ToDouble(textBox3.Text);
                Rt = R1 + R2 + R3;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                double R1 = Convert.ToDouble(textBox1.Text);
                double R2 = Convert.ToDouble(textBox2.Text);
                double R3 = Convert.ToDouble(textBox3.Text);
                double R4 = Convert.ToDouble(textBox4.Text);
                Rt = R1 + R2 + R3 + R4;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                double R1 = Convert.ToDouble(textBox1.Text);
                double R2 = Convert.ToDouble(textBox2.Text);
                double R3 = Convert.ToDouble(textBox3.Text);
                double R4 = Convert.ToDouble(textBox4.Text);
                double R5 = Convert.ToDouble(textBox5.Text);
                Rt = R1 + R2 + R3 + R4 + R5;
            }
            label1.Text = "the answer is " + Rt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox3.Hide();
                textBox4.Hide();
                textBox5.Hide();

                textBox1.Show();
                textBox2.Show();
                label1.Show();
                button1.Show();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                textBox4.Hide();
                textBox5.Hide();

                textBox3.Show();
                textBox1.Show();
                textBox2.Show();
                label1.Show();
                button1.Show();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                textBox5.Hide();

                textBox4.Show();
                textBox3.Show();
                textBox1.Show();
                textBox2.Show();
                label1.Show();
                button1.Show();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                textBox5.Show();
                textBox4.Show();
                textBox3.Show();
                textBox1.Show();
                textBox2.Show();
                label1.Show();
                button1.Show();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
