﻿using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using DAL;

namespace BLL
{
    public class BLL
    {
        public User Login(User current_user)
        {
            current_user = new DAL.DAL().Login(current_user);
            return current_user;
        }


        public List<Lop> LayDSLop(User current_user)
        {
            var dslop = new DAL.DAL().LayDSLopDB(current_user);
            return dslop;
        }

        public List<GiaoVien> LayDSGiaovien(User current_user)
        {
            var dsgvien = new DAL.DAL().LayDSGiaovienDB(current_user);
            return dsgvien;
        }
    }
}