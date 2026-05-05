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
    public partial class ogrencipaneli : Form
    {
        private ogrenci aktifOgrenci;
        public ogrencipaneli(ogrenci gelenogrenci)
        {
            InitializeComponent();


            // 3. Kapıdan giren paketi rafımıza koyduk
            aktifOgrenci = gelenogrenci;

            // 4. Paketin içindeki isim ve soyismi ekrandaki Label'a yazdırdık
            lblhosgeldin.Text = "Hoş geldin, " + aktifOgrenci.Ad + " " + aktifOgrenci.Soyad;

            var sahteProgram = new List<object>
            {
                new { Gun = "Pazartesi", Saat = "09:00 - 11:00", Ders = "Nesne Yönelimli Programlama", Sinif = "Amfi-1", Hoca = "Prof. Dr. Nazım" },
                new { Gun = "Pazartesi", Saat = "13:00 - 15:00", Ders = "Veritabanı Yönetimi", Sinif = "Lab-3", Hoca = "Dr. Ayşe Yılmaz" },
                new { Gun = "Çarşamba", Saat = "10:00 - 12:00", Ders = "Nümerik Analiz", Sinif = "D-102", Hoca = "Doç. Dr. Ali Veli" }
            };
            dgvdersprogrami.DataSource = sahteProgram;
        }

        private void ogrencipaneli_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
