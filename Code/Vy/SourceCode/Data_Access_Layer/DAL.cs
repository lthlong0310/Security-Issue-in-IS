using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Entity_Object;
using System.Data;

namespace Data_Access_Layer
{
    public class DAL
    {
        public OracleConnection Connect()
        {
            //Create a connection String to Oracle
            string connectionString = "User Id=dbadmin; password=dbadmin;" +

            //Connect Format is [hostname]:[port]/[service_name]
            "Data Source=localhost:1521/orcl; Pooling=false;";
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectionString;
            con.Open();
            return con;
        }

        public DataSet get_log()
        {
            OracleConnection conn = Connect();
            string command = "select username, owner, obj_name, action_name, sql_text, EXTENDED_TIMESTAMP from DBA_AUDIT_TRAIL";
            OracleDataAdapter adapter = new OracleDataAdapter(command, conn);
            var ds = new DataSet();
            adapter.Fill(ds);
            conn.Close();
            return ds;
        }

        public List<DanhSachUser> Get_DsUser_From_Database()
        {
            var dsuser = new List<DanhSachUser>();
            OracleConnection conn = Connect();
            OracleCommand orc = new OracleCommand();
            orc.Connection = conn;
            orc.CommandText = "select username from all_users";
            var er = orc.ExecuteReader();
            while(er.Read())
            {
                dsuser.Add(new DanhSachUser(er.GetString(0)));
            }
            conn.Close();
            return dsuser;
        }
        public List<DanhSachUser> Get_DsRole_From_Database()
        {
            var dsrole = new List<DanhSachUser>();
            OracleConnection conn = Connect();
            OracleCommand orc = new OracleCommand();
            orc.Connection = conn;
            orc.CommandText = "select granted_role from dba_role_privs";
            var er = orc.ExecuteReader();
            while (er.Read())
            {
                dsrole.Add(new DanhSachUser(er.GetString(0)));
            }
            conn.Close();
            return dsrole;
        }
        public List<Quyen> Lay_DSQuyen_From_Database(string grantee)
        {
            var dsquyen = new List<Quyen>();
            OracleConnection conn = Connect();
            OracleCommand orc = new OracleCommand();
            orc.Connection = conn;
            orc.CommandText = $"select * from dba_sys_privs where grantee = '{grantee}'";
            var er = orc.ExecuteReader();
            while(er.Read())
            {
                var quyen = new Quyen();
                quyen.grantee = er.GetString(0);
                quyen.privilege = er.GetString(1);
                quyen.admin_option = er.GetString(2);
                quyen.common = er.GetString(3);
                quyen.inheritied = er.GetString(4);
                dsquyen.Add(quyen);
            }
            conn.Close();
            return dsquyen;
        }

        public List<USER_OBJECT> GetAllUserObject()
        {
            var userTables = new List<USER_OBJECT>();
            OracleConnection conn = Connect();
            OracleCommand orc = new OracleCommand();
            orc.Connection = conn;
            orc.CommandText = "SELECT OBJECT_NAME FROM USER_OBJECTS WHERE OBJECT_TYPE IN ('TABLE', 'FUNCTION', 'PROCEDURE', 'VIEW')";
            var er = orc.ExecuteReader();
            while (er.Read())
            {
                userTables.Add(new USER_OBJECT(er.GetString(0)));
            }
            conn.Close();
            return userTables;
        }

        public bool Audit(string username, List<string> actions, bool successful, bool notsuccessful)
        {
            OracleConnection conn = Connect();
            try
            {
                OracleCommand orc = new OracleCommand();
                orc.Connection = conn;
                string action = "";
                foreach (var item in actions)
                {
                    action += item + ",";
                }
                action = action.Remove(action.Length - 1);

                orc.CommandText = $"AUDIT {action} BY {username}";
                orc.ExecuteNonQuery();

                if (successful)
                {
                    orc.CommandText = $"AUDIT {action} BY {username} WHENEVER SUCCESSFUL";
                    orc.ExecuteNonQuery();
                }

                if (notsuccessful)
                {
                    orc.CommandText = $"AUDIT {action} BY {username} WHENEVER NOT SUCCESSFUL";
                    orc.ExecuteNonQuery();
                }
                orc.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                conn.Close();
                return false;
            }
        }

        public DanhSachUser Drop_user_In_Database(DanhSachUser ds)
        {
            OracleConnection conn = Connect();
            OracleCommand orc = new OracleCommand();
            orc.Connection = conn;
            //            string s = @"''_ORACLE_SCRIPT''";
            orc.CommandText = "sp_drop_user";
            orc.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = $"{ds.username}";
            orc.CommandType = System.Data.CommandType.StoredProcedure;
            //$"begin execute sp_drop_user('{ds.username}'); end;";
            orc.ExecuteNonQuery();            
            conn.Close();
            return ds;
        }
        public User Create_user_In_Database(User ng)
        {
            OracleConnection conn = Connect();
            OracleCommand orc = new OracleCommand();
            orc.Connection = conn;
            orc.CommandText = "sp_create_user";
            orc.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = $"{ng.username}";
            orc.Parameters.Add(new OracleParameter("password", OracleDbType.Varchar2)).Value = $"{ng.password}";
            orc.CommandType = System.Data.CommandType.StoredProcedure;
            orc.ExecuteNonQuery();
            conn.Close();
            return ng;
        }
        public DanhSachUser Create_role_In_Database(DanhSachUser ds)
        {
            OracleConnection conn = Connect();
            OracleCommand orc = new OracleCommand();
            orc.Connection = conn;
            orc.CommandText = "sp_create_role";
            orc.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = $"{ds.username}";
            orc.CommandType = System.Data.CommandType.StoredProcedure;
            orc.ExecuteNonQuery();
            conn.Close();
            return ds;
        }
        public DanhSachUser Drop_role_In_Database(DanhSachUser ds)
        {
            OracleConnection conn = Connect();
            OracleCommand orc = new OracleCommand();
            orc.Connection = conn;
            orc.CommandText = "sp_drop_role";
            orc.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = $"{ds.username}";
            orc.CommandType = System.Data.CommandType.StoredProcedure;
            orc.ExecuteNonQuery();
            conn.Close();
            return ds;
        }
        public CapQuyen Grant_Priv_In_Database(CapQuyen cq)
        {
            OracleConnection conn = Connect();
            OracleCommand orc = new OracleCommand();
            orc.Connection = conn;
            orc.CommandText = "sp_grant_user";
            orc.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = $"{cq.username}";
            orc.Parameters.Add(new OracleParameter("name_privs", OracleDbType.Varchar2)).Value = $"{cq.name_privs}";
            orc.CommandType = System.Data.CommandType.StoredProcedure;
            orc.ExecuteNonQuery();
            conn.Close();
            return cq;
        }

        public CapQuyen Revoke_Priv_In_Database(CapQuyen cq)
        {
            OracleConnection conn = Connect();
            OracleCommand orc = new OracleCommand();
            orc.Connection = conn;
            orc.CommandText = "sp_revoke_user";
            orc.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = $"{cq.username}";
            orc.Parameters.Add(new OracleParameter("name_privs", OracleDbType.Varchar2)).Value = $"{cq.name_privs}";
            orc.CommandType = System.Data.CommandType.StoredProcedure;
            orc.ExecuteNonQuery();
            conn.Close();
            return cq;
        }
        public CapQuyenOption Grant_Priv_With_Admin_Option_In_Database(CapQuyenOption cq)
        {
            OracleConnection conn = Connect();
            OracleCommand orc = new OracleCommand();
            orc.Connection = conn;
            orc.CommandText = "sp_grant";
            orc.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = $"{cq.username}";
            orc.Parameters.Add(new OracleParameter("name_privs", OracleDbType.Varchar2)).Value = $"{cq.name_privs}";
            orc.Parameters.Add(new OracleParameter("option", OracleDbType.Varchar2)).Value = $"{cq.option}";
            orc.CommandType = System.Data.CommandType.StoredProcedure;
            orc.ExecuteNonQuery();
            conn.Close();
            return cq;
        }
    }
}
