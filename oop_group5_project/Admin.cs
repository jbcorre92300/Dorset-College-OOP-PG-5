using System;
using System.Collections.Generic;
using System.Text;

namespace oop_group5_project
{
    class Admin
    {
        public string name;
        public int id;
        public string password;

        public Admin(string name, int id, string password)
        {
            this.name = name;
            this.id = id;
            this.password = password;                               //23024 Thomas BAUDU 
                                                                    //23189 Audrey CHANTY
                                                                    //23182 Jean-Baptiste CORRE
                                                                    //23165 Victor FAUCHARD
                                                                    //23213 Tristan GERON
                                                                    //23164 Alexandre MAROTTE



        }
        public Student createstudent()
        {
            string name = "Paul";
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
            // Payment payment = new Payment(7900);   - ne sert plus à rien avec l'interface
            List<Grade> listgrade = new List<Grade> { };
            int cost = 7900;
            
            Student student = new Student(name, id, profil, timetable, listgrade, cost);

            return student;


        }
    }
}
