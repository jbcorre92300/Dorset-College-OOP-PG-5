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
