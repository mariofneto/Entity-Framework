namespace Blog.Models
{
    public class User // tabela do sql
    {
        public int Id { get; set; } // coluna da tabela sql
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }
    }
}