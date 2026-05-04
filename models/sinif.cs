using System;
using System.Collections.Generic;
using System.Text;

namespace veritabanı_ui.models
{
    internal class sinif
    {
        public int SinifID { get; set; }
        public string SinifAdi { get; set; } // Örn: "Amfi-1", "D-102", "Bilgisayar Lab"
        public int Kapasite { get; set; }
    }
}
