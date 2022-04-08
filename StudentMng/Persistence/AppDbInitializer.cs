using System;
using System.Data.Entity;
using System.Security.Cryptography;
using System.Text;
using StudentMng.Models;

namespace StudentMng.Persistence
{
    public class AppDbInitializer: CreateDatabaseIfNotExists<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            base.Seed(context);
            User admin = new User
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