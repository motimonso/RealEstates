using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealEstates.ServerSide
{
    public class Matches
    {
        private string buyerEstateId;
        private string sellerEstateId;
        private string matchStatus;
        
        public string BuyerEstateId
        {
            get
            {
                return buyerEstateId;
            }
        }
        public string SellerEstateId
        {
            get
            {
                return sellerEstateId;
            }
        }
        public string MatchStatus
        {
            get
            {
                return matchStatus;
            }
        }
        public Matches(string buyerEstateId,string sellerEstateId,string matchStatus)
        {
            this.matchStatus=matchStatus;
            this.buyerEstateId = buyerEstateId;
            this.sellerEstateId = sellerEstateId;
        }
    }
}