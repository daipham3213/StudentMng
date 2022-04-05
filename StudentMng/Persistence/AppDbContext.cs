using System.Data.Entity;
using StudentMng.Models;

namespace StudentMng.Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public AppDbContext() : base("StudentDbContext")
        {
        }
    }
}