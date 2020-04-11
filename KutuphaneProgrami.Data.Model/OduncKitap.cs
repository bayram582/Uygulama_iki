using System;
using System.ComponentModel.DataAnnotations;

namespace KutuphaneProgrami.Data.Model
{
   public class OduncKitap:BaseEntity
    {
        [Required]
        public int KitapId { get; set; }

        [Required]
        public int UyeId { get; set; }

        [Required]
        public DateTime AlisTarihi { get; set; }

        [Required]
        public DateTime GetirecegiTarih { get; set; }
        
        //? eklendi çünkü getirdiği tarih null olabilir olduğunu belirtmek için
        public DateTime? GetirdigiTarih { get; set; }
    }
}
