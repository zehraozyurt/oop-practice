using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Der4Formlar
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        double OrtHesapla(int vize,int final)
        {
            double ortalama= vize*0.4 + final * 0.6;
            return ortalama;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double ortalama = 0;
            int vize = Convert.ToInt32(textBox1.Text);
            int final = Convert.ToInt32(textBox2.Text);
            label4.Text=OrtHesapla(vize, final).ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
