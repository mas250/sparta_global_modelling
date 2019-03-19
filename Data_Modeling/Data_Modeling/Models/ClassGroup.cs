using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data_Modeling.Models
{
    public class ClassGroup
    {
        private string className;
        private Student[] studentsInClass;
        private Teacher formTutor;

        public string ClassName { get => className; set => className = value; }
        public Student[] StudentsInClass { get => studentsInClass; set => studentsInClass = value; }
        public Teacher FormTutor { get => formTutor; set => formTutor = value; }
    }
}