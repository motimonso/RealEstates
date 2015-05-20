using RealEstates;
using RealEstates.ServerSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Moti
{
    public partial class SearchResults : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string idFromSearch = (string)Session["IdFromSearch"]; // 
            string CityFromSearch = (string)Session["CityFromSearch"]; // 
            ClientsBL cbl = new ClientsBL();
            
            if (cbl.ClientExist(idFromSearch))
            {
                Client clientToDisplay = cbl.getClientByID(idFromSearch);
            }
           
        }
    }
}