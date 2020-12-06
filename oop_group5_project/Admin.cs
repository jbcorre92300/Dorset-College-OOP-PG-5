using System;
using System.Collections.Generic;
using System.Text;

namespace oop_group5_project
{
    class Admin : User
    {
                                                                    //23024 Thomas BAUDU 
                                                                   //23189 Audrey CHANTY
                                                                  //23182 Jean-Baptiste CORRE
                                                                 //23165 Victor FAUCHARD
                                                                //23213 Tristan GERON
                                                               //23164 Alexandre MAROTTE
        public string Name { get; set; }
        public List<Student> StudentFullList { get; set; }
        /*public string id;
        public int password;*/
        public List<Teacher> TeacherFullList { get; set; }
        public List<Classroom> ClassroomsFullList { get; set; }
        public Admin(string name, string id,string password,string usertype)
             : base(id,password,usertype) 
        {
            Name = name;
            Id = id;
            Password = password;
            Usertype = "Admin";                                     
        }
        
        public void TrackPaymentStudent(Student a)
        {
            centerText($"{a.Name} has {a.Cost} euros left to pay");
        }

        public void SeeClassResults(Classroom c)
        {
            foreach (Student s in c.Classroomlist)
            {
                Console.WriteLine($"----{s.Name}----");
                if (s.Listgrade.Count == 0)
                {
                    Console.WriteLine($"{s.Name} hasn't got any grade in his list");
                }
                else
                {
                    foreach (Grade g in s.Listgrade)
                    {
                        Console.WriteLine($"{g} / ");
                    }
                }

            }
        }

        public void SeeClassAttendance(Classroom c)
        {
            Console.WriteLine();
            foreach (Student s in c.Classroomlist)
            {
                Console.WriteLine($"                                          {s.Name} : {s.Nonattendance.Count} classes missed ");
                foreach (Class classes in s.Nonattendance)
                {
                    Console.WriteLine(classes);
                }
            }
            Console.WriteLine();
            Console.WriteLine($"                                          1)Remove an absence for a student" +
                $"\n                                          2)Go back to menu");
            string r = Console.ReadLine();
            if (r == "1")
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\n\n");
                centerText($"Enter a Student ID :");
                bool cd = false;
                string wantedId = Console.ReadLine();
                foreach (Student s in StudentFullList)
                {
                    if (wantedId == s.Id)
                    {
                        RemoveAbsence(s);
                        cd = true;
                        break;

                    }
                    else
                    {
                        Console.Write("");
                    }
                }
                if (cd == false)
                {
                    centerText("The student was not found");
                    centerText("Press any touch to exit");
                    Console.ReadKey();
                    Console.Clear();
                    AdminMenu();
                }
                else
                {
                    centerText("Press any touch to exit");
                    Console.ReadKey();
                    Console.Clear();
                    AdminMenu();
                }
            }
            else
            {
                Console.Clear();
                AdminMenu();
            }

        }
        public void RemoveAbsence(Student s)
        {
            Console.WriteLine("\n\n\n\n\n\n\n\n");
            centerText($"What is the day of the absence you would like to remove ? :");
            string day = Console.ReadLine();
            centerText($"What is the time of the absence you would like to remove ? :");
            int hour = Convert.ToInt32(Console.ReadLine());
            Date wanteddate = new Date(day, hour);
            bool absence = false;
            if(s.Nonattendance.Count == 0)
            {
                centerText("There is no absences to remove");
            }
            else
            {
                foreach (Class c in s.Nonattendance)
                {
                    
                    if ((hour == c.Date.hour) && (day == c.Date.day))
                    {
                        absence = true;
                        s.Nonattendance.Remove(c);
                        break;
                        
                    }
                    else
                    {
                        Console.Write("");
                    }
                }

                if(absence == false)
                {
                    centerText("There was no absence found at this date and this time");
                }
                else
                {
                    centerText($"The absence for the class has been removed");
                }

            }
            
        }

        public void SeeClassTimetable(Classroom c)
        {
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine($"Class {c.Name} : ");
            Console.Clear();
            Console.WriteLine("    Monday       Tuesday      Wednesday      Thursday      Friday");
            Console.WriteLine("-----------------------------------------------------------------");
            for (int hour = 6; hour < 20; hour++)
            {
                Console.Write(hour + "h ");
                c.Classroomlist[1].testclassaday(hour, "Monday");
                c.Classroomlist[1].testclassaday(hour, "Tuesday");
                c.Classroomlist[1].testclassaday(hour, "Wednesday");
                c.Classroomlist[1].testclassaday(hour, "Thursday");
                c.Classroomlist[1].testclassaday(hour, "Friday");
                Console.WriteLine();

            }
            
            Console.WriteLine("                                          1) Add an exam to this class" +
                "\n                                          2)Go back to menu");
            string z = Console.ReadLine();
            if (z == "1")
            {
                Console.WriteLine($"                                          What is the matter of the exam ?" +
                    $"\n                                          1)Mathematics" +
                    $"\n                                          2)French" +
                    $"\n                                          3)Physics" +
                    $"\n                                          4) Sport" +
                    $"\n                                          5)Litterature");
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
                        matter = Matter.sport;
                        break;
                    case 5:
                        matter = Matter.litterarenglish;
                        break;
                }
                centerText($"On what day would you like to add an exam ? :");
                string day = Console.ReadLine();
                centerText($"On what time ? : ");
                int hour = Convert.ToInt32(Console.ReadLine());
                Date date = new Date(day, hour);
                centerText($"In which room ? : ");
                string location = Console.ReadLine();
                centerText($"Enter the Teacher ID : ");
                string wantedId = Console.ReadLine();
                bool tea = false;
                foreach (Teacher t in TeacherFullList)
                {
                    if (wantedId == t.Id)
                    {
                        tea = true;
                        Class exam = new Class(date, matter, location, t);
                        foreach (Student student in c.Classroomlist)
                        {
                            student.Classeroom.Timetable.Listclass.Add(exam);
                        }
                        break;
                    }
                    else
                    {
                        Console.Write("");
                        
                    }
                }
                if(tea == false)
                {
                    centerText("The teacher was not found");
                    centerText("Press any touch to exit");
                    Console.ReadKey();
                    Console.Clear();
                    AdminMenu();
                }
                else
                {
                    centerText($"A new exam of {matter} has been added for next {date.day} at {date.hour}h ");//Méthode pour ajouter un EXAMEN
                    centerText("Press any touch to exit");
                    Console.ReadKey();
                    Console.Clear();
                    AdminMenu();
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
            Console.WriteLine("\n\n");
            string stringprofil = "";
            foreach (string a in s.Profil)
            {
                stringprofil += s;
                Console.Write(" / ");

            }
            Console.WriteLine($"                                          {s.Name}" +
                $"\n                                          {s.Classeroom}" +
                $"\n                                          {stringprofil}");
        }


        public void AdminMenu()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
            Console.Write("                                          ");
            Console.WriteLine($"Welcome {Name}, choose an option :" +
                "\n                                          1)Track Payment" +
                "\n                                          2)See exams/assignments results of a class" +
                "\n                                          3)See attendance of a class" +
                "\n                                          4)See Timetables" +
                "\n                                          5)See student profile" +
                "\n                                          6)Log out");

            int menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Console.Clear();
                    for (int i = 0; i <= 10; i++)
                    {
                        Console.WriteLine();
                    }
                    centerText($"Enter a Student ID : ");
                    bool a = false;
                    string wantedId = Console.ReadLine();
                    foreach (Student s in StudentFullList)
                    {
                        if (wantedId == s.Id)
                        {
                            Console.WriteLine();
                            TrackPaymentStudent(s);
                            Console.WriteLine();
                            a = true;
                            break;
                        }
                        else
                        {
                            Console.Write("");
                        }
                    }
                    if(a == false)
                    {
                        centerText("The student was not found");
                        centerText("Press any touch to exit");
                        Console.ReadKey();
                        Console.Clear();
                        AdminMenu();
                    }
                    else
                    {
                        Console.WriteLine();
                        centerText("Press any touch to exit");
                        Console.ReadKey();
                        Console.Clear();
                        AdminMenu();
                    }

                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n\n\n");
                    centerText($"Enter a Class Name : ");
                    bool b = false;
                    string wantedClass = Console.ReadLine();
                    foreach (Classroom c in ClassroomsFullList)
                    {
                        if (wantedClass == c.Name)
                        {
                            SeeClassResults(c);
                            b = true;
                            break;

                        }
                        else
                        {
                            Console.Write("");
                        }
                    }
                    if (b == false)
                    {
                        centerText("The class was not found");
                        centerText("Press any touch to exit");
                        Console.ReadKey();
                        Console.Clear();
                        AdminMenu();
                    }
                    else
                    {
                        centerText("Press any touch to exit");
                        Console.ReadKey();
                        Console.Clear();
                        AdminMenu();
                    }
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n\n");
                    centerText($"Enter a Class Name : ");
                    bool cd = false;
                    string wantedClass2 = Console.ReadLine();
                    foreach (Classroom c in ClassroomsFullList)
                    {
                        if (wantedClass2 == c.Name)
                        {
                            SeeClassAttendance(c);
                            cd = true;
                            break;
                        }
                        else
                        {
                            Console.Write("");
                        }
                    }
                    if (cd == false)
                    {
                        centerText("The class was not found");
                        centerText("Press any touch to exit");
                        Console.ReadKey();
                        Console.Clear();
                        AdminMenu();
                    }
                    else
                    {
                        centerText("Press any touch to exit");
                        Console.ReadKey();
                        Console.Clear();
                        AdminMenu();
                    }
                    break;
                case 4:
                    Console.Clear();
                    bool abc = false;
                    Console.WriteLine("\n\n\n\n\n");
                    centerText($"Enter a Class Name : "); 
                    string wantedClass3 = Console.ReadLine();
                    foreach (Classroom c in ClassroomsFullList)
                    {
                        if (wantedClass3 == c.Name)
                        {
                            SeeClassTimetable(c);
                            abc = true;
                            break;

                        }
                        else
                        {
                            Console.Write("");
                        }
                    }
                    if (abc == false)
                    {
                        centerText("The class was not found");
                        Console.WriteLine();
                        centerText("Press any touch to exit");
                        Console.ReadKey();
                        Console.Clear();
                        AdminMenu();
                    }
                    else
                    {
                        centerText("Press any touch to exit");
                        Console.ReadKey();
                        Console.Clear();
                        AdminMenu();
                    }

                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n\n");
                    centerText($"Enter a Student ID : ");
                    bool aze = false;
                    string wantedId2 = Console.ReadLine();
                    foreach (Student s in StudentFullList)
                    {
                        if (wantedId2 == s.Id)
                        {
                            SeeStudentProfile(s);
                            aze = true;
                            break;

                        }
                        else
                        {
                            Console.Write("");
                        }
                    }
                    if (aze == false)
                    {
                        centerText("The student was not found");
                        centerText("Press any touch to exit");
                        Console.ReadKey();
                        Console.Clear();
                        AdminMenu();
                    }
                    else
                    {
                        centerText("Press any touch to exit");
                        Console.ReadKey();
                        Console.Clear();
                        AdminMenu();
                    }
                    break;
               
            }

        }

        public override string ToString()
        {
            return $"{Name} --  {Id} {Password}";
        }

        static void centerText(String text)
        {
            Console.Write(new string(' ', (Console.WindowWidth - text.Length) / 2));
            Console.Write(text);
        }



    }
}
