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
            return $"Matter : {Matter} -- {Teacher} {Date.day} {Date.hour}h";
        }
    }
}
