﻿using System;
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
    public partial class parrallel : Form
    {
        public parrallel()
        // program starts off showing part 0
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        // try catch and assigning different amounts of resistors in the comboBox 
        {
            try
            {
                double Rt = 0;

                // the formula for finding the total resitance
                if (comboBox1.SelectedIndex == 0)
                {
                    double R1 = Convert.ToDouble(textBox1.Text);
                    double R2 = Convert.ToDouble(textBox2.Text);

                    Rt = 1 / (1 / R1 + 1 / R2);
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    double R1 = Convert.ToDouble(textBox1.Text);
                    double R2 = Convert.ToDouble(textBox2.Text);
                    double R3 = Convert.ToDouble(textBox3.Text);
                    Rt = 1 / R1 + 1 / R2 + 1 / R3;
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    double R1 = Convert.ToDouble(textBox1.Text);
                    double R2 = Convert.ToDouble(textBox2.Text);
                    double R3 = Convert.ToDouble(textBox3.Text);
                    double R4 = Convert.ToDouble(textBox4.Text);
                    Rt = 1 / (1 / R1 + 1 / R2 + 1 / R3 + 1 / R4);
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    double R1 = Convert.ToDouble(textBox1.Text);
                    double R2 = Convert.ToDouble(textBox2.Text);
                    double R3 = Convert.ToDouble(textBox3.Text);
                    double R4 = Convert.ToDouble(textBox4.Text);
                    double R5 = Convert.ToDouble(textBox5.Text);
                    Rt = 1 / (1 / R1 + 1 / R2 + 1 / R3 + 1 / R4 + 1 / R5);
                }
                label1.Text = "the answer is " + Rt.ToString("0.00");
            }
            // show a message to inform the user they've done something wrong
            catch
            {
                MessageBox.Show("tiz broken");
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        // hides and shoes different features at different points
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

        private void button2_Click(object sender, EventArgs e)
        // a button to take the user to the series section
        {
            this.Hide();
            var newForm = new Form1();
            newForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
