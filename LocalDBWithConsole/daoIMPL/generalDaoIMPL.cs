using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocalDBWithConsole.dao;
using LocalDBWithConsole.DB;
using LocalDBWithConsole.model;

namespace LocalDBWithConsole.daoIMPL
{
    class generalDaoIMPL : GeneralDAO
    {
        private SqlConnection conn;

        public generalDaoIMPL()
        {
            conn = DBConn.getConn();
        }

        public void pushData(UserLocalDB userLocalDb)
        {
            using (conn)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_PushAccout", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", userLocalDb.username);
                cmd.Parameters.AddWithValue("@pass", userLocalDb.password);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    Console.WriteLine("data inserted");
                }
                else
                {
                    Console.WriteLine("data inserted");
                }
            }
        }

        public void getData()
        {
            Console.WriteLine("Username\t||\tPassword");
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

        public bool delData(string username)
        {
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
    }
}
