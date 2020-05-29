using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Object
{
    public class User
    {
        public User() {  }
        public User(string un, string pw)
        {
            username = un;
            password = pw;
        }
        public string username { get; set; }
        public string password { get; set; }
    }
}
