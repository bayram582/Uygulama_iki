using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KutuphaneProgrami.Data.Model
{
    public class Kitap:BaseEntity
    {
        [Required]
        [Column(TypeName = "Varchar")]
        [MaxLength(50)]
        public string Ad { get; set; }
       
        [Required]
        [Column(TypeName = "Varchar")]
        [MaxLength(20)]
        public string SiraNo { get; set; }

        [Required]
        public int Adet { get; set; }

        [Required]
        public DateTime EklenmeTarihi { get; set; }
        
        [Required]
        public int YazarId { get; set; }
        public virtual Yazar Yazar { get; set; }
        public virtual List<Kategori> Kategoriler { get; set; }

    }
}
