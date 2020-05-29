using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Object
{
    public class DanhSachUser
    {
        public DanhSachUser() { }
        public DanhSachUser(string un)
        {
            username = un;
        }
        public string username { get; set; }
    }
}
