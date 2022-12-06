using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    public class BlogDataContext : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=192.168.10.18;Database=Blog;User ID=sa;Password=Naosouotaku_69;Trusted_Connection=False; TrustServerCertificate=True;");
                
    }
}