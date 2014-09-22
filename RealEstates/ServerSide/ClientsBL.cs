using RealEstates.serverSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealEstates.ServerSide
{
    public class ClientsBL
    {
        private ClientsDAL cd;
        public ClientsBL()
        {
            cd = new ClientsDAL();

        }
        public bool ClientExist(string cId)
        {
            return cd.ClientExist(cId);
        }
        public void NewClient(string id,string fName,string lName,string phone1,string phone2,string phone3)
        {
            cd.NewClient(id, fName, lName, phone1, phone2, phone3);
        }
        public Client getClientByID(string id)
        {
            return cd.getClientByID(id);
        }
        public string getBuyerNameByEstateID(string estateID)
        {
            return cd.getBuyerNameByEstateID(estateID);
        }
        public Client getFullBuyerByEstateId(string estateId)
        {
            return cd.getFullBuyerByEstateId(estateId);
        }
        public Client getFullSellerByEstateId(string estateId)
        {
            return cd.getFullSellerByEstateId(estateId);
        }
    }
}