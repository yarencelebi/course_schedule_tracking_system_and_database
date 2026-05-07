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
            aktifOgretmen = gelenOgretmen;
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
            
            if (dgvhocaprogram.SelectedRows.Count > 0 && dgvhocaprogram.SelectedRows[0].DataBoundItem != null)
            {
                DataRowView seciliSatir = (DataRowView)dgvhocaprogram.SelectedRows[0].DataBoundItem;
                string seciliDersKodu = seciliSatir["DersKodu"].ToString();
                string seciliDersAdi = seciliSatir["DersAdi"].ToString();

                lblogrencilist.Text = seciliDersAdi + " Dersi Öğrenci Listesi";

               
                string sorgu = $@"SELECT o.Ad, o.Soyad, o.Bolum 
                          FROM DersKayitlari dk
                          JOIN Ogrenciler o ON dk.OgrenciID = o.OgrenciID
                          JOIN Dersler d ON dk.DersID = d.DersID
                          WHERE d.DersKodu = '{seciliDersKodu}'";

                DataTable hamVeri = VeriGetir(sorgu);

                

                
                List<models.ogrenci> ogrenciListesi = new List<models.ogrenci>();

                
                foreach (DataRow satir in hamVeri.Rows)
                {
                    
                    models.ogrenci yeniOgrenci = new models.ogrenci();

                    
                    yeniOgrenci.Ad = satir["Ad"].ToString();
                    yeniOgrenci.Soyad = satir["Soyad"].ToString();
                    yeniOgrenci.Bolum = satir["Bolum"].ToString();

                    
                    ogrenciListesi.Add(yeniOgrenci);
                }

                
                dgvogrencilist.DataSource = ogrenciListesi;
            }
        }


        private void OgrencileriGetir(string dersId, string dersAdi)
        {
            
            lblogrencilist.Text = dersAdi + " Dersi Öğrenci Listesi";

            
            if (dersId == "1") 
            {
                dgvogrencilist.DataSource = new List<object>
        {
            new { No = "2026001", Ad = "Ali", Soyad = "Yılmaz", Not = "70" },
            new { No = "2026002", Ad = "Veli", Soyad = "Kaya", Not = "85" }
        };
            }
            else if (dersId == "2")
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

        private void refresh_Click(object sender, EventArgs e)
        {
          
            
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                
                string sorgu = @"SELECT d.DersKodu, d.DersAdi, s.SinifAdi, dp.Gun, 
                        (CONVERT(varchar(5), dp.BaslangicSaat) + ' - ' + CONVERT(varchar(5), dp.BitisSaat)) as Saat
                        FROM DersProgrami dp
                        JOIN Dersler d ON dp.DersID = d.DersID
                        JOIN Siniflar s ON dp.SinifID = s.SinifID
                        WHERE dp.OgretmenID = @hocaID";

                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@hocaID", aktifOgretmen.OgretmenID);

               
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);

                baglanti.Open();
                da.Fill(dt);
                dgvhocaprogram.DataSource = dt; 
                baglanti.Close();
            }

            MessageBox.Show("Liste güncellendi!");
        }
    }
    }

        
    

