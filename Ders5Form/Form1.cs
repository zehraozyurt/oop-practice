using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders5Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            int mavi = trackBar1.Value; 
            int yesil =trackBar2.Value;
            int kirmizi= trackBar3.Value;
            
            Form2 frm2 = new Form2(kirmizi, yesil,  mavi);
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mavi : " + trackBar1.Value + "\n" + "Yeşil : " + trackBar2.Value + "\n" + "Kırmızı : " + trackBar3.Value);
        }
    }
}
