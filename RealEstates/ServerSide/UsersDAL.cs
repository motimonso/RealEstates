using MySql.Data.MySqlClient;
using RealEstates.ServerSide;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace RealEstates
{
    public class UsersDAL
    {
        private MySqlConnection con;
        public UsersDAL()
        {

            con = new MySqlConnection(GeneralMethods.getMySqlString());
        }

        public string GetUser(string uName, string uPassword) // Return User Full Name If Exists
        {

            string toReturn = null;
            con.Open();
            string str = "select fullName from Users where Users.userName = '" + uName + "' and Users.userPassword = '" + uPassword + "'";
            MySqlCommand comm = new MySqlCommand(str, con);
            MySqlDataReader reader = comm.ExecuteReader();

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
            MySqlCommand comm = new MySqlCommand(str, con);
            MySqlDataReader reader = comm.ExecuteReader();
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