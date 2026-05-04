using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using veritabanı_ui.forms;
using veritabanı_ui.models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
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
                MessageBox.Show("Lütfen e-posta ve şifre alanlarını doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string girilenEmail = Eposta.Text;
            string girilenSifre = Sifre.Text;

            // 2. ADIM: Admin Seçiliyse (Yeni butonun adı muhtemelen radioButton3)
            if (admin.Checked)
            {
                if (girilenEmail == "admin@deu.edu.tr" && girilenSifre == "123")
                {
                    adminpaneli adminForm = new adminpaneli();
                    adminForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Admin e-posta veya şifresi hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // 3. ADIM: Öğretmen Seçiliyse
            else if (Ogretmen.Checked)
            {
                if (girilenEmail == "hoca@deu.edu.tr" && girilenSifre == "123")
                {
                    ogretmenpaneli ogretmenForm = new ogretmenpaneli();
                    ogretmenForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Öğretmen e-posta veya şifresi hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // 4. ADIM: Öğrenci Seçiliyse
            else if (Ogrenci.Checked)
            {
                if (girilenEmail == "ogrenci@deu.edu.tr" && girilenSifre == "123")
                {
                    // Veritabanı yokken sistemi kandırıyoruz: Sahte bir kargo paketi oluşturduk!
                    ogrenci sahteOgrenci = new ogrenci();
                    sahteOgrenci.Ad = "Ahmet";
                    sahteOgrenci.Soyad = "Yılmaz";

                    // Paketi diğer forma gönderiyoruz
                    ogrencipaneli ogrenciForm = new ogrencipaneli(sahteOgrenci);
                    ogrenciForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Öğrenci e-posta veya şifresi hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // 5. ADIM: Hiçbir Rol Seçilmediyse (Güvenlik Önlemi)
            else
            {
                MessageBox.Show("Lütfen giriş yapmak için bir rol (Admin, Öğretmen veya Öğrenci) seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void admin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
