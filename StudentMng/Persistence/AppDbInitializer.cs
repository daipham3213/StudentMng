using System;
using System.Collections.Generic;
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
            User account = new User
            {
                Username = "account",
                FullName = "Account",
                Password = User.EncryptPassword("account")
            };
            List<Student> list = new List<Student>();
            list.Add(new Student()
            {
                Address = "Test",
                Birthdate = DateTime.Now,
                Class = "1A",
                CurrentJob = "Sinh viên",
                Department = "CNTT",
                GraduationYear = 2022,
                Hometown = "TP.HCM",
                Majors = "CNPM",
                Name = "Nguyễn Văn A",
                PhoneNumber = "0366123456",
                Rank = "Giỏi",
                StudentId = "201101"
            });

            list.Add(new Student()
            {
                Address = "Test",
                Birthdate = DateTime.Now,
                Class = "1B",
                CurrentJob = "Sinh viên",
                Department = "CNTT",
                GraduationYear = 2022,
                Hometown = "TP.HCM",
                Majors = "CNPM",
                Name = "Nguyễn Văn B",
                PhoneNumber = "0366456123",
                Rank = "Giỏi",
                StudentId = "201102"
            });

            list.Add(new Student()
            {
                Address = "Test",
                Birthdate = DateTime.Now,
                Class = "1A",
                CurrentJob = "Sinh viên",
                Department = "CNTT",
                GraduationYear = 2022,
                Hometown = "TP.HCM",
                Majors = "MMT",
                Name = "Nguyễn Văn C",
                PhoneNumber = "0366789456",
                Rank = "Giỏi",
                StudentId = "201103"
            });


            context.Users.Add(account);
            context.Students.AddRange(list);
            context.SaveChanges();
        }
    }
}