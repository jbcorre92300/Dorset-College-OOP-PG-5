using System;
using System.Collections.Generic;
using System.Text;

namespace oop_group5_project
{
    class Date // On pourrait aussi utiliser des Datetime juste, qu'on mettrait dans TimeTable direct
    {
        int year;
        int month;
        int day;
        int hour;
        int minute;

        public Date(int year,int month, int day, int hour, int minute)
        {
            this.year = year;
            this.month = month;
            this.day = day;
            this.hour = hour;
            this.minute = minute;
        }

    }
}
