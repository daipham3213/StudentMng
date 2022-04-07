using System;
using System.ComponentModel.DataAnnotations;

namespace StudentMng.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string StudentId { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string Hometown { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Department { get; set; }
        public string Majors { get; set; }
        public string Class { get; set; }
        public int GraduationYear { get; set; } 
        public string Rank { get; set; }
        public string CurrentJob { get; set; }
    }
}
