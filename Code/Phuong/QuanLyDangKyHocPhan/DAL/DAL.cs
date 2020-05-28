using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public class DAL
    {
        public OracleConnection Connect(User current_user)
        {
            //Create a connection String to Oracle
            //string connectionString = "User Id=ot; password=yourpassword;" +

            //Connect Format is [hostname]:[port]/[service_name]
            //"Data Source=localhost:1521/xe; Pooling=false;";
            OracleConnection con = new OracleConnection();
            OracleConnectionStringBuilder cnstr = new OracleConnectionStringBuilder();
            cnstr.UserID = current_user.username;
            cnstr.Password = current_user.password;
            cnstr.DataSource = "localhost:1521/xe";
            //con.ConnectionString = connectionString;
            con.ConnectionString = cnstr.ConnectionString;
            return con;
        }

        public User Login(User current_user)
        {
            OracleConnection conn = new OracleConnection();
            conn = Connect(current_user);
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"select usertype from sec_admin.taikhoan where username = '{current_user.username}'";
                
                var er = cmd.ExecuteReader();
                er.Read();
                current_user.usertype = er.GetString(0);
                conn.Close();
                return current_user;
            }
            catch(OracleException)
            {
                conn.Close();
                return current_user;
            }
            finally
            {
                conn.Close();
                
            }
        }

        public List<Lop> LayDSLopDB(User current_user)
        {
            OracleConnection conn = new OracleConnection();
            conn = Connect(current_user);
            List<Lop> dslop = new List<Lop>();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"Select * from sec_admin.lop";

                var er = cmd.ExecuteReader();
                
                while(!er.Read())
                {
                    String malop;
                    if (!er.IsDBNull(0))
                        malop = "";
                    else malop = er.GetString(0);
                    String tenlop;
                    if (!er.IsDBNull(1))
                        tenlop = "";
                    else tenlop = er.GetString(1);

                    var lop = new Lop(malop, tenlop);
                    dslop.Add(lop);
                }
                conn.Close();
                return dslop;
            }
            catch
            {
                conn.Close();
                return dslop;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<GiaoVien> LayDSGiaovienDB(User current_user)
        {
            OracleConnection conn = new OracleConnection();
            conn = Connect(current_user);
            List<GiaoVien> dsgvien = new List<GiaoVien>();
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"Select * from sec_admin.lop where loaigiaovien = '0'";

                var er = cmd.ExecuteReader();
                
                while (!er.Read())
                {
                    String magiaovien;
                    if (!er.IsDBNull(0))
                        magiaovien = "";
                    else magiaovien = er.GetString(0);
                    String tengiaovien;
                    if (!er.IsDBNull(1))
                        tengiaovien = "";
                    else tengiaovien = er.GetString(1);
                    String dob;
                    if (!er.IsDBNull(2))
                        dob = null;
                    else dob = er.GetDateTime(2).ToString();
                    String dchi;
                    if (!er.IsDBNull(2))
                        dchi = "";
                    else dchi = er.GetString(2);
                    String gt;
                    if (!er.IsDBNull(3))
                        gt = "";
                    else gt = er.GetString(3);
                    String cmnd;
                    if (!er.IsDBNull(4))
                        cmnd = "";
                    else cmnd = er.GetString(4);
                    String sdt;
                    if (!er.IsDBNull(5))
                        sdt = "";
                    else sdt = er.GetString(5);
                    String email;
                    if (!er.IsDBNull(6))
                        email = "";
                    else email = er.GetString(6);
                    String bomon;
                    if (!er.IsDBNull(7))
                        bomon = "";
                    else bomon = er.GetString(7);
                    String trgbm;
                    if (!er.IsDBNull(8))
                        trgbm = "";
                    else trgbm = er.GetString(8);

                    var gvien = new GiaoVien(magiaovien, tengiaovien, dob, dchi, gt, cmnd, sdt, email, bomon, trgbm);
                    dsgvien.Add(gvien);
                }
                conn.Close();
                return dsgvien;
            }
            catch(OracleException)
            {
                conn.Close();
                return dsgvien;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
