using System;
using System.Collections.Generic;
using System.Text;

namespace oop_group5_project
{
                                                                    //23024 Thomas BAUDU 
                                                                   //23189 Audrey CHANTY
                                                                  //23182 Jean-Baptiste CORRE
                                                                 //23165 Victor FAUCHARD
                                                                //23213 Tristan GERON
                                                               //23164 Alexandre MAROTTE
    class Classroom
    {
        public string Name { get; set;}
        public List<Student> Classroomlist { get; set;}
        public TimeTable Timetable { get; set; }


        public Classroom (string name, List<Student> classroomlist,TimeTable timetable)
        {
            Name = name;
            Classroomlist = classroomlist;
            Timetable = timetable;
        }

        public override string ToString()
        {
           return $"Class : {Name}";
        }

    }
}
