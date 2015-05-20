using RealEstates.ServerSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealEstates.ServerSide
{
    public class BuyerEstateBL
    {
       private BuyerEstateDAL bd;

        public  BuyerEstateBL()
        {
            bd = new BuyerEstateDAL();
        }
        public void NewBuyerEstate(string buyerID, string estateType, string city, string hood,
             string roomFrom, string roomTo, string areaFrom, string areaTo, string floorFrom,
            string floorTo, string garden, string priceFrom, string priceTo)
        {
            bd.NewBuyerEstate(buyerID, estateType, city, hood,
             roomFrom, roomTo, areaFrom, areaTo, floorFrom,
             floorTo, garden, priceFrom, priceTo);
        }
        public LinkedList<Buyer> getAllBuyers()
        {
            return bd.getAllBuyers();
        }
    }
}