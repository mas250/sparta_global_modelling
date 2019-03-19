using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data_Modeling.Models
{
    public class Teacher
    {
        private string firstName;
        private string lastName;
        private Address address;
        private Course[] courses;
        private ClassGroup[] classGroup;
        private Phone teacherNumber;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public Address Address { get => address; set => address = value; }
        public Course[] Courses { get => courses; set => courses = value; }
        public ClassGroup[] ClassGroup { get => classGroup; set => classGroup = value; }
        public Phone TeacherNumber { get => teacherNumber; set => teacherNumber = value; }
    }
}