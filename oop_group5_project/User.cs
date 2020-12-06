using System;
using System.Collections.Generic;
using System.Text;

namespace oop_group5_project
{
                                                                    //23024 Thomas BAUDU 
                                                                   //23189 Audrey CHANTY
                                                                  //23182 Jean-Baptiste CORRE
                                                                 //23165 Victor FAUCHARD
                                                                //23213 Tristan GERON
                                                               //23164 Alexandre MAROTTE

    public abstract class User
    {
        public string Id { get; set; }
        public string Password { get; set; }
        public string Usertype { get; set; }

        public User(string id, string password, string usertype)
        {
            Id = id;
            Password = password;
            Usertype = usertype;

        }


        //Goal : reaching a matching username and password to login and get back the informations concerning any user (student, teacher, admin)

        public void Login()     //PAS SUR QUE CA SERVE 
        {
            Console.WriteLine("Type your situation : \n 1/ Teacher \n 2/ Student \n 3/ Admin");
            Usertype = Console.ReadLine();
            switch (Usertype)
            {
                case "Teacher":
                    Console.Clear();
                    break;
                case "Student":
                    Console.Clear();
                    break;
                case "Admin":
                    Console.Clear();
                    break;
            }
        }

        public override string ToString()
        {
            return $" --  {Id} {Password}";
        }
    }
}
