using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace zapis_i_open
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //для того чтоб использовать File.ReadAllText я подключила новый метод system.IO
            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == DialogResult.OK)
            {
               richTextBox1.Text = File.ReadAllText(openfile.FileName);
            }


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(savefile.FileName);
            }

            

        }
    }
}
