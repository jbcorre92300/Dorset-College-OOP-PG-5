using System;
using System.Collections.Generic;
using System.Text;

namespace oop_group5_project
{
    public abstract class Platform
    {
        public string Id { get; set; }
        public string Password { get; set; }
        public string  Usertype { get; set; } 
    
        public Platform(string id,string password,string usertype)
        {
            Id = id;
            Password = password;
            Usertype = usertype;

        }


        //Goal : reaching a matching username and password to login and get back the informations concerning any user (student, teacher, admin)

        public void Login()
        {

        }
    }
}
