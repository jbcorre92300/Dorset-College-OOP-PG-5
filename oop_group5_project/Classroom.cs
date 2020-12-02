using System;
using System.Collections.Generic;
using System.Text;

namespace oop_group5_project
{
    class Classroom
    {
        public string Name { get; set;}
        public List<Student> Classroomlist { get; set;}
        public TimeTable Timetable { get; set; }


        public Classroom (string name, List<Student> classroomlist)
        {
            Name = name;
            Classroomlist = classroomlist;
        }

        public override string ToString()
        {
           return $"Class : {Name}";
        }

    }
}
