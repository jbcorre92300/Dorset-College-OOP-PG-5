using System;
using System.Collections.Generic;
using System.Text;

namespace oop_group5_project
{
    class Grade
    {
        public string Name;
        public Matter Matter;
        public double Mark;

        public Grade(string name, Matter matter, double mark)
        {
            Name = name;
            Matter = matter;
            Mark = mark;
        }

        public override string ToString()
        {
            return $"{Matter}    {Name} :{Mark}";
        }
    }
}
