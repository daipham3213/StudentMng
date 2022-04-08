using System.ComponentModel.DataAnnotations;

namespace StudentMng.Models
{
    public class User
    {
        [Key] 
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
    }
}