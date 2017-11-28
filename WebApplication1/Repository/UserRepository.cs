using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Repository
{
    public class UserRepository : IUserRepository
    {
        SqlConnection cn;
        Conexion con = new Conexion();
        public bool updateUser(int id, int score)
        {
            cn = con.getCon();
            bool ban = false;
            try {
                SqlCommand cmd = new SqlCommand("updateUser", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@score", score);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                cn.Close();

                if (i >= 1)
                {
                    ban=true;
                }
                else
                {
                    ban=false;
                }
            }
            catch(Exception ex)
            {
            }
            return ban;
        }
    }
}