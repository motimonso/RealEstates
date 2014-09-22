using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RealEstates.ServerSide
{
    public class MatchesDAL
    {
        private SqlConnection con;
        public MatchesDAL()
        {
            con = new SqlConnection(GeneralMethods.getSqlString());
        }

        public void InsertMatch(string buyerEID, string sellerEID , string status)
        {
            con.Open();
            string str = "INSERT INTO Matches VALUES ('" + buyerEID + "','" + sellerEID + "',N'" + status+ "')";
            SqlCommand comm = new SqlCommand(str, con);
            comm.ExecuteNonQuery();
            con.Close();
        }

        public bool MatchExist(string buyerEID, string sellerEID)
        {
            con.Open();
            string str = "select * from Matches where BuyerEstateId='" + buyerEID + "' and SellerEstateId='"+sellerEID+"'";
            SqlCommand comm = new SqlCommand(str, con);
            SqlDataReader reader = comm.ExecuteReader();
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
            SqlCommand comm = new SqlCommand(str, con);
            SqlDataReader reader = comm.ExecuteReader();
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
            string str="";
            con.Open();
            if(type==0)
                str = "select * from Matches where status=N'חדש'";
            else if(type==1)
                str = "select * from Matches where status=N'פתוח'";
            else if(type==2)
                str = "select * from Matches where status=N'סגור'";
            SqlCommand comm = new SqlCommand(str, con);
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                Matches m = new Matches((string)reader[0], (string)reader[1], (string)reader[2]);
                toReturn.AddLast(m);

            }
            reader.Close();
            con.Close();
            return toReturn;
        }
    }
}