using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data_Modeling.Models
{
    public class Exam
    {
        private string examName;
        private float passGrade;
        private Course courseExam;
        private int version;

        public string ExamName { get => examName; set => examName = value; }
        public float PassGrade { get => passGrade; set => passGrade = value; }
        public Course CourseExam { get => courseExam; set => courseExam = value; }
        public int Version { get => version; set => version = value; }
    }
}