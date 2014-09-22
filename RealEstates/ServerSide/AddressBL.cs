using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace RealEstates.ServerSide
{
    public class AddressBL
    {
        AddressDAL ad = new AddressDAL();

        public LinkedList<ListItem> getAllCities()
        {
            return ad.getAllCities();
        }
        public LinkedList<ListItem> getAllHood(string city)
        {
            return ad.getAllHood(city);
        }
        public LinkedList<ListItem> getAllStreet(string hood)
        {
            return ad.getAllStreet(hood);
        }
    }
}