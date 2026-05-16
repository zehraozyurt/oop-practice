using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ders3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double ortalama=0;
                int vize = Convert.ToInt32(textBox1.Text);
                int final = Convert.ToInt32(textBox2.Text);
                if (vize < 0 || vize > 100 || final < 0 || final > 100)
                    throw new ArithmeticException("0-100 Araında sayi giriniz");
                if (final < 50)
                {
                    MessageBox.Show("Dersten kaldınız");
                }
                else
                {
                    ortalama = vize * 0.4 + final * 0.6;
                    textBox3.Text = ortalama.ToString();
                    if (ortalama > 8 && ortalama < 34) label4.Text = "FF";
                    else if (ortalama > 35 && ortalama < 39) label4.Text = "FF";
                    else if (ortalama > 40 && ortalama < 44) label4.Text = "DC";
                    else if (ortalama > 45 && ortalama < 54) label4.Text = "CC";
                    else if (ortalama > 55 && ortalama < 64) label4.Text = "CB";
                    else if (ortalama > 65 && ortalama < 69) label4.Text = "BB";
                    else if (ortalama > 70 && ortalama < 79) label4.Text = "BA";
                    else if (ortalama >= 80) label4.Text = "AA";

                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            catch(OverflowException ex)
            {
                MessageBox.Show(ex.Message);    
            }
            catch (ArithmeticException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
