using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data_Modeling.Models
{
    public class Parent
    {
        private string firstName;
        private string lastName;
        private Student[] parentOf;
        private Address parentAddress;
        private Phone parentNumber;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public Student[] ParentOf { get => parentOf; set => parentOf = value; }
        public Address ParentAddress { get => parentAddress; set => parentAddress = value; }
        public Phone ParentNumber { get => parentNumber; set => parentNumber = value; }
    }
}