using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data_Modeling.Models
{
    public class Address
    {
        private string houseNumber;
        private string streetName;
        private string postcode;
        private string city;

        public string HouseNumber { get => houseNumber; set => houseNumber = value; }
        public string StreetName { get => streetName; set => streetName = value; }
        public string Postcode { get => postcode; set => postcode = value; }
        public string City { get => city; set => city = value; }
    }
}