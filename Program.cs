using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BlogDataContext())
            {
                // var tag = new Tag { Name = ".NET", Slug = "dotnet"};

                // context.Tags.Add(tag); // para salvar em memoria
                // context.SaveChanges(); // para salvar a mudança no banco
                // Console.WriteLine("Salvo");

                // var tag = context.Tags.FirstOrDefault(x => x.Id == 3); // pegando do banco para atualizar
                // tag.Name = "Ponto NET";
                // tag.Slug = "dotnet";

                // context.Update(tag);
                // context.SaveChanges();
                // Console.WriteLine("Atualizado!");

                // var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
                // context.Remove(tag);
                // context.SaveChanges();
                // Console.WriteLine("Excluido");

                // var tags = context.Tags; // nao executou no banco | o .ToList forçaria ser executada as tags

                // foreach (var tag in tags) // aqui executou
                // {
                //     Console.WriteLine(tag.Name);
                // }

                // var tag = context.Tags.AsNoTracking().FirstOrDefault(x => x.Id == 3);
                // Console.WriteLine(tag?.Name);
            }

        }
    }
}