using Surf_blog.Models.DBModels;
using System.Data.Entity;

namespace Surf_blog.DAL
{
    public class SufrDBInitializer : DropCreateDatabaseAlways<SurfDBContext>
    {
        protected override void Seed(SurfDBContext context)
        {
            var user = new User
            {
                Nickname = "user",
                LastName = "Petrov",
                Name = "Ivan",
                Email = "ff@ya.ru",
                About = "Very much"
            };
            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}