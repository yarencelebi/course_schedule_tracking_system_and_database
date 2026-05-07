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
    public partial class ogrencipaneli : Form
    {
        string baglantiCumlesi = @"Server=.\SQLEXPRESS; Database=DersProgramiDB; Integrated Security=True;";
        private ogrenci aktifOgrenci;
        public ogrencipaneli(ogrenci gelenogrenci)
        {
            InitializeComponent();
            aktifOgrenci = gelenogrenci;

            // 1. Çökme Koruması: Eğer dışarıdan boş paket (null) gelmediyse ismi yazdır
            if (aktifOgrenci != null)
            {
                lblhosgeldin.Text = "Hoş geldin, " + aktifOgrenci.Ad + " " + aktifOgrenci.Soyad + " (" + aktifOgrenci.Bolum + ")";
            }
            else
            {
                lblhosgeldin.Text = "Hoş geldin, Test Öğrencisi";
            }

            // 2. SQL'den Gerçek Dersleri Çekme
            // Not: Şimdilik test için 1 numaralı öğrenciyi (Ali'yi) çağırıyoruz. 
            // Form1'i tam bağladığımızda burayı aktifOgrenci.OgrenciID olarak değiştireceğiz.
            int gercekID = aktifOgrenci.OgrenciID;

            // Arkadaşının yazdığı o hazır prosedürü (sp_OgrenciDersleri) çalıştırıyoruz
            string sorgu = "EXEC sp_OgrenciDersleri @OgrenciID";
            SqlParameter parametre = new SqlParameter("@OgrenciID", gercekID);

            // Gelen gerçek ders tablosunu arayüze bağlıyoruz
            dgvdersprogrami.DataSource = VeriGetir(sorgu, parametre);

        }
        private DataTable VeriGetir(string sorgu, SqlParameter p = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    if (p != null) komut.Parameters.Add(p);
                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    da.Fill(dt);
                }
            }
            return dt;
        }

        private void ogrencipaneli_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
