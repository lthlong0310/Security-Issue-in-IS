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
            con.Open();
            return con;
        }

        public User Login(User current_user)
        {
            OracleConnection conn = new OracleConnection();
            try
            { 
                conn = Connect(current_user);
                OracleCommand orc = new OracleCommand();
                orc.Connection = conn;
                orc.CommandText = $"select usertype from sec_admin.taikhoan where username = '{current_user.username}'";
                
                var er = orc.ExecuteReader();
                er.Read();
                current_user.usertype = er.GetString(0);
                conn.Close();
                return current_user;
            }
            finally
            {
                conn.Close();
                
            }
        }

    }
}
