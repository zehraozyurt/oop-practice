using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ders2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonHesapla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1sayi.Text);
            int sayi2 = Convert.ToInt32(textBox2sayi.Text);

            int i;

            for (i = sayi1; i <=sayi2; i++)
            {
                int control = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        control++;
                        break;
                    }

                }
                if (i>1 && control == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    } 
}
