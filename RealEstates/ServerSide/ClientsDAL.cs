using MySql.Data.MySqlClient;
using RealEstates.ServerSide;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RealEstates
{
    public class ClientsDAL
    {
        private MySqlConnection con;
        public ClientsDAL()
        {

            con = new MySqlConnection(GeneralMethods.getMySqlString());
        }
        
        public bool ClientExist(string cId)
        {
            con.Open();
            string str = "select clientId from Clients where Clients.clientId = '" + cId + "'";
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
        public void NewClient(string id,string fName,string lName,string phone1,string phone2,string phone3)
        {
            con.Open();
            string str = "INSERT INTO Clients VALUES ('" + id + "',N'" + fName + "',N'" + lName + "','" + phone1 + "','" + phone2 + "','" + phone3 + "')";
            MySqlCommand comm = new MySqlCommand(str, con);
            comm.ExecuteNonQuery();
            con.Close();
        }

        public Client getClientByID(string id)
        {
            Client toReturn=null ;
            con.Open();
            string str = "select * from Clients where Clients.clientId = '" + id + "'";
            MySqlCommand comm = new MySqlCommand(str, con);
            MySqlDataReader reader = comm.ExecuteReader();

            if (reader.Read())
            {
                toReturn = new Client((string)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], (string)reader[4],(string)reader[5]);
            }
            con.Close();
            reader.Close();
            return toReturn;
        }
        public string getBuyerNameByEstateID(string estateID)
        {
            con.Open();
            string str = "select Clients.firstName,Clients.lastName from Clients,BuyerEstates where BuyerEstates.EstateID='"+estateID+"' and Clients.clientId=BuyerEstates.clientId";
            MySqlCommand comm = new MySqlCommand(str, con);
            MySqlDataReader reader = comm.ExecuteReader();
            string toReturn = "";
            if (reader.Read())
            {
                toReturn = (string)reader[0]+" "+(string)reader[1];
            }
            con.Close();
            reader.Close();
            return toReturn;
        }
        public Client getFullBuyerByEstateId(string estateId)
        {
            Client toReturn = null;
            con.Open();
            string str = "select Clients.clientId, Clients.firstName,Clients.lastName,Clients.phone1,Clients.phone2,Clients.phone3 from Clients,BuyerEstates where BuyerEstates.EstateID='" + estateId + "' and Clients.clientId=BuyerEstates.clientId";
            MySqlCommand comm = new MySqlCommand(str, con);
            MySqlDataReader reader = comm.ExecuteReader();
            
            if (reader.Read())
            {
               toReturn = new Client((string)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], (string)reader[4], (string)reader[5]);
            }
            con.Close();
            reader.Close();
            return toReturn;
        }
        public Client getFullSellerByEstateId(string estateId)
        {
            Client toReturn = null;
            con.Open();
            string str = "select Clients.clientId, Clients.firstName,Clients.lastName,Clients.phone1,Clients.phone2,Clients.phone3 from Clients,SellerEstates where SellerEstates.estateID='" + estateId + "' and Clients.clientId=SellerEstates.sellerId";
            MySqlCommand comm = new MySqlCommand(str, con);
            MySqlDataReader reader = comm.ExecuteReader();

            if (reader.Read())
            {
                toReturn = new Client((string)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], (string)reader[4], (string)reader[5]);
            }
            con.Close();
            reader.Close();
            return toReturn;
        }
    }
}