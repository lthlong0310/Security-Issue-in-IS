using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Object
{
    public class CapQuyenOption
    {
        public CapQuyenOption() { }
        public CapQuyenOption(string us, string nprivs, string opt)
        {
            username = us;
            name_privs = nprivs;
            option = opt;
        }
        public string username { get; set; }
        public string name_privs { get; set; }
        public string option { get; set; }
    }
}
