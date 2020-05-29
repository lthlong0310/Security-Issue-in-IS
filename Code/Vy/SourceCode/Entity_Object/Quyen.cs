using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Object
{
    public class Quyen
    {
        public Quyen() { }
        public Quyen(string gr, string pr, string ad, string co, string inh)
        {
            grantee = gr;
            privilege = pr;
            admin_option = ad;
            common = co;
            inheritied = inh;
        }
        public string grantee { get; set; }
        public string privilege { get; set; }
        public string admin_option { get; set; }
        public string common { get; set; }
        public string inheritied { get; set; }
    }
}
