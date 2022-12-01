using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    public class BlogDataContext : DbContext // para virar data context
    {
        public DbSet<Category> Categories { get; set; } // com isso adicionado sera muito mais facil o crud
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=192.168.10.18;Database=Blog;User ID=sa;Password=Naosouotaku_69;Trusted_Connection=False; TrustServerCertificate=True;");
            options.LogTo(Console.WriteLine);
        }
    }
}