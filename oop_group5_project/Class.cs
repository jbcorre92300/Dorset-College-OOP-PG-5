using System;
using System.Collections.Generic;
using System.Text;

namespace oop_group5_project
{
    class Class
    {
        //23024 Thomas BAUDU 
        //23189 Audrey CHANTY
        //23182 Jean-Baptiste CORRE
        //23165 Victor FAUCHARD
        //23213 Tristan GERON
        //23164 Alexandre MAROTTE
        Classroom classroom;
        string name;
        Date date;
        Matter matter;
        string location;
        Teacher teacher;

        public Class(string name, Date date,Matter matter, string location, Teacher teacher)
        {
            this.date = date;
            this.matter = matter;
            this.location = location;
            this.teacher = teacher;
            this.name = name;
        }
    }
}
