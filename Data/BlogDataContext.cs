using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    public class BlogDataContext : DbContext // para virar data context
    {
        public DbSet<Category>? Categories { get; set; } // com isso adicionado sera muito mais facil o crud
    }
}