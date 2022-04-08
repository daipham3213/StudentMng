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
                FullName = "Administrator"
            };
            using (var sha = new SHA512CryptoServiceProvider())
            {
                byte[] password = sha.ComputeHash(Encoding.Default.GetBytes("admin"));;
                admin.Password = Convert.ToBase64String(password);
            }

            context.Users.Add(admin);
            context.SaveChanges();
        }
    }
}