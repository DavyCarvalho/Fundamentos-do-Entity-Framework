using Blog.Data;
using Blog.Models;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BlogDataContext())
            {
                //Create
                var tag = new Tag { Name = ".NET", Slug = "dotnet" };
                context.Tags.Add(tag);
                context.SaveChanges();

                
            }
        }
    }
}

