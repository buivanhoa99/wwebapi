using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebAPI.Models
{
    public class Course
    {
        public Course(string maKhoaHoc, string tenKhoaHoc, int dongia, string diaChi)
        {
            MaKhoaHoc = maKhoaHoc;
            TenKhoaHoc = tenKhoaHoc;
            Dongia = dongia;
            DiaChi = diaChi;
        }
        [Key]
        public string MaKhoaHoc { get; set; }
        public string TenKhoaHoc { get; set; }
        public int Dongia { get; set; }
        public string DiaChi { get; set; }
        public IList<AccountCourse> AccountCourses { get; set; }

    }
}
