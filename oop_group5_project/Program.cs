using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace oop_group5_project
{
                                                                //23024 Thomas BAUDU 
                                                                //23189 Audrey CHANTY
                                                                //23182 Jean-Baptiste CORRE
                                                                //23165 Victor FAUCHARD
                                                                //23213 Tristan GERON
                                                                //23164 Alexandre MAROTTE


    class Program
    {
        //CSV FILE OPENING AND GETTING USER DATA

        static void CreationFullList(List<Student> StudentList, List<Teacher> TeacherList, List<Admin> AdminList)
        {
            List<User> FullList = new List<User>();
            List<Classroom> ClassroomList = new List<Classroom>();
            List<Student> listclassA = new List<Student>();
            List<Student> listclassB = new List<Student>();
            List<Student> listclassC = new List<Student>();
            List<Class> classesA = new List<Class>();
            List<Class> classesB = new List<Class>();
            List<Class> classesC = new List<Class>();
            TimeTable timetableA = new TimeTable(classesA);
            TimeTable timetableB = new TimeTable(classesB);
            TimeTable timetableC = new TimeTable(classesC);

            Classroom classA = new Classroom("A", listclassA,timetableA);
            ClassroomList.Add(classA);
            //classA.Timetable = timetableA;
            
            Classroom classB = new Classroom("B", listclassB,timetableB);
            ClassroomList.Add(classB);
            //classB.Timetable = timetableB;
            
            Classroom classC = new Classroom("C", listclassC,timetableC);
            ClassroomList.Add(classC);
            //classC.Timetable = timetableC;

            string[] linestudent = System.IO.File.ReadAllLines("StudentList.csv");
            foreach (string line in linestudent)
            {
                string[] columns = line.Split(';');
                string name = columns[0];
                string classroomname = columns[1];
                string id = columns[2];
                string password = columns[3];
                
                
                if (classroomname == "A")
                {
                    List<Class> noattendance = new List<Class>();
                    List<string> profil = new List<string>();
                    List<Grade> listgrade = new List<Grade>();
                    Student s = new Student(name, classA, profil, listgrade, 8900, id, password, "Student");
                    s.Nonattendance = noattendance;
                    classA.Classroomlist.Add(s);
                    StudentList.Add(s);
                    FullList.Add(s);

                }
                else if (classroomname == "B")
                {
                    List<Class> noattendance = new List<Class>();
                    List<string> profil = new List<string>();
                    List<Grade> listgrade = new List<Grade>();
                    Student s = new Student(name, classB, profil, listgrade, 8900, id, password, "Student");
                    s.Nonattendance = noattendance;
                    classB.Classroomlist.Add(s);
                    StudentList.Add(s);
                    FullList.Add(s);
                }
                else if (classroomname == "C")
                {
                    List<Class> noattendance = new List<Class>();
                    List<string> profil = new List<string>();
                    List<Grade> listgrade = new List<Grade>();
                    Student s = new Student(name, classC, profil, listgrade, 8900, id, password, "Student");
                    s.Nonattendance = noattendance;
                    classC.Classroomlist.Add(s);
                    StudentList.Add(s);
                    FullList.Add(s);
                }
                else { Console.WriteLine("The class was not found"); }
            }
            string[] lineteacher = System.IO.File.ReadAllLines("TeacherList.csv");
            foreach (string linet in lineteacher)
            {
                string[] columnsteacher = linet.Split(';');
                string nameteacher = columnsteacher[0];
                string matter = columnsteacher[1];
                string idteacher = columnsteacher[2];
                string passwordteacher = columnsteacher[3];

                if (matter == "Mathematics")
                {
                    Teacher t = new Teacher(nameteacher, ClassroomList, Matter.mathematics, idteacher, passwordteacher, "Teacher");
                    TeacherList.Add(t);
                    FullList.Add(t);

                    Date DateClassroomA = new Date ("Monday", 12);
                    string locationClassroomA = "E106";
                    Class ClassClassroomA = new Class(DateClassroomA, Matter.mathematics, locationClassroomA, t);
                    classesA.Add(ClassClassroomA);

                    Date DateClassroomB = new Date ("Tuesday", 9);
                    string locationClassroomB = "E512";
                    Class ClassClassroomB = new Class(DateClassroomB, Matter.mathematics, locationClassroomB, t);
                    classesB.Add(ClassClassroomB);

                    Date DateClassroomC = new Date ("Monday", 9);
                    string locationClassroomC = "L420";
                    Class ClassClassroomC = new Class(DateClassroomC, Matter.mathematics, locationClassroomC, t);
                    classesC.Add(ClassClassroomC);

                }
                else if (matter == "French")
                {
                    Teacher t = new Teacher(nameteacher, ClassroomList, Matter.french, idteacher, passwordteacher, "Teacher");
                    TeacherList.Add(t);
                    FullList.Add(t);

                    Date DateClassroomA = new Date ("Monday", 15);
                    string locationClassroomA = "L106";
                    Class ClassClassroomA = new Class(DateClassroomA, Matter.french, locationClassroomA, t);
                    classesA.Add(ClassClassroomA);

                    Date DateClassroomB = new Date ("Friday", 9);
                    string locationClassroomB = "E512";
                    Class ClassClassroomB = new Class(DateClassroomB, Matter.french, locationClassroomB, t);
                    classesB.Add(ClassClassroomB);

                    Date DateClassroomC = new Date ("Friday", 15);
                    string locationClassroomC = "L420";
                    Class ClassClassroomC = new Class(DateClassroomC, Matter.french, locationClassroomC, t);
                    classesC.Add(ClassClassroomC);

                }
                else if (matter == "Physics")
                {
                    Teacher t = new Teacher(nameteacher, ClassroomList, Matter.physics, idteacher, passwordteacher, "Teacher");
                    TeacherList.Add(t);
                    FullList.Add(t);

                    Date DateClassroomA = new Date ("Tuesday", 9);
                    string locationClassroomA = "E106";
                    Class ClassClassroomA = new Class(DateClassroomA, Matter.physics, locationClassroomA, t);
                    classesA.Add(ClassClassroomA);

                    Date DateClassroomB = new Date ("Tuesday", 12);
                    string locationClassroomB = "E512";
                    Class ClassClassroomB = new Class(DateClassroomB, Matter.physics, locationClassroomB, t);
                    classesB.Add(ClassClassroomB);

                    Date DateClassroomC = new Date ("Tuesday", 9);
                    string locationClassroomC = "L420";
                    Class ClassClassroomC = new Class(DateClassroomC, Matter.physics, locationClassroomC, t);
                    classesC.Add(ClassClassroomC);
                }
                else if (matter == "Litterature")
                {
                    Teacher t = new Teacher(nameteacher, ClassroomList, Matter.litterarenglish, idteacher, passwordteacher, "Teacher");
                    TeacherList.Add(t);
                    FullList.Add(t);

                    Date DateClassroomA = new Date ("Tuesday", 13);
                    string locationClassroomA = "E106";
                    Class ClassClassroomA = new Class(DateClassroomA, Matter.litterarenglish, locationClassroomA, t);
                    classesA.Add(ClassClassroomA);

                    Date DateClassroomB = new Date ("Wednesday", 9);
                    string locationClassroomB = "E512";
                    Class ClassClassroomB = new Class(DateClassroomB, Matter.litterarenglish, locationClassroomB, t);
                    classesB.Add(ClassClassroomB);

                    Date DateClassroomC = new Date ("Tuesday", 12);
                    string locationClassroomC = "L420";
                    Class ClassClassroomC = new Class(DateClassroomC, Matter.litterarenglish, locationClassroomC, t);
                    classesC.Add(ClassClassroomC);
                }
                else if (matter == "Sport")
                {
                    Teacher t = new Teacher(nameteacher, ClassroomList, Matter.sport, idteacher, passwordteacher, "Teacher");
                    TeacherList.Add(t);
                    FullList.Add(t);

                    Date DateClassroomA = new Date ("Wednesday", 15);
                    string locationClassroomA = "E106";
                    Class ClassClassroomA = new Class(DateClassroomA, Matter.sport, locationClassroomA, t);
                    classesA.Add(ClassClassroomA);

                    Date DateClassroomB = new Date ("Wednesday", 12);
                    string locationClassroomB = "E512";
                    Class ClassClassroomB = new Class(DateClassroomB, Matter.sport, locationClassroomB, t);
                    classesB.Add(ClassClassroomB);

                    Date DateClassroomC = new Date ("Thursday", 15);
                    string locationClassroomC = "L420";
                    Class ClassClassroomC = new Class(DateClassroomC, Matter.sport, locationClassroomC, t);
                    classesC.Add(ClassClassroomC);

                }
                else { Console.WriteLine("The matter was not found"); }
            }
            string[] lineadmin = System.IO.File.ReadAllLines("AdminList.csv");
            foreach (string linea in lineadmin)
            {
                string[] columnsadmin = linea.Split(';');
                string nameadmin = columnsadmin[0];
                string idadmin = columnsadmin[1];
                string passwordadmin = columnsadmin[2];
                Admin a = new Admin(nameadmin, idadmin, passwordadmin, "Admin");
                AdminList.Add(a);
                FullList.Add(a);
                a.StudentFullList = StudentList;
                a.TeacherFullList = TeacherList;
                a.ClassroomsFullList = ClassroomList;
            }
            foreach (Student s in StudentList)
            {
                Console.WriteLine(s);
            }
            foreach (Teacher t in TeacherList)
            {
                Console.WriteLine(t);
            }
            foreach (Admin a in AdminList)
            {
                Console.WriteLine(a);
            }
            foreach(User u in FullList)
            {
                
                Console.WriteLine($"+ {u}");
            }
        }

        // Center a specific text on the console
        static void centerText(String text)
        {
            Console.Write(new string(' ', (Console.WindowWidth - text.Length) / 2));
            Console.Write(text);
        }

        //Main String

        static void Main(string[] args)
        {
            //DOES THE USER EXIST ?

            List<Student> StudentList = new List<Student>();
            List<Teacher> TeacherList = new List<Teacher>();
            List<Admin> AdminList = new List<Admin>();

            CreationFullList(StudentList, TeacherList, AdminList);

            bool userexist = false;
            while (userexist == false)
            {
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
                centerText("Welcome in Global Visual College\n\n");
                centerText("Username : ");
                string id = Console.ReadLine();
                centerText("Password : ");
                string password = Console.ReadLine();

                // Compare the username and the password with the list of existing Students/Teachers/Admins
                // If there is a match, the login succeed and the informations concerning the user are loading in

                foreach (Student student in StudentList)
                {
                    if (id == student.Id)
                    {
                        Console.WriteLine(student);

                        if (password == student.Password)
                        {
                            userexist = true;
                            Console.Clear(); Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
                            centerText("Loading...."); System.Threading.Thread.Sleep(2000); Console.Clear(); Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");    //Loading Bar, with 2 seconds delay
                            centerText("Well logged in, welcome back " + student.Name);
                            //Console.WriteLine("you are a " + username.usertype);
                            System.Threading.Thread.Sleep(2000);
                            student.StudentMenu();
                        }
                        else
                        {
                            Console.Write("");
                        }
                    }
                    else
                    {
                        Console.Write(""); ;
                    }
                }

                foreach (Teacher teacher in TeacherList)
                {
                    if (id == teacher.Id)
                    {
                        if (password == teacher.Password)
                        {
                            userexist = true;
                            Console.Clear(); Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
                            centerText("Loading...."); System.Threading.Thread.Sleep(2000); Console.Clear(); Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");    //Loading Bar, with 2 seconds delay
                            centerText("Well logged in, welcome back " + teacher.Name);
                            //Console.WriteLine("you are a " + username.usertype);
                            System.Threading.Thread.Sleep(2000);
                            teacher.TeacherMenu();
                        }
                        else
                        {
                            Console.Write(""); ;
                        }
                    }
                    else
                    {
                        Console.Write(""); ;
                    }
                }

                foreach (Admin admin in AdminList)
                {
                    if (id == admin.Id)
                    {
                        if (password == admin.Password)
                        {
                            userexist = true;
                            Console.Clear(); Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
                            centerText("Loading...."); System.Threading.Thread.Sleep(2000); Console.Clear(); Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");    //Loading Bar, with 2 seconds delay
                            centerText("Well logged in, welcome back " + admin.Name);
                            //Console.WriteLine("you are a " + username.usertype);
                            System.Threading.Thread.Sleep(2000);
                            admin.AdminMenu();
                        }
                        else
                        {
                            Console.Write(""); ;
                        }
                    }
                    else
                    {
                        Console.Write(""); ;
                    }
                }

                if (userexist == false)
                {
                    Console.Clear(); Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
                    centerText("Loading...."); System.Threading.Thread.Sleep(2000); Console.Clear(); Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
                    centerText("Sorry, the id or the password is incorrect, try again");
                    System.Threading.Thread.Sleep(2000); Console.Clear();
                }

                userexist = false;      //IF DECISION OF BEING DISCONNECTED, WE GO BACK TO THE LOGIN SESSION
            }

            Console.ReadKey();
            Console.Clear();
            
        }
    }
}
