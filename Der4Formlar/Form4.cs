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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        double OrtHesapla()
        {

            int vize = Convert.ToInt32(textBox1.Text);
            int final = Convert.ToInt32(textBox2.Text);
            double ortalama = vize * 0.4 + final * 0.6;
            return ortalama;
        }
        private void button1_Click(object sender, EventArgs e)
        {
        label4.Text = OrtHesapla().ToString();
        }
    }
}
