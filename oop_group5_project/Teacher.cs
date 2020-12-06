using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace oop_group5_project
{
    class Teacher : User
    {                                                           //23024 Thomas BAUDU 
                                                                //23189 Audrey CHANTY
                                                                //23182 Jean-Baptiste CORRE
                                                                //23165 Victor FAUCHARD
                                                                //23213 Tristan GERON
                                                                //23164 Alexandre MAROTTE
        public string Name { get; set; }
        public List<Classroom> Listclassroom { get; set; }
        public Matter Matter { get; set; }

        public Teacher(string name, List<Classroom> liste, Matter matter, string id, string password, string usertype)
        : base(id, password, usertype)
        {
            Name = name;
            Listclassroom = liste;
            Matter = matter;
            Usertype = "Teacher";
        }

        public void AddaGradeforaClassroom() // id student a la place de student 
        {
            centerText("What is the name of the grade ? : ");
            string gradename = Console.ReadLine();
            bool a = false;
            centerText("For which classroom do you want to add a grade ? : ");
            string nameclassroom = Console.ReadLine();

            foreach (Classroom element in Listclassroom)
            {
                if (nameclassroom == element.Name)
                {
                    a = true;
                    foreach (Student element2 in element.Classroomlist)
                    {
                        Console.WriteLine("What grade do you want to apply for " + element2.Name);
                        double mark = Convert.ToInt32(Console.ReadLine());

                        Grade grade = new Grade (gradename, Matter, mark);
                        element2.Listgrade.Add(grade);
                        
                    }
                    break;
                }
                else
                {
                    Console.Write("");
                }
            }
            if (a == false)
            {
                centerText("There's a problem in your choice, please retry");
                centerText("Press any touch to exit");
                Console.ReadKey();
                Console.Clear();
                TeacherMenu();
            }
            else
            {
                centerText("Press any touch to exit");
                Console.ReadKey();
                Console.Clear();
                TeacherMenu();
            }
        }


        public void Attendance(Classroom classroom, Class cours)
        {
            foreach (Student student in classroom.Classroomlist)
            {
                centerText("Is this student " + student.Name + " here ?" +
                    "\n                                  Type Yes or No : ");

                string answer = Console.ReadLine();

                if (answer == "Yes") Console.Write("");

                else if (answer == "No") student.Nonattendance.Add(cours);

                else centerText("Error");
            }
        }


        public void SeeClassResults(Classroom c)
        {
            foreach(Student s in c.Classroomlist)
            {
                if(s.Listgrade.Count == 0)
                {
                    centerText($"{s.Name} hasn't got any grade in his list");
                }
                else
                {
                    foreach (Grade g in s.Listgrade)
                    {
                        Console.WriteLine($"----{s.Name}----");
                        Console.WriteLine(g);
                    }
                }
                
            }
        }

        public void SeeClassAttendance(Classroom c)
        {
            foreach (Student s in c.Classroomlist)
            {
                
                centerText($"{s.Name} : {s.Nonattendance.Count} classes missed ");
                Console.WriteLine();
                foreach (Class classes in s.Nonattendance)
                {
                    Console.WriteLine(classes);
                }
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
        }
            public void TeacherMenu()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
            Console.Write("                                          ");
            Console.WriteLine($"Welcome {Name}, choose an option :" +
                $"\n                                          1) Attendance " +
                $"\n                                          2) Add a Graduation for exams " +
                $"\n                                          3) See a classroom's results " +
                $"\n                                          4) See a student attendance " +
                $"\n                                          5) See a student profile " +
                $"\n                                          6) See the timetables" +
                $"\n                                          7) Log out");
            int menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {

                case 1:
                    Console.Clear();
                    Console.WriteLine("\n\n\n");
                    centerText("Choose the classroom you want to attempted : ");
                    string desiredclassroom = Console.ReadLine();
                    Console.WriteLine();
                    centerText("Please type the day of the class : ");
                    string desiredday = Console.ReadLine();
                    Console.WriteLine();
                    centerText("Please type the hour of the class : ");
                    int desiredhour = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    bool a = false;
                    foreach (Classroom element in Listclassroom)
                    {
                        if (desiredclassroom == element.Name)
                        {
                            foreach (Class element2 in element.Timetable.Listclass)
                            {
                                if (element2.Date.day == desiredday && element2.Date.hour == desiredhour) 
                                {
                                    Attendance(element, element2);
                                    a = true;
                                    break;
                                }
                                else
                                {
                                    Console.Write("");
                                }
                            }                            
                        }
                        else
                        {
                            Console.Write("");
                        }
                    }
                    if (a == false)
                    {
                        Console.WriteLine("\n\n\n\n\n");
                        centerText("There's a problem in your choice, please retry");
                        centerText("Press any touch to exit");
                        Console.ReadKey();
                        Console.Clear();
                        TeacherMenu();
                    }
                    else
                    {
                        centerText("Press any touch to exit");
                        Console.ReadKey();
                        Console.Clear();
                        TeacherMenu();
                    }
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n\n");
                    AddaGradeforaClassroom();
                    break;


                case 3:

                    Console.Clear();
                    bool booool = false;
                    centerText($"Enter a Class Name : ");
                    string wantedClass = Console.ReadLine();
                    Console.Clear();
                    foreach (Classroom c in Listclassroom)
                    {
                        if (wantedClass == c.Name)
                        {
                            booool = true;
                            SeeClassResults(c);
                            break;
                        }
                        else
                        {
                            Console.Write("");
                        }
                    }
                    if(booool == false)
                    {
                        Console.Write("");
                        centerText("The class was not found");
                        centerText("Press any touch to exit");
                        Console.ReadKey();
                        Console.Clear();
                        TeacherMenu();
                    }
                    else
                    {
                        centerText("Press any touch to exit");
                        Console.ReadKey();
                        Console.Clear();
                        TeacherMenu();
                    }

                    break;
                
                case 4:
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n\n\n\n");
                    centerText($"Enter a Class Name : ");
                    string wantedClass2 = Console.ReadLine();
                    Console.Clear();
                    bool b = false;
                    foreach (Classroom c in Listclassroom)
                    {
                        if (c.Name == wantedClass2)
                        {
                            b = true;
                            Console.WriteLine("\n\n\n\n\n\n\n");
                            SeeClassAttendance(c);
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
                        TeacherMenu();
                    }
                    else
                    {
                        Console.WriteLine(); 
                        centerText("Press any touch to exit");
                        Console.ReadKey();
                        Console.Clear();
                        TeacherMenu();
                    }
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n\n\n\n");
                    centerText($"Enter a Student Name : ");
                    bool bol = false;
                    string wantedName2 = Console.ReadLine();
                    foreach (Classroom c in Listclassroom)
                    {
                        foreach (Student s in c.Classroomlist)
                        {
                            if (wantedName2 == s.Name)
                            {
                                bol = true;
                                SeeStudentProfile(s);
                                break;
                            }
                            else
                            {
                                Console.Write("");

                            }
                        }
                    }
                    if (bol == false)
                    {
                        centerText("The student was not found");
                        centerText("Press any touch to exit");
                        Console.ReadKey();
                        Console.Clear();
                        TeacherMenu();
                    }
                    else
                    {
                        centerText("Press any touch to exit");
                        Console.ReadKey();
                        Console.Clear();
                        TeacherMenu();
                    }

                    break;
                case 6:
                    Console.Clear();
                    bool abc = false;
                    Console.WriteLine("\n\n\n\n\n");
                    centerText($"Enter a Class Name : ");
                    string wantedClass3 = Console.ReadLine();
                    foreach (Classroom c in Listclassroom)
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
                        centerText("Press any touch to exit");
                        Console.ReadKey();
                        Console.Clear();
                        TeacherMenu();
                    }
                    else
                    {
                        centerText("Press any touch to exit");
                        Console.ReadKey();
                        Console.Clear();
                        TeacherMenu();
                    }
                    break;
                
            }
            
        }
        public override string ToString()
        {
            return $"{Name} -- {Matter} {Id} {Password}";
        }

        static void centerText(String text)
        {
            Console.Write(new string(' ', (Console.WindowWidth - text.Length) / 2));
            Console.Write(text);
        }

    }
}