using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealEstates.ServerSide
{
    public class SellerEstateBL
    {
        private SellerEstateDAL sd ;
        public SellerEstateBL()
        {
            sd = new SellerEstateDAL();
        }
        public void NewSellerEstate(string sellerID, string estateType, string price, string city, string hood, string street,
             string number, string numOfBedroom, string area, string floor, string stairs, string elavator,
             string numOfBalcony, string toilet, string shower, string storge, string parking, string garden,
             string renovate, string boyler, string bars, string pladelet)
        {
            sd.NewSellerEstate( sellerID,  estateType, price,  city,  hood,  street,
              number,  numOfBedroom,  area,  floor,  stairs,  elavator,
              numOfBalcony, toilet,  shower, storge,  parking,  garden,
             renovate,  boyler, bars,  pladelet);
        }
        public LinkedList<Seller> getAllSellers()
        {
            return sd.getAllSellers();
        }
        public string getFullAddressByEstateID(string id)
        {
            return sd.getFullAddressByEstateID(id);
        }
        public Seller getFullSellerByEstateId(string estateId)
        {
            return sd.getFullSellerByEstateId(estateId);
        }
        public LinkedList<Seller> SearchSellers(string city, string hood, string kind)
        {
            return sd.SearchSellers(city, hood, kind);
        }
    }
}