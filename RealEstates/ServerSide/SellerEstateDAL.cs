using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RealEstates.ServerSide
{
    public class SellerEstateDAL
    {
         private SqlConnection con;
         public SellerEstateDAL()
        {
            con = new SqlConnection(GeneralMethods.getSqlString());
        }
         public void NewSellerEstate(string sellerID,string estateType, string price, string city, string hood, string street,
             string number, string numOfBedroom, string area, string floor, string stairs, string elavator,
             string numOfBalcony, string toilet, string shower, string storge, string parking, string garden,
             string renovate, string boyler, string bars, string pladelet)
         {
             string estateIDGen = GeneralMethods.generateID();
             con.Open();
             string str = "INSERT INTO SellerEstates VALUES ('" + estateIDGen + "',N'" + sellerID + "',N'" + estateType + "','" + price + "',N'" + city
                 + "',N'" + hood + "',N'" + street + "',N'" + number + "','" + numOfBedroom + "','" + area
                 + "',N'" + floor + "',N'" + stairs + "',N'" + elavator + "','" + numOfBalcony + "','" + toilet
                 + "','" + shower + "',N'" + storge + "',N'" + parking + "','" + garden + "',N'" + renovate
                 + "',N'" + boyler + "',N'" + bars + "',N'" + pladelet + "')";
             SqlCommand comm = new SqlCommand(str, con);
             comm.ExecuteNonQuery();
             con.Close();
         }
         public LinkedList<Seller> getAllSellers()
         {
             LinkedList<Seller> toReturn = new LinkedList<Seller>();
             con.Open();
             string str = "select * from SellerEstates";
             SqlCommand comm = new SqlCommand(str, con);
             SqlDataReader reader = comm.ExecuteReader();

             while (reader.Read())
             {
                 Seller b = new Seller((string)reader[0], (string)reader[1], (string)reader[2], (string)reader[3],
                     (string)reader[4], (string)reader[5], (string)reader[6], (string)reader[7], (string)reader[8],
                     (string)reader[9], (string)reader[10], (string)reader[11], (string)reader[12], (string)reader[13],
                     (string)reader[14], (string)reader[15], (string)reader[16], (string)reader[17], (string)reader[18], 
                     (string)reader[19], (string)reader[20], (string)reader[21], (string)reader[22]);
                 toReturn.AddLast(b);
             }
             con.Close();
             reader.Close();
             return toReturn;
         }
        public string getFullAddressByEstateID(string id)
         {
             con.Open();
             string str = "select city,neighborhood,street,number from SellerEstates where SellerEstates.EstateID='" + id + "'";
             SqlCommand comm = new SqlCommand(str, con);
             SqlDataReader reader = comm.ExecuteReader();
             string toReturn = "";
             if (reader.Read())
             {
                 toReturn = (string)reader[0] + " " + (string)reader[1] + " " + (string)reader[2] + " " + (string)reader[3];
             }
             con.Close();
             reader.Close();
             return toReturn;
         }
        public Seller getFullSellerByEstateId(string estateId)
        {
            Seller toReturn = null;
            con.Open();
            string str = "select * from SellerEstates where SellerEstates.estateId='"+estateId+"'";
            SqlCommand comm = new SqlCommand(str, con);
            SqlDataReader reader = comm.ExecuteReader();

           if(reader.Read())
            {
                 toReturn = new Seller((string)reader[0], (string)reader[1], (string)reader[2], (string)reader[3],
                    (string)reader[4], (string)reader[5], (string)reader[6], (string)reader[7], (string)reader[8],
                    (string)reader[9], (string)reader[10], (string)reader[11], (string)reader[12], (string)reader[13],
                    (string)reader[14], (string)reader[15], (string)reader[16], (string)reader[17], (string)reader[18],
                    (string)reader[19], (string)reader[20], (string)reader[21], (string)reader[22]);
               
            }
            con.Close();
            reader.Close();
            return toReturn;
        }
        public LinkedList<Seller> SearchSellers(string city, string hood, string kind)
        {
            LinkedList<Seller> toReturn = new LinkedList<Seller>();
            con.Open();

            string str = "select * from SellerEstates where ";
            if (!city.Equals("0") && !hood.Equals("0") && !kind.Equals("0"))
                str += "SellerEstates.city=N'" + city + "' and SellerEstates.neighborhood=N'" + hood + "' and SellerEstates.estateType=N'" + kind + "'";
            if (!city.Equals("0") && !hood.Equals("0") && kind.Equals("0"))
                str += "SellerEstates.city=N'" + city + "' and SellerEstates.neighborhood=N'" + hood + "'";
            if (city.Equals("0") && hood.Equals("0") && !kind.Equals("0"))
                str += "SellerEstates.estateType=N'" + kind + "'";
            if (!city.Equals("0") && hood.Equals("0") && !kind.Equals("0"))
                str += "SellerEstates.city=N'" + city + "' and SellerEstates.estateType=N'" + kind + "'";
            if (!city.Equals("0") && hood.Equals("0") && kind.Equals("0"))
                str += "SellerEstates.city=N'" + city + "'"; 
            SqlCommand comm = new SqlCommand(str, con);
            SqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                Seller b = new Seller((string)reader[0], (string)reader[1], (string)reader[2], (string)reader[3],
                    (string)reader[4], (string)reader[5], (string)reader[6], (string)reader[7], (string)reader[8],
                    (string)reader[9], (string)reader[10], (string)reader[11], (string)reader[12], (string)reader[13],
                    (string)reader[14], (string)reader[15], (string)reader[16], (string)reader[17], (string)reader[18],
                    (string)reader[19], (string)reader[20], (string)reader[21], (string)reader[22]);
                toReturn.AddLast(b);
            }
            con.Close();
            reader.Close();
            return toReturn;
        }

    }
}