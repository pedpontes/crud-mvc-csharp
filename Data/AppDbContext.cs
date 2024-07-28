using Microsoft.EntityFrameworkCore;
using rinha_backend_cs.Models;

namespace rinha_backend_cs.Data{
    public class AppDbContext : DbContext{

        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<User>();
        }
    }
}
