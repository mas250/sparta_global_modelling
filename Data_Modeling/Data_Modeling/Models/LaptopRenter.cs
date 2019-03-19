using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data_Modeling.Models
{
    public class LaptopRenter
    {
        private string firstName;
        private string lastName;
        private string currentLaptop;
        private bool hasLaptop;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string CurrentLaptop { get => currentLaptop; set => currentLaptop = value; }
        public bool HasLaptop { get => hasLaptop; set => hasLaptop = value; }
    }
}