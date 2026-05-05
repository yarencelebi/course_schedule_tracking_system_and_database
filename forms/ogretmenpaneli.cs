using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using veritabanı_ui.models;

namespace veritabanı_ui.forms
{
    public partial class ogretmenpaneli : Form
    {
        private ogretmen aktifOgretmen;
        public ogretmenpaneli(ogretmen gelenOgretmen)
        {
            InitializeComponent();
            aktifOgretmen = gelenOgretmen;// Güvenlik kontrolü (Hoca boş gelirse patlamasın)
            if (aktifOgretmen != null)
            {
                lblyazi.Text = $"Sayın {aktifOgretmen.Ad} {aktifOgretmen.Soyad}, Hoş Geldiniz";
            }

            ProgramiGetir();
        }
        private void ProgramiGetir()
        {
            var sahteDersler = new List<object>
            {
                new { DersID = 1, DersAdi = "Veritabanı Yönetimi", Gun = "Pazartesi" },
                new { DersID = 2, DersAdi = "Nümerik Analiz", Gun = "Salı" }
            };
            dgvhocaprogram.DataSource = sahteDersler;
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

            if (dgvhocaprogram.SelectedRows.Count > 0)
            {
                // Seçili satırdan hem ID'yi hem de DERS ADINI alıyoruz
                var seciliDersId = dgvhocaprogram.SelectedRows[0].Cells["DersID"].Value.ToString();
                var seciliDersAdi = dgvhocaprogram.SelectedRows[0].Cells["DersAdi"].Value.ToString();

                // Metodu iki parametreyle çağırıyoruz
                OgrencileriGetir(seciliDersId, seciliDersAdi);
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
        
    

