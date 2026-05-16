using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
Asagidaki gibi bir form uygulayarak Renk Degistir butonuna basildiktan 
sonra Form’um rengini kirmizi, buton’un rengisini yeşil ve buton’un text’ini mavi 
yapan programi,
a) Geriye deger dondurmeyen, parametresiz, “renkDegistir()” isimli bir metot 
ornegi için uygulayınız. 
b) Geriye deger dondurmeyen, parametreli, “renkDegistir()” isimli bir metot 
ornegi için uygulayınız. */

namespace Der4Formlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void renkdegistir()
        {
            foreach (Control obj in this.Controls)
            {
                obj.Text = "renk degisti";
                obj.BackColor = Color.Green;
                BackColor = Color.Red;
                ForeColor = Color.Blue;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            renkdegistir();

        }
    }
}
