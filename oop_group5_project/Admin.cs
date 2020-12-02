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
                Console.WriteLine($"----{s.Name}----");
                foreach(Grade g in s.Listgrade)
                {
                    Console.WriteLine($"{g} / ");
                }
            }
        }
        public void SeeClassAttendance(Classroom c)
        {
            foreach (Student s in c.Classroomlist)
            {
                Console.WriteLine($"{s.Name} : {s.Nonattendance.Count} classes missed "); 
                foreach(Class classes in s.Nonattendance)
                {
                    Console.WriteLine(classes);
                }
            }
            Console.WriteLine($"1)Remove an absence for a student\n2)Go back to menu");
            string r = Console.ReadLine();
            if(r=="1")
            {
                Console.Clear();
                Console.WriteLine($"Enter a Student ID");
                string wantedId = Console.ReadLine();
                foreach (Student s in /*full student list*/)
                {
                    if (wantedId == s.Id)
                    {
                        RemoveAbsence(s);
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
            }

        }
        public void RemoveAbsence(Student s)
        {
            Console.WriteLine($"What is the day of the absence you would like to remove ?");
            string day = Console.ReadLine();
            Console.WriteLine($"What is the time of the absence you would like to remove ?");
            int hour = Convert.ToInt32(Console.ReadLine());
            Date wanteddate = new Date(day, hour);
            foreach (Class c in s.Nonattendance)
            {
                if(wanteddate == c.Date)
                {
                    s.Nonattendance.Remove(c);
                    Console.WriteLine($"The absence for the class: {c} has been removed");

                }
                else
                {
                    Console.WriteLine("There was no absence found at this date and this time");
                }
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
                Console.WriteLine($"What is the matter of the exam ?\n1)Mathematics\n2)French\n3)Physics\n4)Biology\n5)Art\n6)Physical Education\n7)Economy\n8)Litterar English");
                int menu = Convert.ToInt32(Console.ReadLine());
                Matter matter = new Matter();
                switch (menu)
                {
                    case 1:
                        matter = Matter.mathematics;
                        break;
                    case 2:
                        matter = Matter.french;
                        break;
                    case 3:
                        matter = Matter.physics;
                        break;
                    case 4:
                        matter = Matter.biology;
                        break;
                    case 5:
                        matter = Matter.art;
                        break;
                    case 6:
                        matter = Matter.physicsactivity;
                        break;
                    case 7:
                        matter = Matter.economy;
                        break;
                    case 8:
                        matter = Matter.litterarenglish;
                        break;
                }
                Console.WriteLine($"On what day would you like to add an exam ?");
                string day = Console.ReadLine();
                Console.WriteLine($"On what time ?");
                int hour = Convert.ToInt32(Console.ReadLine());
                Date date = new Date(day, hour);
                Console.WriteLine($"In which room ?");
                string location = Console.ReadLine();
                Console.WriteLine($"Enter the Teacher ID");
                string wantedId = Console.ReadLine();
                foreach (Teacher t in /*full teacher list*/)
                {
                    if (wantedId == t.Id)
                    {
                        Class exam = new Class(date, matter, location, t);
                        foreach(Student student in c.Classroomlist)
                        {
                            student.Timetable.Listclass.Add(exam);
                        }
                        Console.WriteLine($"A new exam of {matter} has been added for next {date.day} at {date.hour}h with {t.Name}");//Méthode pour ajouter un EXAMEN
                        Console.WriteLine("Press any touch to exit");
                        Console.ReadKey();
                        Console.Clear();
                        AdminMenu();
                    }
                    else
                    {
                        Console.WriteLine("The teacher was not found");
                        Console.WriteLine("Press any touch to exit");
                        Console.ReadKey();
                        Console.Clear();
                        AdminMenu();
                    }
                }

                
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
