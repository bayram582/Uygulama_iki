using System;

namespace KutuphaneProgrami.Data.Model
{
   public class OduncKitap:BaseEntity
    {
        public int KitapId { get; set; }
        public int UyeId { get; set; }
        public DateTime AlisTarihi { get; set; }
        public DateTime GetirecegiTarih { get; set; }
        
        //? eklendi çünkü getirdiği tarih null olabilir olduğunu belirtmek için
        public DateTime? GetirdigiTarih { get; set; }
    }
}
