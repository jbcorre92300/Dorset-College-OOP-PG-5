using System;
using System.Collections.Generic;
using System.Text;

namespace oop_group5_project
{
    class Classroom
    {
        public int name { get; set;}
        public List<Student> classroom { get; set;}


        public Classroom (int Name, List<Student> Classroom)
        {
            this.name = Name;
            this.classroom = Classroom;
        }



    }
}
