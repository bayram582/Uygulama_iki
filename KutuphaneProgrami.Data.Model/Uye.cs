using System;
using System.Collections.Generic;

namespace KutuphaneProgrami.Data.Model
{
   public class Uye:BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tc { get; set; }
        public string Tel { get; set; }
        public DateTime kayitTarihi { get; set; }
        public  string Mail { get; set; }
        public  string Sifre { get; set; }
        public  int Ceza { get; set; }
        public  char Yetki { get; set; }
        public List<OduncKitap> OduncKitaplar { get; set; } 
      
    }
}
