using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int capacity = int.Parse(textBox1.Text);
            int n = int.Parse(textBox2.Text);
            int seed = int.Parse(textBox3.Text);
            var p = new ConsoleApp3.Program();
            var s = p.pakowanie(capacity, n, seed);
            textBox4.Text = s;

            // to sie wykona jak kkikne guzik
            // element klasy program i przy wykonywaniu odwolywac sie do metody tej klasy
            // textbox4.text = (jakis string)
            // costam = textbox4.text ( to sa stringi, na inty trzeba castować)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
