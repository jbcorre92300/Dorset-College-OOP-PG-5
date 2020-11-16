using System;
using System.Collections.Generic;
using System.Text;

namespace oop_group5_project
{
    class Platform
    {
        public string id;
        public string password;
        public List<Platform> users;

        public Platform(string id, string password, List<Platform> users)
        {
            this.id = id;
            this.password = password;
            this.users = users;
        }

        //Goal : reaching a matching username and password to login and get back the informations concerning any user (student, teacher, admin)

        public void Login()
        {

        }
    }
}
