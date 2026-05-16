using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ders2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(textBox1.Text);
            listBoxSol.Items.Add(sayi);
        }

        private void buttonSirala_Click(object sender, EventArgs e)
        {
            double buyuksayi, kucuksayi;
            kucuksayi = Convert.ToDouble(listBoxSol.Items[0]);
            buyuksayi = Convert.ToDouble(listBoxSol.Items[0]);

            for (int i = 0; i < listBoxSol.Items.Count; i++)
            {
                double sayi = Convert.ToDouble(listBoxSol.Items[i]);

                if (buyuksayi < sayi)
                {
                    buyuksayi = sayi;
                }
                if (kucuksayi > sayi)
                {
                    kucuksayi = sayi;
                }
            }
            label3.Text = "en kucuk sayi " + kucuksayi.ToString();
            label2.Text = "en buyuk sayi " + buyuksayi.ToString();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {

            int sec = listBoxSol.SelectedIndex;
            if (sec != -1) listBoxSol.Items.RemoveAt(sec);
            else MessageBox.Show("Lütfen listeden bir sayi seçiniz");
        }

        private void buttonSagEkle_Click(object sender, EventArgs e)
        {
            listBoxSag.Items.Add(listBoxSol.SelectedItem);
        }

        private void buttonSolEkle_Click(object sender, EventArgs e)
        {
            listBoxSol.Items.Add(listBoxSag.SelectedItem);
        }
    }


}
