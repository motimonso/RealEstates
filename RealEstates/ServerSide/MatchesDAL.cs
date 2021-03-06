﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RealEstates
{
    public class MatchesDAL
    {
        private MySqlConnection con;
        public MatchesDAL()
        {
            con = new MySqlConnection(GeneralMethods.getMySqlString());
        }

        public void InsertMatch(string buyerEID, string sellerEID, string status)
        {
            con.Open();
            string str = "INSERT INTO Matches VALUES ('" + buyerEID + "','" + sellerEID + "',N'" + status + "')";
            MySqlCommand comm = new MySqlCommand(str, con);
            comm.ExecuteNonQuery();
            con.Close();
        }

        public bool MatchExist(string buyerEID, string sellerEID)
        {
            con.Open();
            string str = "select * from Matches where BuyerEstateId='" + buyerEID + "' and SellerEstateId='" + sellerEID + "'";
            MySqlCommand comm = new MySqlCommand(str, con);
            MySqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                con.Close();
                return true;
            }
            reader.Close();
            con.Close();
            return false;
        }

        public LinkedList<Matches> getNewMatches()
        {
            LinkedList<Matches> toReturn = new LinkedList<Matches>();
            con.Open();
            string str = "select * from Matches where status='חדש'";
            MySqlCommand comm = new MySqlCommand(str, con);
            MySqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                Matches m = new Matches((string)reader[0], (string)reader[1], (string)reader[2]);
                toReturn.AddLast(m);

            }
            reader.Close();
            con.Close();
            return toReturn;
        }
        //0-for new matches
        //1-for open matches
        //2-for closed maches
        public LinkedList<Matches> getMatchesByType(int type)
        {
            LinkedList<Matches> toReturn = new LinkedList<Matches>();
            string str = "";
            con.Open();
            if (type == 0)
                str = "select * from Matches where status=N'חדש'";
            else if (type == 1)
                str = "select * from Matches where status=N'פתוח'";
            else if (type == 2)
                str = "select * from Matches where status=N'סגור'";
            MySqlCommand comm = new MySqlCommand(str, con);
            MySqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                Matches m = new Matches((string)reader[0], (string)reader[1], (string)reader[2]);
                toReturn.AddLast(m);

            }
            reader.Close();
            con.Close();
            return toReturn;
        }
        //0-change to open matches
        //1-change to closed maches
        public void changeMatchStatus(int toStatus, string buyerEstateId, string sellerEstateId)
        {
            con.Open();
            string changeTo = "";
            if (toStatus == 0)
                changeTo = "פתוח";
            else if (toStatus == 1)
                changeTo = "סגור";
            string str = "update Matches set Matches.Status=N'" + changeTo + "' where Matches.BuyerEstateId='" + buyerEstateId + "' and Matches.SellerEstateId='" + sellerEstateId + "'";
            MySqlCommand comm = new MySqlCommand(str, con);
            comm.ExecuteNonQuery();
            con.Close();
        }
        public bool isClosed(string buyerEstateId, string sellerEstateId)
        {

            con.Open();
            string str = "select Status from Matches where BuyerEstateId='" + buyerEstateId + "' and SellerEstateId='" + sellerEstateId + "'";
            MySqlCommand comm = new MySqlCommand(str, con);
            MySqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {
                if (((string)reader[0]).Equals("סגור"))
                {
                    reader.Close();
                    con.Close();
                    return true;
                }
            }
            reader.Close();
            con.Close();
            return false;
        }
    }
}