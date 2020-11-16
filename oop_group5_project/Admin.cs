using System;
using System.Collections.Generic;
using System.Text;

namespace oop_group5_project
{

    class Admin
    {
        //23024 Thomas BAUDU 
        //23189 Audrey CHANTY
        //23182 Jean-Baptiste CORRE
        //23165 Victor FAUCHARD
        //23213 Tristan GERON
        //23164 Alexandre MAROTTE
        int id;
        string password;

        public Admin()
        {                                                          

        }
        public Student createstudent()
        {
            Console.WriteLine("What is the id for the student?");
            int id = Convert.ToInt32(Console.ReadLine());
            List<string> profil = new List<string> { };
            Console.WriteLine("What is the first name of the student?");
            profil.Add(Console.ReadLine());
            Console.WriteLine("What is the last name of the student?");
            profil.Add(Console.ReadLine());
            Console.WriteLine("What is the date of birth of the student?");
            profil.Add(Console.ReadLine());
            profil.Add(profil[0] + "." + profil[1] + "@virtualglobalcollege.com");
            Console.WriteLine("What is the student's address?");
            profil.Add(Console.ReadLine());
            Console.WriteLine("What is the phone number of the student?");
            profil.Add(Console.ReadLine());
            TimeTable timetable = new TimeTable(new List<Class> { });
            Payment payment = new Payment(7900, 5000);
            List<Grade> listgrade = new List<Grade> { };
            Student student = new Student(id, profil, timetable, payment, listgrade);
            return student;
        }


    }
}
