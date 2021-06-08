using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebAPI.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }
        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<Account> Accounts { get; set; }

        public DbSet<Profile> Profiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Account>()
                    .HasOne<Profile>(acc => acc.Profile)
                    .WithOne(prop => prop.Account)
                    .HasForeignKey<Profile>(Profile => Profile.AccountId);

            modelBuilder.Entity<AccountCourse>()
                   .HasOne<Account>(ac => ac.Account)
                   .WithMany(account => account.AccountCourses)
                   .HasForeignKey(ac => ac.AccountId);

            modelBuilder.Entity<AccountCourse>()
                    .HasOne<Course>(ac => ac.Course)
                    .WithMany(course => course.AccountCourses)
                    .HasForeignKey(ac => ac.CourseId);
                    
            modelBuilder.Entity<AccountCourse>()
                    .HasKey(ac => ac.AccountId);            
            modelBuilder.Entity<AccountCourse>()
                    .HasKey(ac => ac.CourseId);
            modelBuilder.Entity<Account>()
                    .HasData(
                        new Account(1,"user01","123456"),
                        new Account(2, "user02", "123456"),
                        new Account(3, "user03", "123456"),
                        new Account(4, "user04", "123456"),
                        new Account(5, "user05", "123456")


                );
            modelBuilder.Entity<Course>()
                    .HasData(
                        new Course("KH01", "ASP.NET", 200000, "Quang Binh"),
                        new Course("KH02", "Java Spring", 300000, "Da Nang"),
                        new Course("KH03", "C++", 400000, "Da Nang"),
                        new Course("KH04", "HTML", 500000, "Quang Binh")

                );
            modelBuilder.Entity<AccountCourse>()
                    .HasData(
                        new AccountCourse(1,"KH02"),
                        new AccountCourse(3, "KH01"),
                        new AccountCourse(2, "KH04"),
                        new AccountCourse(3, "KH03")

                );
            modelBuilder.Entity<Profile>()
                    .HasData(
                        new Profile(1,1,"Bui van Hoa",22,"1233453421321"),
                        new Profile(2, 2, "Nguyen Van A", 12, "12343534521321"),
                        new Profile(3, 3, "Tran Van B", 42, "1321435"),
                        new Profile(4, 4, "Nguyen Thi C", 22, "12325345341321"),
                        new Profile(5, 5, "XXXX YYY ZZZZ", 42, "12334534521321")

                );
        }
    }
}
