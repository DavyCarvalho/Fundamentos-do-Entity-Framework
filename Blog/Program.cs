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
                // var user = new User
                // {
                //     Name = "André Baltieri",
                //     Slug = "andrebaltieri",
                //     Email = "andre@balta.io",
                //     Bio = "9x Microsoft MVP",
                //     Image = "https://balta.io",
                //     PasswordHash = "123098457"
                // };

                // var category = new Category
                // {
                //     Name = "Backend",
                //     Slug = "backend"
                // };

                // var post = new Post
                // {
                //     Author = user,
                //     Category = category,
                //     Body = "<p>Hello world</p>",
                //     Slug = "comecando-com-ef-core",
                //     Summary = "Neste artigo vamos aprender EF core",
                //     Title = "Começando com EF Core",
                //     CreateDate = DateTime.Now,
                //     LastUpdateDate = DateTime.Now,
                // };

                // context.Posts.Add(post); // Não adicionei autor nem categoria, o proprio EF vai fazer isso
                // context.SaveChanges();

                var posts = context
                    .Posts
                    .AsNoTracking()
                    .Include(x => x.Author) // EF vai fazer o INNER JOIN e trazer o subconjunto 'Author' preenchido
                    .Include(x => x.Category) // Mesmo caso de cima
                    .OrderBy(x => x.LastUpdateDate)
                    .ToList();

                foreach (var post in posts)
                    Console.WriteLine($"{post.Title} por {post.Author.Name} em {post.Category.Name}");
            }
        }
    }
}

