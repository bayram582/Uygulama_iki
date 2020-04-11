using System.Collections.Generic;

namespace KutuphaneProgrami.Data.Model
{
    public class Kategori:BaseEntity
    {
        public string Ad { get; set; }
        
        public List<Kitap> Kitaplar { get; set; }

    }
}
