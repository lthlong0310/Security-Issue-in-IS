using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Object
{
    public class Object
    {
        public String owner { get; set; }
        public String object_name { get; set; }
        public String subobject_name { get; set; }
        public String object_type { get; set; }

       
        public Object(String own, String oname, String suboname, String otype)
        {
            owner = own;
            object_name = oname;
            subobject_name = suboname;
            object_type = otype;
        }

        public Object(String oname, String suboname, String otype)
        {
            owner = "";
            object_name = oname;
            subobject_name = suboname;
            object_type = otype;
        }
    }
}
