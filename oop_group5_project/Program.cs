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
        static void RemplirFichier(List<ArrayList> file, string fileName)
        {
            StreamReader liste = new StreamReader(fileName);
            string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] columns = line.Split(';'); // line.Split(new char [] {',','"'})

                ArrayList user = new ArrayList();

                foreach (string column in columns)
                {
                    user.Add(column); // Ajoute un mot à la liste 
                }
                file.Add(user);
            }
            liste.Close();
        }

        static void PrintData(List<ArrayList> file)
        {
            //char pad = ' ';
            foreach (ArrayList user in file)
            {
                //Console.WriteLine(passager.Count);
                foreach (object aze in user)
                {
                    Console.Write(aze + " | ");
                    //string azee = (string)aze;
                    //Console.Write((string)azee.PadRight(5,pad));
                }
                Console.WriteLine();

                //Console.WriteLine(passager.ToString());
            }
        }

        //UNTIL HERE

        static void CreationFullList()
        {
            List<User> FullList = new List<User>();
            List<Classroom> ClassroomList = new List<Classroom>();
            List<Student> listclassA = new List<Student>();
            Classroom classA = new Classroom("A", listclassA);
            ClassroomList.Add(classA);
            List<Student> listclassB = new List<Student>();
            Classroom classB = new Classroom("B", listclassB);
            ClassroomList.Add(classB);
            List<Student> listclassC = new List<Student>();
            Classroom classC = new Classroom("C", listclassC);
            ClassroomList.Add(classC);
            string[] linestudent = System.IO.File.ReadAllLines("StudentList.csv");
            List<Student> StudentList = new List<Student>();
            foreach (string line in linestudent)
            {
                string[] columns = line.Split(';');
                string name = columns[0];
                string classroomname = columns[1];
                string id = columns[2];
                string password = columns[3];
                List<string> profil = new List<string>();
                List<Grade> listgrade = new List<Grade>();
                if (classroomname == "A")
                {
                    Student s = new Student(name, classA, profil, listgrade, 8900, id, password, "Student");
                    classA.Classroomlist.Add(s);
                    StudentList.Add(s);
                    FullList.Add(s);

                }
                else if (classroomname == "B")
                {
                    Student s = new Student(name, classB, profil, listgrade, 8900, id, password, "Student");
                    classB.Classroomlist.Add(s);
                    StudentList.Add(s);
                    FullList.Add(s);
                }
                else if (classroomname == "C")
                {
                    Student s = new Student(name, classC, profil, listgrade, 8900, id, password, "Student");
                    classC.Classroomlist.Add(s);
                    StudentList.Add(s);
                    FullList.Add(s);
                }
                else { Console.WriteLine("The class was not found"); }
            }
            string[] lineteacher = System.IO.File.ReadAllLines("TeacherList.csv");
            List<Teacher> TeacherList = new List<Teacher>();
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
                }
                else if (matter == "French")
                {
                    Teacher t = new Teacher(nameteacher, ClassroomList, Matter.french, idteacher, passwordteacher, "Teacher");
                    TeacherList.Add(t);
                    FullList.Add(t);
                }
                else if (matter == "Physics")
                {
                    Teacher t = new Teacher(nameteacher, ClassroomList, Matter.physics, idteacher, passwordteacher, "Teacher");
                    TeacherList.Add(t);
                    FullList.Add(t);
                }
                else if (matter == "Litterature")
                {
                    Teacher t = new Teacher(nameteacher, ClassroomList, Matter.litterarenglish, idteacher, passwordteacher, "Teacher");
                    TeacherList.Add(t);
                    FullList.Add(t);
                }
                else if (matter == "Sport")
                {
                    Teacher t = new Teacher(nameteacher, ClassroomList, Matter.physicsactivity, idteacher, passwordteacher, "Teacher");
                    TeacherList.Add(t);
                    FullList.Add(t);
                }
                else { Console.WriteLine("The matter was not found"); }
            }
            string[] lineadmin = System.IO.File.ReadAllLines("AdminList.csv");
            List<Admin> AdminList = new List<Admin>();
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

        /*
        static void Buildfortest()
        {
            string name = "Edouart";
            List<Student> liststudent = new List<Student>();
            Classroom classroom = new Classroom("1",liststudent);
            List<string> profil = new List<string> { "01/01/2000", "Paul", "Dupont" };
            TimeTable timetable = new TimeTable(new List<Class> { });
            // Payment payment = new Payment(7900);   - ne sert plus à rien avec l'interface
            List<Grade> listgrade = new List<Grade> { };
            int cost = 7900;
            string id = "987654";
            string password = "AAA";
            string usertype = "1";

            Student test = new Student(name,classroom,profil,timetable,listgrade,cost,id,password,usertype);
        }*/

        /*public class ConsoleSpiner      //Loading Bar during the login
        {
            int counter;
            public ConsoleSpiner()
            {
                counter = 0;
            }
            public void Turn()
            {
                counter++;
                switch (counter % 4)
                {
                    case 0: Console.Write("."); break;
                    case 1: Console.Write("."); break;
                    case 2: Console.Write("."); break;
                    case 3: Console.Write("."); break;
                }
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
        }*/

        static void Deconnexion()
        {

        }

        static void centerText(String text)
        {
            Console.Write(new string(' ', (Console.WindowWidth - text.Length) / 2));
            Console.Write(text);
        }

        static void Main(string[] args)
        {
            List<User> FullList = new List<User>();
            List<Classroom> ClassroomList = new List<Classroom>();
            List<Student> listclassA = new List<Student>();
            Classroom classA = new Classroom("A", listclassA);
            ClassroomList.Add(classA);
            List<Student> listclassB = new List<Student>();
            Classroom classB = new Classroom("B", listclassB);
            ClassroomList.Add(classB);
            List<Student> listclassC = new List<Student>();
            Classroom classC = new Classroom("C", listclassC);
            ClassroomList.Add(classC);
            string[] linestudent = System.IO.File.ReadAllLines("StudentList.csv");
            List<Student> StudentList = new List<Student>();
            List<Grade> listgrade = new List<Grade>();
            foreach (string line in linestudent)
            {
                string[] columns = line.Split(';');
                string name = columns[0];
                string classroomname = columns[1];
                string id = columns[2];
                string password = columns[3];
                List<string> profil = new List<string>();
                List<Class> noattendance = new List<Class>();
                if (classroomname == "A")
                {
                    Student s = new Student(name, classA, profil, listgrade, 8900, id, password, "Student");
                    s.Nonattendance = noattendance;
                    listclassA.Add(s);
                    StudentList.Add(s);
                    FullList.Add(s);
                }
                else if (classroomname == "B")
                {
                    Student s = new Student(name, classB, profil, listgrade, 8900, id, password, "Student");
                    listclassB.Add(s);
                    s.Nonattendance = noattendance;
                    StudentList.Add(s);
                    FullList.Add(s);
                }
                else if (classroomname == "C")
                {
                    Student s = new Student(name, classC, profil, listgrade, 8900, id, password, "Student");
                    listclassC.Add(s);
                    s.Nonattendance = noattendance;
                    StudentList.Add(s);
                    FullList.Add(s);
                }
                else { Console.WriteLine("The class was not found"); }
            }
            
            string[] lineteacher = System.IO.File.ReadAllLines("TeacherList.csv");
            List<Teacher> TeacherList = new List<Teacher>();
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
                }
                else if (matter == "French")
                {
                    Teacher t = new Teacher(nameteacher, ClassroomList, Matter.french, idteacher, passwordteacher, "Teacher");
                    TeacherList.Add(t);
                    FullList.Add(t);
                }
                else if (matter == "Physics")
                {
                    Teacher t = new Teacher(nameteacher, ClassroomList, Matter.physics, idteacher, passwordteacher, "Teacher");
                    TeacherList.Add(t);
                    FullList.Add(t);
                }
                else if (matter == "Litterature")
                {
                    Teacher t = new Teacher(nameteacher, ClassroomList, Matter.litterarenglish, idteacher, passwordteacher, "Teacher");
                    TeacherList.Add(t);
                    FullList.Add(t);
                }
                else if (matter == "Sport")
                {
                    Teacher t = new Teacher(nameteacher, ClassroomList, Matter.physicsactivity, idteacher, passwordteacher, "Teacher");
                    TeacherList.Add(t);
                    FullList.Add(t);
                }
                else { Console.WriteLine("The matter was not found"); }
            }

            /*foreach(Teacher c in TeacherList)
            {
                Console.WriteLine(c.Name);
                foreach(Classroom cl in  c.Listclassroom)
                {
                    Console.WriteLine(cl);
                }
            }*/
            string[] lineadmin = System.IO.File.ReadAllLines("AdminList.csv");
            List<Admin> AdminList = new List<Admin>();
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
            /*foreach (Student s in StudentList)
            {
                Console.WriteLine(s);
                Console.WriteLine(s.Classeroom.Name);
            }
            foreach (Teacher t in TeacherList)
            {
                Console.WriteLine(t);
            }
            foreach (Admin a in AdminList)
            {
                Console.WriteLine(a);
            }
            foreach (User u in FullList)
            {

                Console.WriteLine($"+ {u}");
            }*/
            

            //DOES THE USER EXIST ?

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


            
            





            /*
            List<User> userlist = new List<User>();
            Admin admintest = new Admin("JB", "12345", "AZA", "3");
            userlist.Add(admintest);
            List<Student> liststudent = new List<Student>();
            Classroom classroom = new Classroom("1", liststudent);
            List<string> profil = new List<string> { "01/01/2000", "jj", "Dupont" };
            TimeTable timetable = new TimeTable(new List<Class> { });
            // Payment payment = new Payment(7900);   - ne sert plus à rien avec l'interface
            List<Grade> listgrade = new List<Grade> { };
            int cost = 7900;

            Student studenttest = new Student("jj", classroom, profil, timetable, listgrade, cost, "2255", "AZE", "1");
            userlist.Add(studenttest);
            List < Classroom > listclassroom = new List<Classroom>();

            Teacher teachertest = new Teacher("Ms.Smith", listclassroom, Matter.french, "159", "eee", "2");
            userlist.Add(teachertest);

            studenttest.StudentMenu();
            */



            /*
            Date date1 = new Date("Wednesday", 14);
            Date date2 = new Date("Monday", 9);
            Class classtest1 = new Class(date1,Matter.art,"L210",teachertest);
            Class classtest2 = new Class(date2, Matter.mathematics, "L210", teachertest);
            studenttest.Timetable.Listclass.Add(classtest1);
            studenttest.Timetable.Listclass.Add(classtest2);
            studenttest.SeeAttendence();
            */

            Console.ReadKey();
            Console.Clear();
            
        }
    }
}
