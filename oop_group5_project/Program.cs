using System;
using System.Collections.Generic;
using System.Text;

namespace oop_group5_project
{
    class Program
    {
        static void Buildfortest()
        {
            int classroom = 17;
            List<string> profil = new List<string> { "01/01/2000", "Paul", "Dupont" };
            Date date1 = new Date(2020, 11, 09, 09, 00);
            Date date2 = new Date(2020, 11, 10, 11, 00);
            Class c1 = new Class(date1, "math", "L204");
            Class c2 = new Class(date2, "physics", "L503");
            List<Class> listclass = new List<Class> { c1, c2 };
            TimeTable timetable = new TimeTable(listclass);
            Payment payment = new Payment(7900, 5000);

        }


        static void Main(string[] args)                         //23024 Thomas BAUDU 
        {                                                       //23189 Audrey CHANTY
                                                                //23182 Jean-Baptiste CORRE
                                                                //23165 Victor FAUCHARD
                                                                //23213 Tristan GERON
                                                                //23164 Alexandre MAROTTE
            Console.WriteLine("Test");
        }
    }
}
