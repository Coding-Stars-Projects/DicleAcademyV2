using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EF_Core
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<AboutUs> aboutUs { get; set; } // sorgu için giriş nokt.
        public DbSet<BestCourses> bestCourses { get; set; }
        public DbSet<Contact> contact { get; set; }
        public DbSet<CourseDetails> CoursesDetails { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<CoursesCategories> CoursesCategories { get; set; }
        public DbSet<FAQ> Faq { get; set; }
        public DbSet<Gallery> Gallery { get; set; }
        public DbSet<GetInTouch> GetInTouch { get; set; }
        public DbSet<Instructors> Instructors { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<WelcomeInformations> WelcomeInformations { get; set; }
        public DbSet<StudentsSay> StudentsSay { get; set; }
        public DbSet<Header> Header { get; set; }
    }
}
