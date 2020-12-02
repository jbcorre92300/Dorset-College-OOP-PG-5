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


        static void Main(string[] args)
        { 
            string name ="";
            string usertype = "";
            string idused = "";

            //CSV FILE USING

            string filePeopleList = "ExcelListProject.csv";
            string fileStudentGrade = "GRADEScsv.csv";
            string fileSchedule = "EDTExcelStudentClassCSV.csv";
            //string fileMissing = " ";     //Not done the EXCEL ABSCENCE

            List<ArrayList> PeopleList = new List<ArrayList>();
            List<ArrayList> GradeList = new List<ArrayList>();
            List<ArrayList> ScheduleList = new List<ArrayList>();

            RemplirFichier(PeopleList, filePeopleList);
            RemplirFichier(GradeList, fileStudentGrade);
            RemplirFichier(ScheduleList, fileSchedule);

            //file.RemoveAt(0);       //Remove first line with Name,Surname, ID, Password, Type

            PrintData(PeopleList);  // Affiche les données


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

                foreach (ArrayList user in PeopleList)
                {
                    if (id == (string)user[2])
                        if(password == (string)user[3])    
                        {
                            userexist = true;
                            name = (string)user[0];
                            usertype = (string)user[4];                                     //Enregistrement de toutes les caractéristiques d'un élève --> Nom, classe? COURS etc
                            idused = id;

                            //ENREGISTRER COURS ABSENCE ETC DU DOCUMENT EXCEL (PAS ENCORE ECRIT)

                        }
                }

                //LOADING ... IF ID OR PASSWORD INCORRECT, GETTING BACK TO IDENTIFICATION
                if (userexist == false)
                {
                    /*Console.Clear();
                    Console.WriteLine("Loading....");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();*/

                    Console.WriteLine("Sorry, the id or the password is incorrect, try again");
                    System.Threading.Thread.Sleep(2000);                                         //Delay 2 seconds for a new trial
                    Console.Clear();
                }

                //USER EXISTS --> Connection Success
                else
                {
                    /*Console.Clear();
                    Console.WriteLine("Loading....");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();*/

                    Console.WriteLine("Well logged in, welcome back " + usertype + " " + name);
                    //Console.WriteLine("you are a " + username.usertype);
                    System.Threading.Thread.Sleep(2000);


                    //STARTING OF THE SESSION

                    bool beingconnected = true;
                    while (beingconnected == true)
                    {
                        switch (usertype)
                        {
                            case "Student":

                                Console.Clear();

                                //ADAPTER LES DONNES 3 FOIS LA LISTE DE NOTES, ABSENCE ET Emploi du temps A LA BONNE PERSONNE

                                /*foreach (ArrayList user in PeopleList)
                                {
                                    if (idused == (string)user[0])
                                    {
                                        //Peut etre deja fait au début lors de la vérification du mot de passe mais laisser au cas où pour Absence
                                    }

                                }*/

                                foreach (ArrayList user in GradeList)
                                {
                                    if (idused == (string)user[0])
                                    {
                                        //Notes de Mathematics = (int)user[1];
                                        //Notes de French = (int)user[2];
                                        //Notes de Litterature = (int)user[3];
                                        //Notes de Sport = (int)user[4];
                                        //Notes de Spanish = (int)user[5];

                                        //FAIRE UNE FONCTION MOYENNE GENERALE ?
                                        //double mean = .../5;
                                    }

                                }

                                foreach (ArrayList user in ScheduleList)
                                {
                                    if (idused == (string)user[0])
                                    {

                                    }

                                }

                                //ENREGISTREMENT DE TOUTES LES DONNEES NECESSAIRES TERMINEES


                                //MARQUER POSSIBILITE OFFERTE EN ETANT STUDENT A PARTIR DES CLASSES


                                // .StudentMenu();

                                Console.WriteLine("If you want to be disconnected, just type 0"); //Possiblement ajoutable au Student Menu, permet de revenir à la page de connexion initiale
                                int rep = Convert.ToInt32(Console.ReadLine());
                                if (rep == 0)
                                {
                                    beingconnected = false;
                                }
                                break;


                            case "Teacher":

                                //MARQUER POSSIBILITE OFFERTE EN ETANT TEACHER A PARTIR DES CLASSES

                                break;


                            case "Admin":

                                //MARQUER POSSIBILITE OFFERTE EN ETANT ADMIN A PARTIR DES CLASSES

                                break;
                        }

                    }


                }
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
