using System;
using System.Collections.Generic;
using System.Text;

namespace veritabanı_ui.models
{
    public class ogretmen
    {
        public int OgretmenID { get; set; }
        public int KullaniciID { get; set; } // Kullanıcılar tablosuyla bağlantı (Foreign Key)
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
}
