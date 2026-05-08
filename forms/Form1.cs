using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using veritabanı_ui.forms;
using veritabanı_ui.models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Data;
using System.Data.SqlClient;

namespace veritabanı_ui

{
    public partial class Form1 : Form
    {
        string baglantiCumlesi = @"Server=.\SQLEXPRESS; Database=DersProgramiDB; Integrated Security=True; TrustServerCertificate=True ;";
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


            // 3. ADIM: Öğretmen Seçiliyse
            if (Ogretmen.Checked)
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
                {
                    baglanti.Open();
                    // Öğretmenin sadece varlığını değil, ID ve isim bilgilerini de istiyoruz
                    // Sorguyu bu şekilde güncelle: Kullanicilar (K) ile Ogretmenler (O) tablolarını bağlıyoruz
                    string sorgu = @"SELECT O.OgretmenID, O.Ad, O.Soyad 
                FROM Kullanicilar K 
                JOIN Ogretmenler O ON K.KullaniciID = O.KullaniciID 
                WHERE K.Email=@email AND K.Sifre=@sifre AND K.Rol='Ogretmen'";

                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@email", girilenEmail);
                        komut.Parameters.AddWithValue("@sifre", girilenSifre);

                        using (SqlDataReader dr = komut.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                // 1. Yeni bir öğretmen nesnesi oluşturup içini dolduruyoruz
                                models.ogretmen hocaGiris = new models.ogretmen();
                                hocaGiris.OgretmenID = Convert.ToInt32(dr["OgretmenID"]);
                                hocaGiris.Ad = dr["Ad"].ToString();
                                hocaGiris.Soyad = dr["Soyad"].ToString();

                                // 2. null yerine artık dolu olan 'hocaGiris' paketini gönderiyoruz
                                ogretmenpaneli hocaForm = new ogretmenpaneli(hocaGiris);
                                hocaForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Öğretmen e-posta veya şifresi hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            
            else if (Ogrenci.Checked)
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
                {
                    baglanti.Open();
                    
                    
                    string sorgu = @"SELECT S.OgrenciID, S.Ad, S.Soyad, S.Bolum 
                FROM Kullanicilar K 
                JOIN Ogrenciler S ON K.KullaniciID = S.KullaniciID 
                WHERE K.Email=@email AND K.Sifre=@sifre AND K.Rol='Ogrenci'";
                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@email", girilenEmail);
                        komut.Parameters.AddWithValue("@sifre", girilenSifre);

                        
                        using (SqlDataReader dr = komut.ExecuteReader())
                        {
                           
                            if (dr.Read())
                            {
                                
                                models.ogrenci girisYapan = new models.ogrenci();
                                girisYapan.OgrenciID = Convert.ToInt32(dr["OgrenciID"]);
                                girisYapan.Ad = dr["Ad"].ToString();
                                girisYapan.Soyad = dr["Soyad"].ToString();
                                girisYapan.Bolum = dr["Bolum"].ToString();
                                
                                
                                ogrencipaneli ogrenciForm = new ogrencipaneli(girisYapan);
                                ogrenciForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                
                                MessageBox.Show("Öğrenci e-posta veya şifresi hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            
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

       
    }
}
