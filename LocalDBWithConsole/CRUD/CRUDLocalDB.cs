using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocalDBWithConsole.model;

namespace LocalDBWithConsole.CRUD
{
    class CRUDLocalDB
    {
        private SqlConnection conn;
        string conns = ConfigurationManager.ConnectionStrings["dbLocal"].ConnectionString;
        public CRUDLocalDB()
        {
            conn = new SqlConnection(conns);
        }

        public SqlConnection getConn()
        {
            return conn;
        }

        public bool pushUser(UserLocalDB userLocalDb)
        {
            conn.ConnectionString = conns;
            using (conn)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_PushAccout", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", userLocalDb.username);
                cmd.Parameters.AddWithValue("@pass", userLocalDb.password);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    return true;
                }
            }
            return false;
        }

        public bool delUser(string username)
        {
            conn.ConnectionString = conns;
            using (conn)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_delData", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool updateUser(UserLocalDB userLocalDb, string oldUser)
        {
            conn.ConnectionString = conns;
            using (conn)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_editData", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@oldUser", oldUser);
                cmd.Parameters.AddWithValue("@newUser", userLocalDb.username);
                cmd.Parameters.AddWithValue("@password", userLocalDb.password);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public void showData()
        {
            Console.WriteLine("Username\t||\tPassword");
            conn.ConnectionString = conns;
            using (conn)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_getData", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Console.WriteLine(dataReader["username"] + "\t\t||\t\t" + dataReader["pass"]);
                    }
                }
                
            }
        }
    }
}
