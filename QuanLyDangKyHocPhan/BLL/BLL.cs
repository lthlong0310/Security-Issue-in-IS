using System;
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

        //public List<GiaoVien> LayDSGiaovien(User current_user)
        //{
        //    var dsgvien = new DAL.DAL().LayDSGiaovienDB(current_user);
        //    return dsgvien;
        //}

        public List<TenMonHoc> LayDSTenMonHoc(User currrent_user)
        {
            List<TenMonHoc> tmh = new List<TenMonHoc>();
            DAL.DAL respon = new DAL.DAL();
            var ds_tenmonhoc = respon.LayDSMon(currrent_user);
            foreach(var ds in ds_tenmonhoc)
            {
                tmh.Add(ds);
            }
            return tmh;
        }

        public List<GiaoVien> LayDSTT_giaovien(User current_user)
        {
            List<GiaoVien> gv = new List<GiaoVien>();
            DAL.DAL respon = new DAL.DAL();
            var ds_gv = respon.LayDSGiaoVien_From_DB(current_user);
            foreach(var ds in ds_gv)
            {
                gv.Add(ds);
            }
            return gv;
        }
   }
}
