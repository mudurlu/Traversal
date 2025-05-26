
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DAL.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(LocalDB)\\MSSQLLocalDb;database=TraversalDB;integrated security=true;TrustServerCertificate=true");
        }

        public DbSet<AltHakkimizda> TblAltHakkimizda { get; set; }
        public DbSet<Bulten> TblBulten { get; set; }
        public DbSet<Hakkimizda> TblHakkimizda { get; set; }
        public DbSet<Iletisim> TblIletisim { get; set; }
        public DbSet<Lokasyon> TblLokasyon { get; set; }
        public DbSet<OneCikan> TblOneCikan { get; set; }
        public DbSet<Referans> TblReferans { get; set; }
        public DbSet<Rehber> TblRehber { get; set; }
    }
}
