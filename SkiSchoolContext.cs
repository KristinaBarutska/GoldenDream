using SkiSchool.Models;
using System.Data.Entity;


namespace SkiSchool.Data
{
    public class SkiSchoolContext : DbContext
    {
        public SkiSchoolContext()
            : base("SkiDb")
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Course> Courses { get; set; }
        
    }
}
