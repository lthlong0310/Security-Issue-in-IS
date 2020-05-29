using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Object
{
    public class CapQuyen
    {
        public CapQuyen() { }
        public CapQuyen(string us, string nprivs)
        {
            username = us;
            name_privs = nprivs;
        }
        public string username { get; set; }
        public string name_privs { get; set; }
    }
}
