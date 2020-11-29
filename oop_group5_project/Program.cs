using System;
using System.Collections.Generic;
using System.Text;


namespace oop_group5_project
{
    class Program
    {



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
            string password = "password";
            string usertype = "1";

            Student test = new Student(name,classroom,profil,timetable,listgrade,cost,id,password,usertype);
        }

        public class ConsoleSpiner      //Loading Bar during the login
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
        }


        static void Main(string[] args)                         //23024 Thomas BAUDU 
        {                                                       //23189 Audrey CHANTY
                                                                //23182 Jean-Baptiste CORRE
                                                                //23165 Victor FAUCHARD
                                                                //23213 Tristan GERON
                                                                //23164 Alexandre MAROTTE

            List<User> userlist = new List<User>();
            Admin admintest = new Admin("JB", "12345", "password", "3");
            userlist.Add(admintest);
            List<Student> liststudent = new List<Student>();
            Classroom classroom = new Classroom("1", liststudent);
            List<string> profil = new List<string> { "01/01/2000", "jj", "Dupont" };
            TimeTable timetable = new TimeTable(new List<Class> { });
            // Payment payment = new Payment(7900);   - ne sert plus à rien avec l'interface
            List<Grade> listgrade = new List<Grade> { };
            int cost = 7900;
            Student studenttest = new Student("jj", classroom, profil, timetable, listgrade, cost, "2255", "password", "1");
            userlist.Add(studenttest);
            List < Classroom > listclassroom = new List<Classroom>();

            Teacher teachertest = new Teacher("Ms.Smith", listclassroom, Matter.french, "159", "password", "2");
            userlist.Add(teachertest);

            //studenttest.StudentMenu();
            Date date1 = new Date("Wednesday", 14);
            Date date2 = new Date("Monday", 9);
            Class classtest1 = new Class(date1,Matter.art,"L210",teachertest);
            Class classtest2 = new Class(date2, Matter.mathematics, "L210", teachertest);
            studenttest.Timetable.Listclass.Add(classtest1);
            studenttest.Timetable.Listclass.Add(classtest2);
            studenttest.SeeAttendence();
            /*bool userexist = false;

            while(userexist == false)
            {
                Console.WriteLine("Username : ");
                string id = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Password : ");
                string password = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Are you a : 1)Student \n2)Teacher\n3)Admin");
                string usertype = Convert.ToString(Console.ReadLine());
                
                // Compare the username and the password with the list of existing Students/Teachers/Admins
                // If there is a match, the login succeed and the informations concerning the user are loading in
                
                foreach (User username in userlist)
                {
                    if (id == username.Id && password == username.Password)
                    {
                        
                        userexist = true;
                        
                    }
                }

                if (userexist == false)
                {
                    Console.Clear();
                    Console.WriteLine("Loading....");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine("Sorry, the id or the password is incorrect, try again");
                    System.Threading.Thread.Sleep(2000);                                            //Delay 2 seconds for a new trial
                    Console.Clear();
                }
                else 
                {
                    Console.Clear();
                    Console.WriteLine("Loading....");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine("Well logged in, welcome back user " + id);
                    Console.WriteLine("you are a " + username.usertype);
                    System.Threading.Thread.Sleep(2000);
                }
            }*/

            Console.ReadKey();
            Console.Clear();
            
        }
    }
}
