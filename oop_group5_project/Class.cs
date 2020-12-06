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

        public Class(Date date,Matter matter, string location, Teacher teacher)
        {
            Date = date;
            Matter = matter;
            Location = location;
            Teacher = teacher;
        }
        public override string ToString()
        {
            return $"Matter : {Matter} -- {Teacher.Name} {Date.day} {Date.hour}h";
        }
    }
}
