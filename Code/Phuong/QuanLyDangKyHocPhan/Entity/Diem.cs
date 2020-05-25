using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Diem
    {
        public String mssv { get; set; }
        public String malop { get; set; }
        public String monhoc { get; set; }
        public int hocky { get; set; }
        public String namhoc { get; set; }
        public float diemgk { get; set; }
        public float diemck { get; set; }
        public float diemkhac { get; set; }
        public float diemtong { get; set; }

        public Diem (String sv, String lop, String mon, int hk, String nam, float gk, float ck, float khac, float tong)
        {
            mssv = sv;
            malop = lop;
            monhoc = mon;
            hocky = hk;
            namhoc = nam;
            diemgk = gk;
            diemck = ck;
            diemkhac = khac;
            diemtong = tong;

        }
    }
}
