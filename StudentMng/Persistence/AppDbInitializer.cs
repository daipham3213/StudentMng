using System.Data.Entity;
using StudentMng.Models;

namespace StudentMng.Persistence
{
    public class AppDbInitializer : CreateDatabaseIfNotExists<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            base.Seed(context);
            var admin = new User
            {
                Username = "admin",
                FullName = "Administrator",
                Password = User.EncryptPassword("admin")
            };
            context.Users.Add(admin);
            context.SaveChanges();
        }
    }
}