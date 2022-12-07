using Blog.Data.Mappings;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    public class BlogDataContext : DbContext 
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        // Criação do banco
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=192.168.10.18;Database=BlogCriado ;User ID=sa;Password=Naosouotaku_69;Trusted_Connection=False; TrustServerCertificate=True;");


        // Criação de modelos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new PostMap());
        }    
    }
}