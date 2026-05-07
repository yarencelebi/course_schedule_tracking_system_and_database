using System;
using System.Collections.Generic;
using System.Text;

namespace veritabanı_ui.models
{
    public class dersprogrami
    {
        public int ProgramID { get; set; }
        public int DersID { get; set; }
        public int OgretmenID { get; set; }
        public int SinifID { get; set; }
        public string Gun { get; set; } 

        
        public TimeSpan BaslangicSaat { get; set; }
        public TimeSpan BitisSaat { get; set; }
    }
}
