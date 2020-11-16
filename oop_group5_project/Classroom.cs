using System;
using System.Collections.Generic;
using System.Text;

namespace oop_group5_project
{
    class Classroom
    {
        //23024 Thomas BAUDU 
        //23189 Audrey CHANTY
        //23182 Jean-Baptiste CORRE
        //23165 Victor FAUCHARD
        //23213 Tristan GERON
        //23164 Alexandre MAROTTE
        public int name;
        public List<Student> studentlist;

        public Classroom (int name, List<Student> liststudent)
        {
            this.name = name;
            this.studentlist = liststudent;
        }

    }
}
