using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    public class BlogDataContext : DbContext // para virar data context
    {
        public DbSet<Category> Categories { get; set; } // com isso adicionado sera muito mais facil o crud
        public DbSet<Post> Posts { get; set; }
        // public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        // public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=192.168.10.18;Database=Blog;User ID=sa;Password=Naosouotaku_69;Trusted_Connection=False; TrustServerCertificate=True;");

    }
}