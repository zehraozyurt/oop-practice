
namespace Ders2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string KullaniciAdi = kullaniciAditextBox1.Text;
            string sifre = SifretextBox2.Text;
            Form genelForm = ActiveForm;
            if (KullaniciAdi == "Zonguldak" && sifre == "1234" && (radioButton2.Checked))
            {
                genelForm.BackColor = Color.Green;
                MessageBox.Show("Kullanici adi ve Sifre doğru");

            }
            else
            {
                genelForm.BackColor = Color.Red;
                MessageBox.Show("Kullanici adi veya sifreniz hatali ");
            }
            genelForm.BackColor = Color.DarkGray;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
