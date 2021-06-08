using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebAPI.Models
{
    public class AccountCourse
    {
        public AccountCourse(int accountId, string courseId)
        {
            AccountId = accountId;
            CourseId = courseId;
        }

        public int AccountId { get; set; }
        public Account Account { get; set; }

        public string CourseId { get; set; }
        public Course Course { get; set; }
    }

}
