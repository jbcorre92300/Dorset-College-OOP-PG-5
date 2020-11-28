using System;
using System.Collections.Generic;
using System.Text;

namespace oop_group5_project
{
    class Class
    {
        public Date Date { get; set; }
        public Matter Matter { get; set; }
        public string Location { get; set; }
        public Teacher Teacher { get; set; }
        public Classroom Classroom { get; set; }

        public Class(Date date,Matter matter, string location, Teacher teacher, Classroom classroom)
        {
            Date = date;
            Matter = matter;
            Location = location;
            Teacher = teacher;
            Classroom = classroom;
        }
        public override string ToString()
        {
            return $"Matter : {Matter} -- {Teacher} ";
        }
    }
}
