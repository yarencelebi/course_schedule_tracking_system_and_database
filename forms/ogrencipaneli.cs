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
        string baglantiCumlesi = @"Server=.\SQLEXPRESS; Database=DersProgramiDB; Integrated Security=True; TrustServerCertificate=True ;";
        private ogrenci aktifOgrenci;
        public ogrencipaneli(ogrenci gelenogrenci)
        {
            InitializeComponent();
            aktifOgrenci = gelenogrenci;

            
            if (aktifOgrenci != null)
            {
                lblhosgeldin.Text = "Hoş geldin, " + aktifOgrenci.Ad + " " + aktifOgrenci.Soyad + " (" + aktifOgrenci.Bolum + ")";
            }
            else
            {
                lblhosgeldin.Text = "Hoş geldin, Test Öğrencisi";
            }

            int gercekID = aktifOgrenci.OgrenciID;

            
            string sorgu = "EXEC sp_OgrenciDersleri @OgrenciID";
            SqlParameter parametre = new SqlParameter("@OgrenciID", gercekID);

            
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (this.aktifOgrenci != null)
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
                {
                    
                    SqlCommand komut = new SqlCommand("sp_OgrenciDersleri", baglanti);
                    komut.CommandType = CommandType.StoredProcedure; 

                    
                    komut.Parameters.AddWithValue("@OgrenciID", aktifOgrenci.OgrenciID);

                    
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(komut);

                    baglanti.Open();
                    da.Fill(dt);
                    dgvdersprogrami.DataSource = dt; 
                    baglanti.Close();
                }

                MessageBox.Show("Ders programın başarıyla güncellendi!", "Bilgi");
            }
        }
    }
}
