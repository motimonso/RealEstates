using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealEstates.ServerSide
{
    public class Buyer
    {
        private string estateID;
        private string clientID;
        private string estateType;
        private string city;
        private string hood;
        private string roomsFrom;
        private string roomsTo;
        private string ereaFrom;
        private string ereaTo;
        private string floorFrom;
        private string floorTo;
        private string garden;
        private string priceFrom;
        private string priceTo;

        public string EstateID
        {
            get
            {
                return estateID;
            }
        }
        public string ClientID
        {
            get
            {
                return clientID;
            }
        }
        public string EstateType
        {
            get
            {
                return estateType;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
        }
        public string Hood
        {
            get
            {
                return hood;
            }
        }
        public string RoomsFrom
        {
            get
            {
                return roomsFrom;
            }
        }
        public string RoomsTo
        {
            get
            {
                return roomsTo;
            }
        }
        public string EreaFrom
        {
            get
            {
                return ereaFrom;
            }
        }
        public string EreaTo
        {
            get
            {
                return ereaTo;
            }
        }
        public string FloorFrom
        {
            get
            {
                return floorFrom;
            }
        }
        public string FloorTo
        {
            get
            {
                return floorTo;
            }
        }
        public string Garden
        {
            get
            {
                return garden;
            }
        }
        public string PriceFrom
        {
            get
            {
                return priceFrom;
            }
        }
        public string PriceTo
        {
            get
            {
                return priceTo;
            }
        }
        public Buyer(string estateID, string clientID, string estateType, string city,
        string hood, string roomsFrom, string roomsTo, string ereaFrom, string ereaTo,
        string floorFrom, string floorTo, string garden, string priceFrom,  string priceTo)
        {
            this.estateID = estateID;
            this.clientID = clientID;
            this.estateType = estateType;
            this.city = city;
            this.hood = hood;
            this.roomsFrom = roomsFrom;
            this.roomsTo = roomsTo;
            this.ereaFrom = ereaFrom;
            this.ereaTo = ereaTo;
            this.floorFrom = floorFrom;
            this.floorTo = floorTo;
            this.garden = garden;
            this.priceFrom = priceFrom;
            this.priceTo = priceTo;
        }
    }
}