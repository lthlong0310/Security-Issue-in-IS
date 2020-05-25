using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class ThoiKhoaBieu
    {
        public String malop { get; set; }
        public String monhoc { get; set; }
        public int hocky { get; set; }
        public String namhoc { get; set; }
        public String phonghoc { get; set; }
        public String giaoviengiangday { get; set; }
        public int sosvtoida { get; set; }

        public ThoiKhoaBieu (String lop, String mon, int hk, String nam, String phong, String gv, int svtoida)
        {
            malop = lop;
            monhoc = mon;
            hocky = hk;
            namhoc = nam;
            phonghoc = phong;
            giaoviengiangday = gv;
            sosvtoida = svtoida;
        }


    }
}
