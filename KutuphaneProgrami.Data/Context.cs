using KutuphaneProgrami.Data.Model;
using System.Data.Entity;

namespace KutuphaneProgrami.Data
{
    public class Context:DbContext
    {
        public Context():base("Context")
        {

        }

        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
    }
}
