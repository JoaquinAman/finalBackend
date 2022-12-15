using BakeryFinal.Model.Domain;
using Microsoft.EntityFrameworkCore;
using System.Threading;

namespace BakeryFinal.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<BakeryOffice> BakeryOffice { get; set; }
        public DbSet<Bread> Bread { get; set; }
        public DbSet<BreadOrder> BreadOrder { get; set; }
        public DbSet<Order> Order { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BakeryJoaquinDB");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BreadOrder>().HasOne(b => b.Bread)
                .WithMany(ba => ba.BreadOrder)
                .HasForeignKey(fo => fo.IdBread);

            modelBuilder.Entity<BreadOrder>().HasOne(b => b.Order)
                .WithMany(ba => ba.BreadOrder)
                .HasForeignKey(fo => fo.IdOrder);
        }
    }
}
