using System;
using System.Collections.Generic;
using System.Text;

namespace oop_group5_project
{                                                               //23024 Thomas BAUDU 
                                                                //23189 Audrey CHANTY
                                                                //23182 Jean-Baptiste CORRE
                                                                //23165 Victor FAUCHARD
                                                                //23213 Tristan GERON
                                                                //23164 Alexandre MAROTTE
    class Student : User, InterfacePayment
        
    {
        public string Name { get; set; }
        public Classroom Classroom { get; set; }
        public List<string> Profil { get; set; }
        public TimeTable Timetable { get; set; }
        public List<Grade> Listgrade { get; set; }
        public int Cost { get; set; }
        public List<Class> Nonattendance { get; set; }
        
       


        public Student(string name, Classroom classroom, List<string> profil,TimeTable timetable, List<Grade> listgrade, int cost,string id,string password,string usertype)
        : base(id, password, usertype)
        {
            Name = name;
            Classroom = classroom;
            Profil = profil;
            Timetable = timetable;
            Listgrade = listgrade;
            Cost = cost;
            Nonattendance = null;
            Usertype = "1";
        }



        /*
        public void makeapaiment(double paiment)
        {
            if (paiment > payment.cost - payment.alreadypaid)
            {
                paiment = payment.cost - payment.alreadypaid;
            }
            payment.alreadypaid += paiment;
        }
        */

        public void BeginningPayment()
        {
            Console.WriteLine("How do you want to make your payment ?\n1) Cash Payment\n2) Several Times Payment\n3)Go back to menu");
            int menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Console.Clear();
                    CashPayment();
                    break;
                case 2:
                    Console.Clear();
                    SeveralTimesPayment();
                    break;
                case 3:
                    Console.Clear();
                    StudentMenu();
                    break;

            }
        }


        public void CashPayment()
        {
            Console.WriteLine("Please pay " + Cost + " euros" + "\n" + "Enter your number card : ");

            int numbercard = Convert.ToInt32(Console.ReadLine()); // faire un solde pour l'étudiant, si l'étudiant à le solde demandé, alors retourner true, sinon false.

            Console.WriteLine("Successfull Payment !");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            StudentMenu();

        }


        public void SeveralTimesPayment()
        {
            int remainingpayment = Cost;
            int alreadypaid = 0;

            Console.WriteLine("How much do you want to pay right now ? : ");

            int payment = Convert.ToInt32(Console.ReadLine());

            remainingpayment -= payment;

            alreadypaid += payment;

            if (remainingpayment == 0 && alreadypaid == Cost) Console.WriteLine("Your payment is complete !");

            else Console.WriteLine("There is " + remainingpayment + " euros left to pay");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            StudentMenu();
        }

        public void SeeProfile()
        {
            string stringprofil = "";
            foreach(string s in Profil)
            {
                stringprofil += s;
                Console.WriteLine("");

                
            }
            Console.WriteLine($"{Name}\n{Classroom}\n{stringprofil}");
            Console.WriteLine("1) Modify Profile\nor press any touch to exit");
            string z = Console.ReadLine();
            if (z == "1")
            {
                //Methode pour modifier le profil
            }
            else
            {
                Console.Clear();
                StudentMenu();
            }

        }

        public void SeeExamsandAssignementResults()
        {
            foreach (Grade grade in Listgrade)
            {
                Console.WriteLine(grade);
            }

            Console.WriteLine("Press any touch to exit");
            Console.ReadKey();
            StudentMenu();
        }

        public void SeeAttendance()
        {
            foreach(Class course in Nonattendance)
            {
                Console.WriteLine(course);
            }
        }


        public void StudentMenu()
        {
            Console.Clear();
            Console.WriteLine($"Welcome {Name}, choose an option :\n1)See profile\n2)Login for a class\n3)See Timetable\n4)Payment\n5)See exam/assignement results\n6)See attendance");
            int menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Console.Clear();
                    SeeProfile();
                    break;
                case 2:
                    Console.Clear();
                    //Methode pour se mettre présent à un cours actuel;
                    break;
                case 3:
                    //Méthode pour voir l'emploi du temps
                    break;
                case 4:
                    Console.Clear();
                    BeginningPayment();
                    break;
                case 5:
                    Console.Clear();
                    SeeExamsandAssignementResults();
                    break;
                case 6:
                    Console.Clear();
                    SeeAttendance();
                    break;
            }
        }
        
    }   
    
}
