using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data_Modeling.Models
{
    public class YearGroup
    {
        private string yearName;
        private ClassGroup[] yearGroup;
        private Teacher headOfYear;

        public string YearName { get => yearName; set => yearName = value; }
        public ClassGroup[] YearGroup { get => yearGroup; set => yearGroup = value; }
        public Teacher HeadOfYear { get => headOfYear; set => headOfYear = value; }
    }
}