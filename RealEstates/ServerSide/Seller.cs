using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealEstates.ServerSide
{
    public class Seller
    {
        private string estateID;
        private string sellerID;
        private string estateType;
        private string price;
        private string city;
        private string hood;
        private string street;
        private string number;
        private string rooms;
        private string erea;
        private string floor;
        private string stairs;
        private string elavator;
        private string balcony;
        private string toilets;
        private string bath;
        private string storage;
        private string park;
        private string garden;
        private string renovation;
        private string bars;
        private string boiler;
        private string pladelet;

        public string EstateID
        {
            get
            {
                return estateID;
            }
        }
        public string SellerID
        {
            get
            {
                return sellerID;
            }
        }
        public string EstateType
        {
            get
            {
                return estateType;
            }
        }
        public string Price
        {
            get
            {
                return price;
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
        public string Street
        {
            get
            {
                return street;
            }
        }
        public string Number
        {
            get
            {
                return number;
            }
        }
        public string Rooms
        {
            get
            {
                return rooms;
            }
        }
        public string Erea
        {
            get
            {
                return erea;
            }
        }
        public string Floor
        {
            get
            {
                return floor;
            }
        }
        public string Stairs
        {
            get
            {
                return stairs;
            }
        }
        public string Elavator
        {
            get
            {
                return elavator;
            }
        }
        public string Balcony
        {
            get
            {
                return balcony;
            }
        }
        public string Toilets
        {
            get
            {
                return toilets;
            }
        }
        public string Bath
        {
            get
            {
                return bath;
            }
        }
        public string Storage
        {
            get
            {
                return storage;
            }
        }
        public string Park
        {
            get
            {
                return park;
            }
        }
        public string Garden
        {
            get
            {
                return garden;
            }
        }
        public string Renovation
        {
            get
            {
                return renovation;
            }
        }
        public string Bars
        {
            get
            {
                return bars;
            }
        }
        public string Boiler
        {
            get
            {
                return boiler;
            }
        }
        public string Pladelet
        {
            get
            {
                return pladelet;
            }
        }

        public Seller(string estateID, string sellerID, string estateType, string price,
            string city, string hood, string street, string number, string rooms,
            string erea, string floor, string stairs, string elavator, string balcony , string toilets,
            string bath, string storage, string park, string garden , string renovation , string boiler , string bars,
            string pladelet)
        {
            this.estateID = estateID;
            this.sellerID = sellerID;
            this.estateType = estateType;
            this.price = price;
            this.city = city;
            this.hood = hood;
            this.street = street;
            this.number = number;
            this.rooms = rooms;
            this.erea = erea;
            this.floor = floor;
            this.stairs = stairs;
            this.elavator = elavator;
            this.balcony = balcony;
            this.toilets = toilets;
            this.bath = bath;
            this.storage = storage;
            this.park = park;
            this.garden = garden;
            this.renovation = renovation;
            this.boiler = boiler;
            this.bars = bars;
            this.pladelet = pladelet;
        }
    }


}