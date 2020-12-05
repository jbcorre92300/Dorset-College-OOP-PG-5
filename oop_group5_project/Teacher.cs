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
            Console.WriteLine("What is the name of the grade ?");
            string gradename = Console.ReadLine();

            Console.WriteLine ("For which classroom do you want to add a grade ?");
            string nameclassroom = Console.ReadLine();

            foreach (Classroom element in Listclassroom)
            {
                if (nameclassroom == element.Name)
                {
                    foreach (Student element2 in element.Classroomlist)
                    {
                        Console.WriteLine("What grade do you want to apply for " + element2.Name);
                        double mark = Convert.ToInt32(Console.ReadLine());

                        Grade grade = new Grade (gradename, Matter, mark);
                        element2.Listgrade.Add(grade);

                    }
                }
            }
        }


        public void Attendance(Classroom classroom, Class cours)
        {
            foreach (Student student in classroom.Classroomlist)
            {
                Console.WriteLine("Is this student" + student.Name + " here ?");

                string answer = Console.ReadLine();

                if (answer == "Yes") Console.Write("");

                if (answer == "No") student.Nonattendance.Add(cours);

                else Console.WriteLine("Error");
            }
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
                foreach (Class classes in s.Nonattendance)
                {
                    Console.WriteLine(classes);
                }
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
            Console.WriteLine($"{Name}\n{s.Classeroom}\n{stringprofil}");
        }


        public void TeacherMenu()
        {
            Console.Clear();
            Console.WriteLine($"Welcome {Name}, choose an option :\n1) Attendance \n2) Add a Graduation for exams \n 3) See a classroom's results \n 4) See a student attendance \n 5) See a student profile");
            int menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {

                case 1:

                    Console.Clear();

                    Console.WriteLine("Choose the classroom you want to attempted");
                    string desiredclassroom = Console.ReadLine();

                    Console.WriteLine ("Please type the day of the class");
                    string desiredday = Console.ReadLine();

                    Console.WriteLine ("Please type the hour of the class");
                    int desiredhour = Convert.ToInt32(Console.ReadLine());

                    foreach (Classroom element in Listclassroom)
                    {

                        if (desiredclassroom == element.Name)
                        {
                            foreach (Class element2 in element.Timetable.Listclass)
                            {
                                if (element.Timetable.Date.day == desiredday && element.Timetable.Date.hour == desiredhour) 
                                {
                                    Attendance(element, element2);
                                }

                                else
                                {
                                    Console.WriteLine("there's a problem in your choice, please retry");
                                    TeacherMenu();
                                }
                            }                            
                        }

                        else

                        {
                            Console.WriteLine("there's a problem in your choice, please retry");
                            TeacherMenu();
                        }
                    }

                    break;

                case 2:

                    Console.Clear();                   
                    AddaGradeforaClassroom();
                    
                    break;


                case 3:

                    Console.Clear();

                    Console.WriteLine($"Enter a Class Name");
                    string wantedClass = Console.ReadLine();
                    foreach (Classroom c in Listclassroom)
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
                            TeacherMenu();
                        }
                    }

                    break;
                
                case 4:
                    Console.Clear();
                    Console.WriteLine($"Enter a Class Name");
                    string wantedClass2 = Console.ReadLine();
                    foreach (Classroom c in Listclassroom)
                    {
                        if (c.Name == wantedClass2)
                        {
                            SeeClassAttendance(c);
                            Console.WriteLine("Press any touch to exit");
                            Console.ReadKey();
                            Console.Clear();
                            TeacherMenu();
                        }
                        else
                        {
                            Console.WriteLine("The class was not found");
                            Console.WriteLine("Press any touch to exit");
                            Console.ReadKey();
                            Console.Clear();
                            TeacherMenu();
                        }
                    }
                    break;

                case 5:

                    Console.Clear();
                    Console.WriteLine($"Enter a Student Name");
                    string wantedName2 = Console.ReadLine();
                    foreach (Classroom c in Listclassroom)
                    {
                        foreach (Student s in c.Classroomlist)
                        {
                            if (wantedName2 == s.Name)
                            {
                                SeeStudentProfile(s);
                                Console.WriteLine("Press any touch to exit");
                                Console.ReadKey();
                                Console.Clear();
                                TeacherMenu();
                            }
                            else
                            {
                                Console.WriteLine("The student was not found");
                                Console.WriteLine("Press any touch to exit");
                                Console.ReadKey();
                                Console.Clear();
                                TeacherMenu();

                            }
                        }
                    }

                    break;
                
            }
            
        }
        public override string ToString()
        {
            return $"{Name} -- {Matter} {Id} {Password}";
        }

    }
}