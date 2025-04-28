

using Microsoft.EntityFrameworkCore;
using RO.DevTest.Domain.Entities;

namespace RO.DevTest.Persistence
{
    public class DefaultContext : DbContext
    {
        public DefaultContext() { }

        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Client>().ToTable("Clients");
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Sale>().ToTable("Sales");
        }
    }
}
