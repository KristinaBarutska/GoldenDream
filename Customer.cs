using System.Collections.Generic;

namespace SkiSchool.Models
{
    public class Customer
    {
        private ICollection<Customer> siblings;

        private ICollection<Course> courses;

        public Customer()
        {
            this.siblings = new HashSet<Customer>();
            this.courses = new HashSet<Course>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Level { get; set; }

        public virtual ICollection<Customer> Siblings
        {
            get { return this.siblings; }
            set { this.siblings = value; }
        }

        public virtual ICollection<Course> Courses
        {
            get { return this.courses; }
            set { this.courses = value; }
        }
    }
}
