using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class User
    {
        public String username { get; set; }
        public String password { get; set; }
        public String usertype { get; set; }

        public User (String un, String pss)
        {
            username = un;
            password = pss;
            usertype = "";
        }

        public void ClearUser()
        {
            username = "";
            password = "";
            usertype = "";
        }
    }
}
