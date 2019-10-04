using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormOrai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            button1.BackColor = colorDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            BackColor = colorDialog2.Color;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int elso = Convert.ToInt32(textBox1.Text);
                int masodik = Convert.ToInt32(textBox2.Text);

                int eredmeny = elso + masodik;
                MessageBox.Show("Eredmény: " + eredmeny.ToString());

                //textBox1.Text = (int.Parse(textBox2.Text) + int.Parse(textBox2.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Csak számokkal működik.");
            }



        }

    }
}
