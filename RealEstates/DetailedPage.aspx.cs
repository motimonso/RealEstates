using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RealEstates.ServerSide;
using RealEstates;

namespace Moti
{
    public partial class DetailedPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MatchesBL mbl = new MatchesBL();
            string buyerEstateId = Request["BuyerEstateId"];
            string sellerEstateId = Request["SellerEstateId"];
            
            if (mbl.isClosed(buyerEstateId, sellerEstateId))
            { 
                closeButton.Visible = false;
            }
            else
            {
                mbl.changeMatchStatus(0, buyerEstateId, sellerEstateId);
            }
        }
        protected void closePressed(object sender, EventArgs e)
        {
            string buyer = Request["BuyerEstateId"];
            string seller = Request["SellerEstateId"];
            MatchesBL mbl = new MatchesBL();
            mbl.changeMatchStatus(1, buyer, seller);
            Response.Redirect("MatchesPage.aspx");
        }
    }
}