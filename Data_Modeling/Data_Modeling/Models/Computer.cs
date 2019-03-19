using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data_Modeling.Models
{
    public class Computer
    {
        private string computerName;
        private Classroom inClass;
        private string macAddress;
        private string make;
        private DateTime purchaseDate;
        private DateTime warantyDate;

        public string ComputerName { get => computerName; set => computerName = value; }
        public Classroom InClass { get => inClass; set => inClass = value; }
        public string MacAddress { get => macAddress; set => macAddress = value; }
        public string Make { get => make; set => make = value; }
        public DateTime PurchaseDate { get => purchaseDate; set => purchaseDate = value; }
        public DateTime WarantyDate { get => warantyDate; set => warantyDate = value; }
    }
}