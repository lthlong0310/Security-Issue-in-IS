using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Object;
using Data_Access_Layer;
namespace Business_Logic_Layer
{
    public class BLL
    {
       public List<DanhSachUser> get_DsUser()
        {
            List<DanhSachUser> ds = new List<DanhSachUser>();
            DAL respon = new DAL();
            var ds_user = respon.Get_DsUser_From_Database();
            foreach(var us in ds_user)
            {
                ds.Add(us);
            }
            return ds;
        }

        public List<Entity_Object.Object> get_DsObject()
        {
            DAL respon = new DAL();
            var objs = respon.Get_Objects_From_Database();
           
            return objs;
        }
        public List<DanhSachUser> get_DsRole()
        {
            List<DanhSachUser> ds = new List<DanhSachUser>();
            DAL respon = new DAL();
            var ds_role = respon.Get_DsRole_From_Database();
            foreach (var us in ds_role)
            {
                ds.Add(us);
            }
            return ds;
        }
        public List<Quyen> Lay_DsQuyen(string gt)
        {
            List<Quyen> qu = new List<Quyen>();
            DAL respon = new DAL();
            var ds_quyen = respon.Lay_DSQuyen_From_Database(gt);
            foreach(var quyen in ds_quyen)
            {
                qu.Add(quyen);
            }
            return qu;
        }
       public DanhSachUser Drop_user(DanhSachUser danhsach)
        {
            var respon = new DAL();
            return respon.Drop_user_In_Database(danhsach);
        }

       public User Create_user(User nguoidung)
        {
            var respon = new DAL();
            return respon.Create_user_In_Database(nguoidung);
        }
        public DanhSachUser Create_role(DanhSachUser danhsach)
        {
            var respon = new DAL();
            return respon.Create_role_In_Database(danhsach);
        }
        public DanhSachUser Drop_role(DanhSachUser danhsach)
        {
            var respon = new DAL();
            return respon.Drop_role_In_Database(danhsach);
        }
        public CapQuyen Grant_privs(CapQuyen capquyen)
        {
            var respon = new DAL();
            return respon.Grant_Priv_In_Database(capquyen);
        }
        public CapQuyen Revoke_privs(CapQuyen capquyen)
        {
            var respon = new DAL();
            return respon.Revoke_Priv_In_Database(capquyen);
        }
        public CapQuyenOption Grant_privs_option(CapQuyenOption capquyenoption)
        {
            var respon = new DAL();
            return respon.Grant_Priv_With_Admin_Option_In_Database(capquyenoption);
        }
    }
}
