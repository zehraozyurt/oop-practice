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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        void renkDegistir(Control obj1, Form obj2)
        {
            obj1.Text = "Renk degistirildi";
            obj1.BackColor = Color.Green;
            BackColor = Color.Red;
            obj2.Text = "Parametreli void metodu";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            renkDegistir(button1, Form2.ActiveForm);
        }
    }
}
