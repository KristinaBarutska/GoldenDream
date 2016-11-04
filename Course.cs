using System;
using System.Collections.Generic;

namespace SkiSchool.Models
{
    public class Course
    {
        private ICollection<Customer> customers;
        public Course()
        {
            this.customers = new HashSet<Customer>();
        }
        public int Id { get; set; }
        public CourseType Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DateOfPayment { get; set; }
        public int DurationInDays { get; set; }
        public virtual ICollection<Customer> Customers
        {
            get { return this.customers; }

            set { this.customers = value; }
        }
    }
}
