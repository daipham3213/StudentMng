using System.Data.Entity;
using StudentMng.Models;

namespace StudentMng.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("StudentDbContext")
        {
            Database.SetInitializer(new AppDbInitializer());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<User> Users { get; set; }
    }
}