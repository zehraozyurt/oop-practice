using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ders2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToInt32(textBox1.Text);
            listBox1.Items.Add(sayi);
        }

        private void buttonSirala_Click(object sender, EventArgs e)
        {
            double buyuksayi, kucuksayi;
            kucuksayi = Convert.ToDouble(listBox1.Items[0]);
            buyuksayi = Convert.ToDouble(listBox1.Items[0]);

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                double sayi = Convert.ToDouble(listBox1.Items[i]);

                if (buyuksayi < sayi)
                {
                    buyuksayi = sayi;
                }
                if (kucuksayi > sayi)
                {
                    kucuksayi = sayi;
                }
            }
            label3.Text ="en kucuk sayi " + kucuksayi.ToString();
            label2.Text = "en buyuk sayi " + buyuksayi.ToString();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            int sec =listBox1.SelectedIndex;
            if (sec != -1) listBox1.Items.RemoveAt(sec);
            else MessageBox.Show("Lütfen listeden bir sayi seçiniz");
        }
    }
}
