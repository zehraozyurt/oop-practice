namespace Ders3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1 = Convert.ToInt32(textBox1.Text);
                int sayi2 = Convert.ToInt32(textBox2.Text);
                int bolum = sayi1 / sayi2;
                MessageBox.Show("Sonuc: " + bolum);
            }
            catch(DivideByZeroException ııı)
            {
                MessageBox.Show("Hata sifira boldunuz");
                MessageBox.Show(ııı.Message);

            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Lütfen sayi giriniz");
            }

        }
    }
}
