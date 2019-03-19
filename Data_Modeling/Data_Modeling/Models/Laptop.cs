using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data_Modeling.Models
{
    public class Laptop
    {
        private string computerName;
        private Classroom inClass;
        private string macAddress;
        private string make;
        private DateTime purchaseDate;
        private DateTime warantyDate;
        private LaptopRenter renterName;
    }
}