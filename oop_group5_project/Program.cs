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
            int classroom = 17;
            List<string> profil = new List<string> { "01/01/2000", "Paul", "Dupont" };
            TimeTable timetable = new TimeTable(new List<Class> { });
            // Payment payment = new Payment(7900);   - ne sert plus à rien avec l'interface
            List<Grade> listgrade = new List<Grade> { };
            int cost = 7900;

            Student test = new Student(name, classroom, profil, timetable, listgrade, cost);
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

            
            List<Platform> user = new List<Platform>();

            user.Add(new Platform() { id = "12345", password = "azerty65" , usertype = "student"});
            user.Add(new Platform() { id = "13579", password = "abcde89", usertype = "student" });
            user.Add(new Platform() { id = "23456", password = "qsdfg12", usertype = "teacher" });
            user.Add(new Platform() { id = "34567", password = "wxcvb34", usertype = "admin" });

            bool userexist = false;

            while(userexist == false)
            {
                Console.WriteLine("Username : ");
                string id = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Password : ");
                string password = Convert.ToString(Console.ReadLine());

                // Compare the username and the password with the list of existing Students/Teachers/Admins
                // If there is a match, the login succeed and the informations concerning the user are loading in

                foreach (Platform username in user)
                {
                    if (id == username.id && password == username.password)
                    {
                        userexist = true;
                    }
                }

                if (userexist == false)
                {
                    Console.Clear();
                    Console.WriteLine("Loading....");
                    System.Threading.Thread.Sleep(3500);
                    Console.Clear();
                    Console.WriteLine("Sorry, the id or the password is incorrect, try again");
                    System.Threading.Thread.Sleep(3500);                                            //Delay 3.5 seconds for a new trial
                    Console.Clear();
                }
                else 
                {
                    Console.Clear();
                    Console.WriteLine("Loading....");
                    System.Threading.Thread.Sleep(3500);
                    Console.Clear();
                    Console.WriteLine("Well logged in, welcome back user " + id);
                    System.Threading.Thread.Sleep(3500);
                }
            }


            Console.Clear();
        }
    }
}
