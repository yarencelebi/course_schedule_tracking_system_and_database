using System.Diagnostics.Eventing.Reader;

namespace veritabanı_ui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void giris_Click(object sender, EventArgs e)
        {
           
        
            // 1. ADIM: Boşluk Kontrolü
            if (string.IsNullOrWhiteSpace(Eposta.Text) || string.IsNullOrWhiteSpace(Sifre.Text))
            {
                MessageBox.Show("Lütfen e-posta ve şifre alanlarını doldurun.");
                return; // Hata burada çözülüyor: Kodun geri kalanını çalıştırma!
            }

            // 2. ADIM: Rol Kontrolü
            if (Ogrenci.Checked) // "== true" yazmana gerek yok, Checked zaten true/false döner
            {
                if (Eposta.Text.Trim() == "123" && Sifre.Text.Trim() == "123")
                {
                    MessageBox.Show("Öğrenci olarak giriş yapıldı.");
                    // Buraya öğrenci panelini açacak kodu yazabilirsin.
                }
                else
                {
                    MessageBox.Show("Öğrenci bilgileri hatalı.");
                }
            }
            else // Öğrenci seçili değilse Öğretmen varsayıyoruz
            {
                if (Eposta.Text.Trim() == "456" && Sifre.Text.Trim() == "456")
                {
                    MessageBox.Show("Öğretmen olarak giriş yapıldı.");
                    // Buraya öğretmen panelini açacak kodu yazabilirsin.
                }
                else
                {
                    MessageBox.Show("Öğretmen bilgileri hatalı.");
                }
            }
        }
               
                
            
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void eposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ogrenci_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Epostabaslık_Click(object sender, EventArgs e)
        {

        }
    }
}
