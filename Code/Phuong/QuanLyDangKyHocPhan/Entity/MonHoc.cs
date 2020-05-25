using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class MonHoc
    {
        public String mamonhoc { get; set; }
        public String tenmonhoc { get; set; }
        public String bomon { get; set; }
        public int sotinchi { get; set; }

        public MonHoc(String mamh, String tenmh, String bm, int tinchi)
        {
            mamonhoc = mamh;
            tenmonhoc = tenmh;
            bomon = bm;
            sotinchi = tinchi;
        }
    }
}
