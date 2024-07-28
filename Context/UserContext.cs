using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext{
    public AppDbContext(DbContextOptions options) : base(options) { }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder){
        modelBuilder.Entity<User>();
    }
}

public class User{
    public int Id { get; set;}
    public string Name { get; set;}
    public int Age { get; set;}
}
