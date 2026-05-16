using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ders2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonBolgeyiBul_Click(object sender, EventArgs e)
        {
            int xekseni = Convert.ToInt32(textBoxXEkseni.Text);
            int yekseni = Convert.ToInt32(textBoxYEkseni.Text);

            if (xekseni>0 && yekseni > 0) labelSonuc.Text = "1. Bölge";
            else if (xekseni < 0 && yekseni > 0) labelSonuc.Text = "2. Bölge";
            else if (xekseni < 0 && yekseni < 0) labelSonuc.Text = "3. Bölge";
            else if (xekseni > 0 && yekseni < 0) labelSonuc.Text = "4. Bölge";
            else labelSonuc.Text = "Eksen Üzerinde";
        }
    }
}
