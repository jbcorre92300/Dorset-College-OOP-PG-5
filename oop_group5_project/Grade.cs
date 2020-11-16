using System;
using System.Collections.Generic;
using System.Text;

namespace oop_group5_project
{
    class Grade
    {
        string name;
        Matter matter;
        double grade;
        public Grade(Matter matter, double grade, string name)
        {
            this.name = name;
            this.matter = matter;
            this.grade = grade;
        }
    }
}
