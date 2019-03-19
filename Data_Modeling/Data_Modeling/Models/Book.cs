using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data_Modeling.Models
{
    public class Book
    {
        private string title;
        private string ISBN;
        private Course subject;
        private float cost;

        public string Title { get => title; set => title = value; }
        public string ISBN1 { get => ISBN; set => ISBN = value; }
        public Course Subject { get => subject; set => subject = value; }
        public float Cost { get => cost; set => cost = value; }
    }
}