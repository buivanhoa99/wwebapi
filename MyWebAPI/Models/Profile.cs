using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebAPI.Models
{
    public class Profile
    {
        public Profile(int id, int accountId, string fullname, int age, string idNo)
        {
            Id = id;
            AccountId = accountId;
            Fullname = fullname;
            Age = age;
            IdNo = idNo;
        }

        public int Id { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public string Fullname { get; set; }
        public int Age { get; set; }
        public string IdNo { get; set; }


    }
}
