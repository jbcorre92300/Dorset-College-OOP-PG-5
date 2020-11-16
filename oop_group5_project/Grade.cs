using System;
using System.Collections.Generic;
using System.Text;

namespace oop_group5_project
{
    class Grade
    {
        //23024 Thomas BAUDU 
        //23189 Audrey CHANTY
        //23182 Jean-Baptiste CORRE
        //23165 Victor FAUCHARD
        //23213 Tristan GERON
        //23164 Alexandre MAROTTE
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
