using System;
using System.Collections.Generic;
using System.Text;

namespace oop_group5_project
{
    class Program
    {//23024 Thomas BAUDU 
     //23189 Audrey CHANTY
     //23182 Jean-Baptiste CORRE
     //23165 Victor FAUCHARD
     //23213 Tristan GERON
     //23164 Alexandre MAROTTE

        static void Buildfortest()
        {
            int classroom = 17;
            List<string> profil = new List<string> { "01/01/2000", "Paul", "Dupont" };
            TimeTable timetable = new TimeTable(new List<Class> { });
            Payment payment = new Payment(7900, 5000);
            List<Grade> listgrade = new List<Grade> { };
            Student test = new Student(classroom, profil, timetable, payment, listgrade);
        }


        static void Main(string[] args)
        { 
            Console.WriteLine("Test");

            Console.WriteLine("Coucou c moi lol"); //TEST
        }
    }
}
