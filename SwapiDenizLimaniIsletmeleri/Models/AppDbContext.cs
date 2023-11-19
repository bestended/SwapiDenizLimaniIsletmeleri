using Microsoft.EntityFrameworkCore;

namespace SwapiDenizLimaniIsletmeleri.Models
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> option):base(option)
        {
            
            


        }


        public DbSet<Biletler>? Biletlers { get; set; }
        public DbSet<Calisanlar>? Calisanlars { get; set; }
        public DbSet<Limanlar>? Limanlars { get; set; }
        public DbSet<Sirketler>? Sirketler { get; set; }
        public DbSet<Ulkeler>? Ulkelers { get; set; }
        public DbSet<Vapurlar>? Vapurlar { get; set; }
        public DbSet<Yolcular>? Yolculars { get; set; }




    }
}
