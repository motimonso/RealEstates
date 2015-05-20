using RealEstates.ServerSide;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace RealEstates
{
    public class MatchesBL
    {
        private MatchesDAL md;

        public MatchesBL()
        {
            md = new MatchesDAL();
        }
        public void InsertMatch(string buyerEID, string sellerEID, string status)
        {
            md.InsertMatch(buyerEID,sellerEID,status);
        }

        public bool MatchExist(string buyerEID, string sellerEID)
        {
            return md.MatchExist(buyerEID,sellerEID);
        }

        public bool isMatch(Buyer b,Seller s)
        {
            
            if (s.SellerID.Equals(b.ClientID) )
                return false;
            if (!s.EstateType.Equals(b.EstateType))
                return false;
            if (b.Hood.Equals("") && !b.City.Equals(s.City))
                return false;
            if (!b.Hood.Equals("") && (!b.Hood.Equals(s.Hood)) || !b.City.Equals(s.City) )
                return false;
            
            int roomsFrom,roomsTo,roomsSell;
            roomsFrom = Int32.Parse(b.RoomsFrom);
            roomsTo = Int32.Parse(b.RoomsTo);
            roomsSell = Int32.Parse(s.Rooms);
            if(roomsSell>roomsTo || roomsSell<roomsFrom)
                return false;
            
            int ereaFrom,ereaTo,ereaSell;
            ereaFrom = Int32.Parse(b.EreaFrom);
            ereaTo = Int32.Parse(b.EreaTo);
            ereaSell = Int32.Parse(s.Erea);
            if(ereaSell>ereaTo || ereaSell<ereaFrom)
                return false;

            int floorFrom,floorTo,floorSell;
            string fFrom=b.FloorFrom , fTo=b.FloorTo , fSell=s.Floor;
            if (fFrom.Equals("קרקע"))
                fFrom="0";
            if (fTo.Equals("קרקע"))
                fTo="0";
            if (fSell.Equals("קרקע"))
                fSell="0";
            if (fFrom.Equals("20+"))
                fFrom="20";
            if (fTo.Equals("20+"))
                fTo="20";
            if (fSell.Equals("20+"))
                fSell="20";

            floorFrom=Int32.Parse(fFrom);
            floorTo = Int32.Parse(fTo);
            floorSell = Int32.Parse(fSell);
            if(floorSell>floorTo || floorSell<floorFrom)
                return false;

            if (b.Garden.Equals("כן") && s.Garden.Equals("0") )
                return false;

            int priceFrom, priceTo, priceSell;
            priceFrom = Int32.Parse(b.PriceFrom);
            priceTo = Int32.Parse(b.PriceTo);
            priceSell = Int32.Parse(s.Price);
            if (priceSell > priceTo || priceSell < priceFrom)
                return false;

            return true;
        }

        public void autoMatch()
        {
            BuyerEstateBL bebl=new BuyerEstateBL();
            SellerEstateBL sebl = new SellerEstateBL();
            LinkedList<Buyer> buyerList = bebl.getAllBuyers();
            LinkedList<Seller> sellerList = sebl.getAllSellers();

            foreach(Buyer b in buyerList)
            {
                foreach(Seller s in sellerList)
                {
                    if (isMatch(b, s) && !MatchExist(b.EstateID, s.EstateID))
                        InsertMatch(b.EstateID, s.EstateID, "חדש");


                }
            }
        }

        //0-for new matches
        //1-for open matches
        //2-for closed maches
        public LinkedList<Matches> getMatchesByType(int type)
        {
            return md.getMatchesByType(type);
        }

        //0-change to open matches
        //1-change to closed maches
        public void changeMatchStatus(int toStatus, string buyerEstateId, string sellerEstateId)
        {
            md.changeMatchStatus(toStatus, buyerEstateId, sellerEstateId);
        }
        public bool isClosed(string buyerEstateId, string sellerEstateId)
        {
            return md.isClosed(buyerEstateId, sellerEstateId);
        }
    }
}