using APIWypozyczalniaRowerowaProjektAIooK.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WypozyczalniaRowerowaProjektAIookAPI.Models;

namespace WypozyczalniaRowerowaProjektAIookAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Bike> Bikes { get; set; }
        public DbSet<Borrow> Borrows { get; set; }
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Bike>()
                .HasMany(e => e.Borrows)
                .WithOne(e => e.Bike)
                .HasForeignKey(e => e.IdBike)
                .IsRequired();
            }
        }
}
