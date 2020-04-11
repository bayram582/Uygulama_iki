using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KutuphaneProgrami.Data.Model
{
   public class Uye:BaseEntity
    {

        [Required]
        [Column(TypeName = "Varchar")]
        [MaxLength(50)]
        public string Ad { get; set; }

        [Required]
        [Column(TypeName = "Varchar")]
        [MaxLength(50)]
        public string Soyad { get; set; }

        
        [Column(TypeName = "char")]
        [MaxLength(11), MinLength(11)]
        public string Tc { get; set; }

      
        [Column(TypeName = "char")]
        [MaxLength(11),MinLength(11)]
        public string Tel { get; set; }

        [Required]
       public DateTime kayitTarihi { get; set; }

      
        [Column(TypeName = "nvarchar")]
        [MaxLength(100)]
        public  string Mail { get; set; }

        [Column(TypeName = "char")]
        [MaxLength(32),MinLength(32)]
        public  string Sifre { get; set; }
        
        [Required]
        public  int Ceza { get; set; }
        
        [Required]
        [Column(TypeName ="char")]
        [MaxLength(1),MinLength(1)]
        public  char Yetki { get; set; }
        public virtual List<OduncKitap> OduncKitaplar { get; set; } 
      
    }
}
