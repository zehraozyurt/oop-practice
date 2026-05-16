using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ders2
{
    public partial class Form5 : Form
    {
        DataTable dt = new DataTable();
        public Form5()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
            dataGridView1.DataSource = dt;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

            dt.Columns.Add("T.C. No ", typeof(int));
            dt.Columns.Add("Ad ", typeof(string));
            dt.Columns.Add("Soyad ", typeof(string));
            dataGridView1.DataSource = dt;
        }
    }
}
