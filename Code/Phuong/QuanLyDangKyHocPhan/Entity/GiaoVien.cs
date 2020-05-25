﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class GiaoVien
    {
        public String magv { get; set; }
        public String tengv { get; set; }
        public String dobgv { get; set; }
        public String diachigv { get; set; }
        public String gioitinhgv { get; set; }
        public String cmndgv { get; set; }
        public String sdtgv { get; set; }
        public String emailgv { get; set; }
        public String bomon { get; set; }

        public GiaoVien(String ma, String ten, String dob, String dchi, String gt, String cmnd, String sdt, String email, String bm)
        {
            magv = ma;
            tengv = ten;
            dobgv = dob;
            diachigv = dchi;
            gioitinhgv = gt;
            cmndgv = cmnd;
            sdtgv = sdt;
            emailgv = email;
            bomon = bm;
            
        }
    }
}
