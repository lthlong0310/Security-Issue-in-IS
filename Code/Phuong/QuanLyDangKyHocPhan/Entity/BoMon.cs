using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Entity
{
    public class BoMon
    {
        public String mabomon { get; set; }
        public String tenbomon { get; set; }
        public String truongbomon { get; set; }

        public BoMon (String ma, String ten, String truongbm)
        {
            mabomon = ma;
            tenbomon = ten;
            truongbomon = truongbm;
        }
    }
}
