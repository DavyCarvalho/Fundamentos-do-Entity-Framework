using Blog.Data;
using Blog.Models;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();

            // // Incluindo um Usuário
            // context.Users.Add(new User
            // {
            //     Bio = "9x Microsoft MVP",
            //     Email = "balta@mail.com",
            //     Image = "http://balta.io",
            //     Name = "André",
            //     PasswordHash = "1234",
            //     Slug = "andre-balta"
            // });
            // context.SaveChanges();

            var user = context.Users.FirstOrDefault(); // recuperando o User que adicionamos acima no banco

            var post = new Post
            {
                Author = user,
                Body = "Meu Artigo",
                Category = new Category
                {
                    Name = "Backend",
                    Slug = "backend"
                },
                CreateDate = DateTime.Now,
                //LastUpdateDate = Comentado para testar a função Default do Banco
                Slug = "meu-artigo",
                Summary = "Neste artigo vamos...",
                // Tags = null
                Title = "Meu Artigo"
            };

            context.Posts.Add(post);
            context.SaveChanges();
        }
    }
}
