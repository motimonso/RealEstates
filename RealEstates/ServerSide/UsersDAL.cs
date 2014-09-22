using RealEstates.ServerSide;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RealEstates.serverSide
{
    public class UsersDAL
    {
        private SqlConnection con;
        public UsersDAL()
        {

            con = new SqlConnection(GeneralMethods.getSqlString());
        }

        public string GetUser(string uName, string uPassword) // Return User Full Name If Exists
        {

            string toReturn = null;
            con.Open();
            string str = "select fullName from Users where Users.userName = '" + uName + "' and Users.userPassword = '" + uPassword + "'";
            SqlCommand comm = new SqlCommand(str, con);
            SqlDataReader reader = comm.ExecuteReader();

            if (reader.Read())
            {
                toReturn = (string)reader[0];
            }
            con.Close();
            reader.Close();
            return toReturn;
        }
        public bool isAdmin(string userName)
        {
            con.Open();
            string str = "select fullName from Users where Users.userName = '" + userName + "' and Users.admin = 'yes'";
            SqlCommand comm = new SqlCommand(str, con);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {
                con.Close();
                reader.Close();
                return true;
            }
            con.Close();
            reader.Close();
            return false;
        }
        
    }
}