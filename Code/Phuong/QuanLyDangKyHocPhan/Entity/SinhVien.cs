using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class SinhVien
    {
        public String mssv { get; set; }
        public String hotensv { get; set; }
        public String lopsv { get; set; }
        public String dobsv { get; set; }
        public String diachisv { get; set; }
        public String gioitinhsv { get; set; }
        public String cmndsv { get; set; }
        public String sdtsv { get; set; }
        public String emailsv { get; set; }

        public SinhVien(String id, String ten, String lop, String dob, String dchi, String gt, String cmnd, String sdt, String email)
        {
            mssv = id;
            hotensv = ten;
            lopsv = lop;
            dobsv = dob;
            diachisv = dchi;
            gioitinhsv = gt;
            cmndsv = cmnd;
            sdtsv = sdt;
            emailsv = email;
        }
    }
}
