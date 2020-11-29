using System;
using System.Collections.Generic;
using System.Text;

namespace oop_group5_project
{
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
