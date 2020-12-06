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
    class Student : User
        
    {
        
        public string Name { get; set; }
        public Classroom Classeroom { get; set; }
        public List<string> Profil { get; set; }
        public List<Grade> Listgrade { get; set; }
        public int Cost { get; set; }
        public List<Class> Nonattendance { get; set; }
        
        

        public Student(string name, Classroom classroom, List<string> profil, List<Grade> listgrade, int cost,string id,string password,string usertype)
        : base(id, password, usertype)
        {
            Name = name;
            Classeroom = classroom;
            Profil = profil;
            //Timetable = timetable;
            Listgrade = listgrade;
            Cost = 8900;
            Nonattendance = null;
            Usertype = "Student";
        }

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

        public void modifprofil()
        {
            Console.WriteLine("What di you want to modifie?");
            Console.WriteLine("1)Name\n2)Date of Birthday\n3)Mail");
            int value = Convert.ToInt32(Console.ReadLine());
            switch (value)
            {
                case 1:
                    Console.WriteLine("What is your real name");
                    Name = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("What is your Birthday (DD/MM/YYYY)");
                    Profil.Add(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("What is your email?");
                    Profil.Add(Console.ReadLine());
                    break;
            }
        }

        public void CashPayment()
        {
            if(Cost == 0)
            {
                Console.WriteLine("Your payment is done");
            }
            else if(Cost != 8900)
            {
                Console.WriteLine("You have already begun a several times payment");
            }
            else
            {
                Console.WriteLine("Please pay " + Cost + " euros" + "\n" + "Enter your number card : ");

                int numbercard = Convert.ToInt32(Console.ReadLine()); // faire un solde pour l'étudiant, si l'étudiant à le solde demandé, alors retourner true, sinon false.
                Cost = 0;
                Console.WriteLine("Successfull Payment !");
            }
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            StudentMenu();

        }

        public void SeveralTimesPayment()
        {
            int remainingpayment = Cost;
            int alreadypaid = 0;
            if(remainingpayment == 0)
            {
                Console.WriteLine("Your payment is done");
            }
            else
            {
                Console.WriteLine("You have " + remainingpayment + " euros left to pay\nHow much do you want to pay right now ? : ");

                int payment = Convert.ToInt32(Console.ReadLine());

                remainingpayment -= payment;

                alreadypaid += payment;

                if (remainingpayment == 0 && alreadypaid == Cost)
                {
                    Console.WriteLine("Your payment is complete !");
                    Cost = remainingpayment;
                }
                else
                {
                    Console.WriteLine("There is " + remainingpayment + " euros left to pay");
                    Cost = remainingpayment;

                }
            }
            
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
            Console.WriteLine($"{Name}\n{Classeroom}\n{stringprofil}");
            Console.WriteLine("1) Modify Profile\nor press any touch to exit");
            string z = Console.ReadLine();
            if (z == "1")
            {
                Console.Clear();
                modifprofil();
                Console.WriteLine("Press any touch to exit");
                Console.ReadKey();
                StudentMenu();

            }
            else
            {
                Console.Clear();
                StudentMenu();
            }

        }

        public void SeeExamsandAssignementResults()
        {
            if(Listgrade.Count == 0)
            {
                Console.WriteLine("You haven't got any grades for the moment");
            }
            else
            {
                foreach (Grade grade in Listgrade)
                {
                    Console.WriteLine(grade);
                }
            }
            

            Console.WriteLine("Press any touch to exit");
            Console.ReadKey();
            StudentMenu();
        }

        public void SeeAttendence()
        {
            Console.Clear();
            Console.WriteLine("    Monday       Tuesday      Wednesday      Thursday      Friday");
            Console.WriteLine("-----------------------------------------------------------------");
            for (int hour = 6; hour< 20; hour++)
            {
                Console.Write(hour + "h ");
                testclassaday(hour, "Monday");
                testclassaday(hour, "Tuesday");
                testclassaday(hour, "Wednesday");
                testclassaday(hour, "Thursday");
                testclassaday(hour, "Friday");
                Console.WriteLine();
                
            }
            Console.WriteLine("Press any touch to exit");
            Console.ReadKey();
            Console.Clear();
            StudentMenu();
        }
        public void testclassaday(int hour, string day)
        {
            string mess = "";
            foreach (Class cours in Classeroom.Timetable.Listclass)
            {
                if (cours.Date.hour == hour&&cours.Date.day==day )
                {
                    mess = Convert.ToString(cours.Matter);
                    
                    
                }
                else
                {
                    Console.Write("");
                }
            }
            int end = day.Length + 6 - mess.Length+1;
            for (int i = 0; i < end; i++)
            {
                mess += " ";
            }
            Console.Write(mess);

        }

        public void SeeNoAttendence()
        {
            if(Nonattendance.Count == 0)
            {
                Console.WriteLine("You have 0 absences this semester");
                Console.WriteLine("Press any touch to exit");
                Console.ReadKey();
                StudentMenu();
            }
            else
            {
                foreach (Class cou in Nonattendance)
                {
                    Console.WriteLine(cou.ToString());
                    
                }
                Console.WriteLine($"You have {Nonattendance.Count} absences this semester");
                Console.WriteLine("Press any touch to exit");
                Console.ReadKey();
                StudentMenu();
            }
            
        }

        public void StudentMenu()
        {
            Console.Clear();
            Console.WriteLine($"Welcome {Name}, choose an option :\n1)See profile\n2)See Timetable\n3)Payment\n4)See exam/assignement results\n5)See the classes you missed\n6)Deconnexion");
            int menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Console.Clear();
                    SeeProfile();
                    break;
                case 2:
                    Console.Clear();
                    SeeAttendence();
                    break;
                case 3:
                    Console.Clear();
                    BeginningPayment();
                    break;
                case 4:
                    Console.Clear();
                    SeeExamsandAssignementResults();
                    break;
                case 5:
                    Console.Clear();
                    SeeNoAttendence();
                    break;
                case 6:
                    Console.Clear();
                    break;
            }
        }

        public override string ToString()
        {
            return $"{Name} -- {Classeroom.Name} {Id} {Password}";
        }
    }  
    
}
