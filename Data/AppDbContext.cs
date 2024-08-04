using Microsoft.EntityFrameworkCore;
using crud_api_view.Models;

namespace crud_api_view.Data{
    public class AppDbContext : DbContext{

        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<User>();
        }
    }
}
