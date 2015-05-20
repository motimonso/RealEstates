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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                BindDDLCities();
                BindEstateType();
                ErrorIdLabel.Visible = false;
                ErrorCityLabel.Visible = false;
            }
        }
  
        protected void BindDDLCities()
        {
            ddlCities.Items.Add("בחר עיר");
            AddressBL abl = new AddressBL();
            LinkedList<ListItem> l = abl.getAllCities();
            foreach (ListItem li in l)
                ddlCities.Items.Add(li);
        }
        protected void ddlCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCities.SelectedItem.Text.CompareTo("בחר עיר") == 1)
            {
                ddlHood.Items.Clear();
                ddlHood.Items.Add("בחר שכונה");
                AddressBL abl = new AddressBL();
                LinkedList<ListItem> l = abl.getAllHood(ddlCities.SelectedItem.Value);
                foreach (ListItem li in l)
                    ddlHood.Items.Add(li);
            }
            else
            {
                ddlHood.Items.Clear();
            }
        }

        protected void BindEstateType()
        {
            ddlEstateKind.Items.Add("בחר סוג נכס");
            ddlEstateKind.Items.Add("דירה");
            ddlEstateKind.Items.Add("דירת גן");
            ddlEstateKind.Items.Add("פנטהאוז");
            ddlEstateKind.Items.Add("דופלקס");
            ddlEstateKind.Items.Add("פרטי/קוטג'");
        }

        protected void SendSearch(object sender, EventArgs e)
        {
            string city, hood, estateKind;
            if (ddlCities.SelectedIndex != 0 || ddlEstateKind.SelectedIndex!=0)
            {
                if (ddlCities.SelectedIndex != 0)
                    city = ddlCities.SelectedItem.Text;
                else
                    city = "0";

                if (ddlHood.SelectedIndex > 0 )
                    hood = ddlHood.SelectedItem.Text;
                else
                    hood = "0";

                if (ddlEstateKind.SelectedIndex != 0)
                    estateKind = ddlEstateKind.SelectedItem.Text;
                else
                    estateKind = "0";

                Session["CityFromSearch"] = ddlCities.SelectedItem.Text;
                Response.Redirect("SearchResults.aspx?city=" + city+"&hood="+hood+"&estateKind="+estateKind, false);
            }
            else
                ErrorCityLabel.Visible = true;
        }
    }
}