using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data_Modeling.Models
{
    public class Classroom
    {
        private string classroomName;
        private int classroomCapacity;
        private Teacher mainTeacher;

        public string ClassroomName { get => classroomName; set => classroomName = value; }
        public int ClassroomCapacity { get => classroomCapacity; set => classroomCapacity = value; }
        public Teacher MainTeacher { get => mainTeacher; set => mainTeacher = value; }
    }
}