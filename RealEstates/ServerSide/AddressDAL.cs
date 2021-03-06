﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace RealEstates
{
    public class AddressDAL
    {
        private MySqlConnection con;
        public AddressDAL()
        {
           
            con = new MySqlConnection(GeneralMethods.getMySqlString());
        }

        public LinkedList<ListItem> getAllCities()
        {
            con.Open();
            string str = "select * from Cities";
            
            MySqlCommand comm = new MySqlCommand(str, con);
            MySqlDataReader reader = comm.ExecuteReader();
            LinkedList<ListItem> toReturn = new LinkedList<ListItem>();
            while (reader.Read()) 
            {
                toReturn.AddLast(new ListItem((string)reader[1],reader[0].ToString()));
            }
            con.Close();
            reader.Close();
            return toReturn;
        }
        public LinkedList<ListItem> getAllHood(string city)
        {
            con.Open();
            string str = "select HoodID,HoodName from Neighborhood where CityID='"+city+"'";

            MySqlCommand comm = new MySqlCommand(str, con);
            MySqlDataReader reader = comm.ExecuteReader();
            LinkedList<ListItem> toReturn = new LinkedList<ListItem>();
            while (reader.Read())
            {
                toReturn.AddLast(new ListItem((string)reader[1],reader[0].ToString()));
            }
            con.Close();
            reader.Close();
            return toReturn;
        }
        public LinkedList<ListItem> getAllStreet(string hood)
        {
            con.Open();
            string str = "select StreetID,StreetName from Streets where HoodID='" + hood + "'";

            MySqlCommand comm = new MySqlCommand(str, con);
            MySqlDataReader reader = comm.ExecuteReader();
            LinkedList<ListItem> toReturn = new LinkedList<ListItem>();
            while (reader.Read())
            {
               
                toReturn.AddLast(new ListItem((string)reader[1], reader[0].ToString()));
            }
            con.Close();
            reader.Close();
            return toReturn;
        }
    }
}