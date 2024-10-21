using Microsoft.EntityFrameworkCore;

namespace POS_SDSIS
{
    public class TargetDbContext : DbContext
    {
        //public DbSet<Sale> Sale { get; set; }
        //public DbSet<SaleDetail> SaleDetail { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // SQL Server connection string for the target database
            optionsBuilder.UseSqlServer("Data Source=192.168.191.15;Initial Catalog=TestAMBERPOS;User ID=sa;Password=S123456_;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sale>()
                .HasMany(s => s.SaleDetails)
                .WithOne(sd => sd.Sale)
                .HasForeignKey(sd => sd.SaleId);
        }
    }

}
