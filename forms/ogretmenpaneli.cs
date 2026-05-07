using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using veritabanı_ui.models;
using System.Data.SqlClient;

namespace veritabanı_ui.forms
{
    public partial class ogretmenpaneli : Form
    {
        string baglantiCumlesi = @"Server=.\SQLEXPRESS; Database=DersProgramiDB; Integrated Security=True;";
        private ogretmen aktifOgretmen;

        public ogretmenpaneli(models.ogretmen gelenOgretmen)
        {
            InitializeComponent();
            aktifOgretmen = gelenOgretmen;// Güvenlik kontrolü (Hoca boş gelirse patlamasın)
            if (aktifOgretmen != null)
            {
                lblyazi.Text = "Sayın " + aktifOgretmen.Ad + " " + aktifOgretmen.Soyad + " Hoş Geldiniz";
            }

            ProgramiGetir();
        }
        private DataTable VeriGetir(string sorgu)
        {
            DataTable dt = new DataTable();
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    da.Fill(dt);
                }
            }
            return dt;
        }
        private void ProgramiGetir()
        {
            string sorgu = @"SELECT d.DersKodu, d.DersAdi, s.SinifAdi, dp.Gun, 
                    (CONVERT(varchar(5), dp.BaslangicSaat) + ' - ' + CONVERT(varchar(5), dp.BitisSaat)) as Saat
                    FROM DersProgrami dp
                    JOIN Dersler d ON dp.DersID = d.DersID
                    JOIN Siniflar s ON dp.SinifID = s.SinifID
                    WHERE dp.OgretmenID = 1";
            DataTable gelenVeri = VeriGetir(sorgu);
            dgvhocaprogram.DataSource = gelenVeri;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ogretmenpaneli_Load(object sender, EventArgs e)
        {

        }

        private void dgvhocaprogram_SelectionChanged(object sender, EventArgs e)
        {
            // 1. Üst tablodan bir ders seçili mi diye kontrol ediyoruz (Burası aynı)
            if (dgvhocaprogram.SelectedRows.Count > 0 && dgvhocaprogram.SelectedRows[0].DataBoundItem != null)
            {
                DataRowView seciliSatir = (DataRowView)dgvhocaprogram.SelectedRows[0].DataBoundItem;
                string seciliDersKodu = seciliSatir["DersKodu"].ToString();
                string seciliDersAdi = seciliSatir["DersAdi"].ToString();

                lblogrencilist.Text = seciliDersAdi + " Dersi Öğrenci Listesi";

                // 2. SQL'den öğrencileri getirecek siparişimizi hazırlayıp ham veriyi çekiyoruz
                string sorgu = $@"SELECT o.Ad, o.Soyad, o.Bolum 
                          FROM DersKayitlari dk
                          JOIN Ogrenciler o ON dk.OgrenciID = o.OgrenciID
                          JOIN Dersler d ON dk.DersID = d.DersID
                          WHERE d.DersKodu = '{seciliDersKodu}'";

                DataTable hamVeri = VeriGetir(sorgu);

                // --- İŞTE BURADA MODELLER DEVREYE GİRİYOR ---

                // 3. Modellerimizi tutacağımız boş bir liste oluşturuyoruz
                List<models.ogrenci> ogrenciListesi = new List<models.ogrenci>();

                // 4. SQL'den gelen her bir satırı dönüyoruz
                foreach (DataRow satir in hamVeri.Rows)
                {
                    // Senin yazdığın 'ogrenci' modelinden yeni bir nesne (paket) oluşturuyoruz
                    models.ogrenci yeniOgrenci = new models.ogrenci();

                    // SQL'den gelen verileri modele aktarıyoruz
                    yeniOgrenci.Ad = satir["Ad"].ToString();
                    yeniOgrenci.Soyad = satir["Soyad"].ToString();
                    yeniOgrenci.Bolum = satir["Bolum"].ToString();

                    // Doldurduğumuz bu modeli listeye ekliyoruz
                    ogrenciListesi.Add(yeniOgrenci);
                }

                // 5. Son olarak, ham veriyi DEĞİL, kendi oluşturduğumuz model listesini tabloya veriyoruz
                dgvogrencilist.DataSource = ogrenciListesi;
            }
        }

        
        private void OgrencileriGetir(string dersId, string dersAdi)
        {
            // 1. Önce öğrenci listesinin üzerindeki başlığı (label) güncelleyelim
            lblogrencilist.Text = dersAdi + " Dersi Öğrenci Listesi";

            // 2. Şimdi seçilen dersId'ye göre tabloyu dolduralım
            if (dersId == "1") // Veritabanı Yönetimi
            {
                dgvogrencilist.DataSource = new List<object>
        {
            new { No = "2026001", Ad = "Ali", Soyad = "Yılmaz", Not = "70" },
            new { No = "2026002", Ad = "Veli", Soyad = "Kaya", Not = "85" }
        };
            }
            else if (dersId == "2") // Nümerik Analiz
            {
                dgvogrencilist.DataSource = new List<object>
        {
            new { No = "2026003", Ad = "Ayşe", Soyad = "Demir", Not = "90" },
            new { No = "2026004", Ad = "Fatma", Soyad = "Çelik", Not = "65" }
        };
            }
        }

        private void lblogrencilist_Click(object sender, EventArgs e)
        {

        }

        private void dgvogrencilist_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void lblyazi_Click(object sender, EventArgs e)
        {

        }
    }
}
        
    

