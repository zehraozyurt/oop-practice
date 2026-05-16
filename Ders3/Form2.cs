using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ders3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                int yas = Convert.ToInt32(textBox3.Text);
                if (yas < 18) throw new Exception("18 den büyük olmalısısınız !!");
            }
            

            catch(Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }
    }
}
