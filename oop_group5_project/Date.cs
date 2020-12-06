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
    class Date // On pourrait aussi utiliser des Datetime juste, qu'on mettrait dans TimeTable direct
    {
        public string day;
        public int hour;

        public Date(string day, int hour)
        {
            this.day = day;
            this.hour = hour;
        }

    }
}
