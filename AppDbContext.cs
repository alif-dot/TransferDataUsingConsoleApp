using Microsoft.EntityFrameworkCore;

namespace POS_SDSIS
{
    public class AppDbContext : DbContext
    {
        private readonly string _connectionString;

        public AppDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DbSet<Sale> Sale { get; set; }
        public DbSet<SaleDetail> SaleDetail { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<PurchaseDetail> PurchaseDetail { get; set; }
        public DbSet<KOTOrderMaster> KOTOrderMaster { get; set; }
        public DbSet<KOTOrderDetail> KOTOrderDetail { get; set; }
        public DbSet<GoodsReceive> GoodsReceive { get; set; }
        public DbSet<GoodsReceiveDetail> GoodsReceiveDetail { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure model relationships and table mapping if needed
            modelBuilder.Entity<Sale>()
                .HasMany(s => s.SaleDetails)
                .WithOne(sd => sd.Sale)
                .HasForeignKey(sd => sd.SaleId);

            // Configure relationships for Purchase and PurchaseDetail
            modelBuilder.Entity<Purchase>()
                .HasMany(p => p.PurchaseDetails)
                .WithOne(pd => pd.Purchase)
                .HasForeignKey(pd => pd.PurchaseId);

            // KOTOrderMaster relationship
            modelBuilder.Entity<KOTOrderMaster>()
                .HasMany(kot => kot.KOTOrderDetails)
                .WithOne()
                .HasForeignKey(kotDetail => kotDetail.KOTOrderMasterId);

            // Configure relationships for GoodsReceive and GoodsReceiveDetail
            modelBuilder.Entity<GoodsReceive>()
                .HasMany(gr => gr.GoodsReceiveDetail)
                .WithOne(grd => grd.GoodsReceive)
                .HasForeignKey(grd => grd.GoodsReceiveId);
        }
    }
}
