using MySql.Data.MySqlClient;
using RealEstates.ServerSide;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RealEstates.serverSide
{
    public class BuyerEstateDAL
    {
        private MySqlConnection con;
        public BuyerEstateDAL()
        {
            con = new MySqlConnection(GeneralMethods.getSqlString());
        }
        public void NewBuyerEstate(string buyerID, string estateType,  string city, string hood, 
             string roomFrom, string roomTo, string areaFrom, string areaTo, string floorFrom,
            string floorTo, string garden, string priceFrom, string priceTo)
        {
            string estateIDGen = GeneralMethods.generateID();
            con.Open();
            string str = "INSERT INTO BuyerEstates VALUES ('" +estateIDGen + "','" + buyerID + "',N'" + estateType + "',N'" + city
                + "',N'" + hood + "','" + roomFrom + "','" +roomTo + "','" + areaFrom + "','" + areaTo 
                + "',N'" + floorFrom + "',N'" + floorTo + "',N'" + garden
                + "','" + priceFrom + "',N'" + priceTo + "')";
            MySqlCommand comm = new MySqlCommand(str, con);
            comm.ExecuteNonQuery();
            con.Close();
        }
        public LinkedList<Buyer> getAllBuyers()
        {
            LinkedList<Buyer> toReturn = new LinkedList<Buyer>();
            con.Open();
            string str = "select * from BuyerEstates";
            MySqlCommand comm = new MySqlCommand(str, con);
            MySqlDataReader reader = comm.ExecuteReader();

            while(reader.Read())
            {
                Buyer b = new Buyer((string)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], 
                    (string)reader[4], (string)reader[5], (string)reader[6], (string)reader[7], (string)reader[8], 
                    (string)reader[9], (string)reader[10], (string)reader[11], (string)reader[12], (string)reader[13]);
                toReturn.AddLast(b);
            }
            con.Close();
            reader.Close();
            return toReturn;
        }
       

    }
}