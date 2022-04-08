using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;

namespace StudentMng.Models
{
    public class User
    {
        [Key] 
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }

        public static string EncryptPassword(string password)
        {
            using (var sha = new SHA512CryptoServiceProvider())
            {
                byte[] hash = sha.ComputeHash(Encoding.Default.GetBytes(password));
                return Convert.ToBase64String(hash);
            }
        }
    }
}