using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data_Modeling.Models
{
    public class Staff
    {
        private string firstName;
        private string lastName;
        private Address address;
        private Phone staffNumber;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public Address Address { get => address; set => address = value; }
        public Phone StaffNumber { get => staffNumber; set => staffNumber = value; }
    }
}