using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();

            // context.Users.Add(new User
            // {
            //     Name = "Mário Neto",
            //     Bio = "O melhor programador .NET",
            //     Image = "linkedin/in/mariofneto",
            //     Email = "marioo.netoo3@gmail.com",
            //     PasswordHash = "123456789",
            //     Slug = "mariofneto"
            // });
            // context.SaveChanges();

            var user = context.Users.FirstOrDefault(x => x.Id == 2);
            var post = new Post
            {
                Author = user,
                Body = "Meu artigo",
                Category = new Category
                {
                    Name = "FrontEnd",
                    Slug = "frontend"
                }, 
                CreateDate = DateTime.Now,
                // LastUpdateDate=
                Slug = "meu-artigo",
                Summary = "Neste artigo vamos conferir...",
                // Tags=null,
                Title = "Meu artigo",
            };
            context.Posts.Add(post);
            context.SaveChanges();
        }
    }
}