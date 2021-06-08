using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebAPI.Models
{
    public class Account
    {
        public Account(int id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;

        }

        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Profile Profile { get; set; }

        public IList<AccountCourse> AccountCourses { get; set; }


    }
}
