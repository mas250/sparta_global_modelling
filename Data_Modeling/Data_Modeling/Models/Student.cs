using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data_Modeling.Models
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int    age;
        private Address address;
        private Course[] courses;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public Address Address { get => address; set => address = value; }
        public Course[] Courses { get => courses; set => courses = value; }
    }
}