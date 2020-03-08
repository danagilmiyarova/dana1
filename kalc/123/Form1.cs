using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
            textBox3.Text = a.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(textBox4.Text) - Convert.ToInt32(textBox5.Text);
            textBox6.Text = b.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(textBox7.Text) * Convert.ToInt32(textBox8.Text);
            textBox9.Text = c.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox11.Text) == 0)
            {
                MessageBox.Show("На ноль делить нельзя");
            }
            int d = Convert.ToInt32(textBox10.Text) / Convert.ToInt32(textBox11.Text);
            textBox12.Text = d.ToString();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = " ";
            textBox8.Text = " ";
            textBox9.Text = " ";
            textBox10.Text = " ";
            textBox11.Text = " ";
            textBox12.Text = " ";


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
