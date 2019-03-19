using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data_Modeling.Models
{
    public class Course
    {
        private string english;
        private string maths;
        private string science;
        private string music;
        private string technology;

        public string English { get => english; set => english = value; }
        public string Maths { get => maths; set => maths = value; }
        public string Science { get => science; set => science = value; }
        public string Music { get => music; set => music = value; }
        public string Technology { get => technology; set => technology = value; }
    }
}