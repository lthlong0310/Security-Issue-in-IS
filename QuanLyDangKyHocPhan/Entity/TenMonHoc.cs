using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class TenMonHoc
    {
        public TenMonHoc() { }
        public TenMonHoc(string tmh)
        {
            tenmonhoc = tmh;
        }
        public string tenmonhoc { get; set; }
    }
}
