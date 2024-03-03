using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                radioButton2.Checked = false;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                radioButton1.Checked = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                try
                {
                    IEquation eq = new PolyEquation(Double.Parse(textBox1.Text),
                        Double.Parse(textBox2.Text),
                        Double.Parse(textBox3.Text));
                    textBox5.Text = eq.Solve();
                }
                catch (PolyException poly_ex)
                {
                    MessageBox.Show(poly_ex.Message);
                }
                catch (System.FormatException format_ex)
                {
                    MessageBox.Show(format_ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (radioButton2.Checked == true)
            {
                try
                {
                    TrigEquation.TrigonometricFunction tf = (TrigEquation.TrigonometricFunction)comboBox1.SelectedIndex;
                    IEquation eq = new TrigEquation(tf, Double.Parse(textBox4.Text));
                    textBox5.Text = eq.Solve();
                }
                catch (TrigException trig_ex)
                {
                    MessageBox.Show(trig_ex.Message);
                }
                catch (System.FormatException format_ex)
                {
                    MessageBox.Show(format_ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calculator Ecuatie polinomiala si trigonometrica.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
