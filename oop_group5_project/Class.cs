using System;
using System.Collections.Generic;
using System.Text;

namespace oop_group5_project
{
    class Class
    {
        public Date date;
        public Matter matter;
        public string location;
        public Teacher teacher;
        public Classroom classroom;

        public Class(Date date,Matter matter, string location, Teacher teacher, Classroom classroom)
        {
            this.date = date;
            this.matter = matter;
            this.location = location;
            this.teacher = teacher;
            this.classroom = classroom;
        }
    }
}
