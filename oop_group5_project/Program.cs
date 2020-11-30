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
        static void RemplirFichier(List<ArrayList> file)
        {
            StreamReader liste = new StreamReader("ExcelListProject.csv");
            string[] lines = System.IO.File.ReadAllLines("ExcelListProject.csv");

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


        static void Main(string[] args)
        { 
            string name ="";
            string surname="";
            string usertype = "";

            //CSV FILE USING

            List<ArrayList> file = new List<ArrayList>();
            RemplirFichier(file);
            //file.RemoveAt(0);       //Remove first line with Name,Surname, ID, Password, Type
            PrintData(file);  // Affiche les données

            //DOES THE USER EXIST ?

            bool userexist = false;
            while (userexist == false)
            {
                Console.WriteLine("\nUsername : ");
                string id = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Password : ");
                string password = Convert.ToString(Console.ReadLine());

                // Compare the username and the password with the list of existing Students/Teachers/Admins
                // If there is a match, the login succeed and the informations concerning the user are loading in

                foreach (ArrayList user in file)
                {
                    if (id == (string)user[2])
                        if(password == (string)user[3])    
                        {
                            userexist = true;
                            name = (string)user[0];
                            surname = (string)user[1];       //Enregistrement de toutes les caractéristiques d'un élève --> Nom, classe? COURS etc
                            usertype = (string)user[4];


                            //ENREGISTRER COURS ABSENCE ETC DU DOCUMENT EXCEL (PAS ENCORE ECRIT)

                        }
                }

                //LOADING ... IF ID OR PASSWORD INCORRECT, GETTING BACK TO IDENTIFICATION
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
                    Console.WriteLine("Well logged in, welcome back " + usertype + " " + name + " " + surname);
                    //Console.WriteLine("you are a " + username.usertype);
                    System.Threading.Thread.Sleep(2000);
                }
            }




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
