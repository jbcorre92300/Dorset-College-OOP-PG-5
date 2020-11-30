using System;
using System.Collections.Generic;
using System.Text;

namespace oop_group5_project
{
    class Admin : User
    {
        public string Name { get; set; }
        /*public string id;
        public int password;*/

        public Admin(string name, string id,string password,string usertype)
             : base(id,password,usertype) 
        {
            Name = name;
            Id = id;
            Password = password;
            Usertype = "3";                                         //23024 Thomas BAUDU 
                                                                    //23189 Audrey CHANTY
                                                                    //23182 Jean-Baptiste CORRE
                                                                    //23165 Victor FAUCHARD
                                                                    //23213 Tristan GERON
                                                                    //23164 Alexandre MAROTTE

        }
        /*public Student createstudent()
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
            
            Student student = new Student(Name, id, profil, timetable, listgrade, cost);
            
            return student;


        }*/
        public void TrackPaymentStudent(Student a)
        {
            Console.WriteLine($"{a.Name} has {a.Cost} euros left to pay");
        }

        public void SeeClassResults(Classroom c)
        {
            foreach(Student s in c.Classroomlist)
            {
                Console.Write(s.Name);
                foreach(Grade g in s.Listgrade)
                {
                    Console.Write($"{g} / ");
                }
            }
        }
        public void SeeClassAttendance(Classroom c)
        {
            foreach (Student s in c.Classroomlist)
            {
                Console.WriteLine($"{s.Name} : {s.Nonattendance} classes missed ");
                
            }
        }

        public void SeeClassTimetable(Classroom c)
        {
            Console.WriteLine($"Class {c.Name} : ");
            Student s = c.Classroomlist[1];
            s.SeeAttendence();
            Console.WriteLine("1) Add an exam to this class\n 2)Go back to menu");
            string z = Console.ReadLine();
            if (z == "1")
            {
                //Méthode pour ajouter un EXAMEN
            }
            else
            {
                Console.Clear();
                AdminMenu();
            }
        }

        public void SeeStudentProfile(Student s)
        {
            string stringprofil = "";
            foreach (string a in s.Profil)
            {
                stringprofil += s;
                Console.Write(" / ");

            }
            Console.WriteLine($"{Name}\n{s.Classroom}\n{stringprofil}");
        }


        public void AdminMenu()
        {
            Console.Clear();
            Console.WriteLine($"Welcome {Name}, choose an option :\n1)Track Payment\n2)See exams/assignments results of a class\n3)See attendance of a class\n4)See Timetables\n5)See student profile");
            int menu = Convert.ToInt32(Console.ReadLine());


            switch (menu)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine($"Enter a Student ID");
                    string wantedId = Console.ReadLine();
                    foreach (Student s in /*full student list*/)
                    {
                        if (wantedId == s.Id)
                        {
                            TrackPaymentStudent(s);
                            Console.WriteLine("Press any touch to exit");
                            Console.ReadKey();
                            Console.Clear();
                            AdminMenu();
                        }
                        else
                        {
                            Console.WriteLine("The student was not found");
                            Console.WriteLine("Press any touch to exit");
                            Console.ReadKey();
                            Console.Clear();
                            AdminMenu();
                        }
                    }

                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine($"Enter a Class Name");
                    string wantedClass = Console.ReadLine();
                    foreach (Classroom c in /*full classroom list*/)
                    {
                        if (wantedClass == c.Name)
                        {
                            SeeClassResults(c);
                        }
                        else
                        {
                            Console.WriteLine("The class was not found");
                            Console.WriteLine("Press any touch to exit");
                            Console.ReadKey();
                            Console.Clear();
                            AdminMenu();
                        }
                    }
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine($"Enter a Class Name");
                    string wantedClass2 = Console.ReadLine();
                    foreach (Classroom c in /*full classroom list*/)
                    {
                        if (wantedClass2 == c.Name)
                        {
                            SeeClassAttendance(c);
                            Console.WriteLine("Press any touch to exit");
                            Console.ReadKey();
                            Console.Clear();
                            AdminMenu();
                        }
                        else
                        {
                            Console.WriteLine("The class was not found");
                            Console.WriteLine("Press any touch to exit");
                            Console.ReadKey();
                            Console.Clear();
                            AdminMenu();
                        }
                    }
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine($"Enter a Class Name");
                    string wantedClass3 = Console.ReadLine();
                    foreach (Classroom c in /*full classroom list*/)
                    {
                        if (wantedClass3 == c.Name)
                        {
                            SeeClassTimetable(c);
                            Console.WriteLine("Press any touch to exit");
                            Console.ReadKey();
                            Console.Clear();
                            AdminMenu();
                        }
                        else
                        {
                            Console.WriteLine("The class was not found");
                            Console.WriteLine("Press any touch to exit");
                            Console.ReadKey();
                            Console.Clear();
                            AdminMenu();
                        }
                    }

                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine($"Enter a Student ID");
                    string wantedId2 = Console.ReadLine();
                    foreach (Student s in /*full student list*/)
                    {
                        if (wantedId2 == s.Id)
                        {
                            SeeStudentProfile(s);
                            Console.WriteLine("Press any touch to exit");
                            Console.ReadKey();
                            Console.Clear();
                            AdminMenu();
                        }
                        else
                        {
                            Console.WriteLine("The student was not found");
                            Console.WriteLine("Press any touch to exit");
                            Console.ReadKey();
                            Console.Clear();
                            AdminMenu();

                        }
                    }
                    break;
            }

        }





    }
}
