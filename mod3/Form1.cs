using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mod3
{
    public partial class Form1 : Form
    {
        private string input;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            input = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Halo " + input;
            textBox2.Show();
        }
    }
}
