using SkiSchool.Data;
using SkiSchool.Models;
using System;

namespace GoldenDreamTeam
{
    class Startup
    {
        static void Main(string[] args)
        {
            var db = new SkiSchoolContext();

            var course = new Course();
            course.Type = CourseType.Ski;
            course.StartDate = new DateTime();
            course.DateOfPayment = new DateTime();
            course.DurationInDays = 5;

            var customer1 = new Customer();
            customer1.Name = "Pesho Ivanov";
            customer1.Address = "Pirotska 27";
            customer1.Level = "B";

            var customer2 = new Customer();
            customer1.Name = "Ina Ivanova";
            customer1.Address = "Pirotska 27";
            customer1.Level = "C";

            //customer1.Siblings.Add(customer2);
            //customer2.Siblings.Add(customer1);
            course.Customers.Add(customer1);
            course.Customers.Add(customer2);

            db.Customers.Add(customer1);
            db.Customers.Add(customer2);
            db.Courses.Add(course);

            db.SaveChanges();
        }
    }
}
