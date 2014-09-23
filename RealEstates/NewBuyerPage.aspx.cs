using RealEstates.ServerSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Moti
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDDLCities();
                BindEstateType();
                BindBedroomNumber();
                BindFloorNumber();
                BindYesNo();
                RadioButtonExist.Checked = true;
                Panel1.Enabled = false;
            }
           
        }

        protected void radiobuttonChenched(object sender, EventArgs e)
        {
            ExistUserErrorLabel.Visible = false;
            NewUserErrorLabel.Visible = false;
            if (RadioButtonExist.Checked == false)
            {
                Panel1.Enabled = true;
            }
            else
            {
                Panel1.Enabled = false;
            }
        }
        protected void SendNewBuyer(object sender, EventArgs e)
        {
            if (validUserField() && validEstateField())
            {
                ClientsBL cbl = new ClientsBL();
                BuyerEstateBL sbl = new BuyerEstateBL();
                string id;
                if (!RadioButtonExist.Checked)
                    cbl.NewClient(TextBoxID.Text, TextBoxFName.Text, TextBoxLName.Text, TextBoxP1.Text, TextBoxP2.Text, TextBoxP3.Text);
                
                string hoodCheck = ddlHood.SelectedItem.Text;
                if(ddlHood.SelectedIndex==0)
                {
                    hoodCheck = "";
                }
                //Add To DB
                sbl.NewBuyerEstate(TextBoxID.Text,ddlEstateKind.SelectedItem.Text,ddlCities.SelectedItem.Text,hoodCheck,ddlBedroomNumFrom.SelectedItem.Text,ddlBedroomNumTo.SelectedItem.Text,TextBox13.Text,TextBox14.Text,ddlFloorFrom.SelectedItem.Text,ddlFloorTo.SelectedItem.Text,ddlGarden.SelectedItem.Text,TextBox18.Text,TextBox19.Text);
                Response.Redirect("MainPage.aspx", false);
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
        protected void ClearClicked(object sender, EventArgs e)
        {
            
            TextBoxID.Text = "";
            TextBoxFName.Text = "";
            TextBoxLName.Text = "";
            TextBoxP1.Text = "";
            TextBoxP2.Text = "";
            TextBoxP3.Text = "";
            TextBox13.Text = "";
            TextBox14.Text = "";
            TextBox18.Text = "";
            TextBox19.Text = "";
            ddlCities.Items.Clear();
            BindDDLCities();
            ddlHood.Items.Clear();
            RadioButtonExist.Checked = true;
            RadioButtonNew.Checked = false;
            ExistUserErrorLabel.Visible = false;
            NewUserErrorLabel.Visible = false;
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
        protected void BindBedroomNumber()
        {
            ddlBedroomNumFrom.Items.Add("בחר ");
            ddlBedroomNumTo.Items.Add("בחר ");
            for (int i = 1; i < 11; i++)
            {
                ddlBedroomNumFrom.Items.Add(i.ToString());
                ddlBedroomNumTo.Items.Add(i.ToString());
            }

        }
        protected void BindFloorNumber()
        {
            ddlFloorFrom.Items.Add("בחר");
            ddlFloorFrom.Items.Add("קרקע");
            ddlFloorTo.Items.Add("בחר");
            ddlFloorTo.Items.Add("קרקע");
            for (int i = 1; i < 20; i++)
            {
                ddlFloorFrom.Items.Add(i.ToString());
                ddlFloorTo.Items.Add(i.ToString());
            }
            ddlFloorFrom.Items.Add("20+");
            ddlFloorTo.Items.Add("20+");
        }
        protected void BindYesNo()
        {
            ddlGarden.Items.Add("בחר");
            ddlGarden.Items.Add("כן");
            ddlGarden.Items.Add("לא");
        }
        protected bool validUserField()
        {
            ExistUserErrorLabel.Visible = false;
            NewUserErrorLabel.Visible = false;
            ClientsBL cbl = new ClientsBL();
            if (RadioButtonExist.Checked)
            {
                if (TextBoxID.Text != "") // Only If The Word Isnt Empty Do The Rest
                {
                    if (GeneralMethods.IsDigitsOnly(TextBoxID.Text))
                    {
                        if (!cbl.ClientExist(TextBoxID.Text))
                        {
                            ExistUserErrorLabel.Text = "מספר הזהות שגוי או שאינו קיים במערכת";
                            ExistUserErrorLabel.Visible = true;
                            return false;
                        }
                    }
                    else
                    {
                        ExistUserErrorLabel.Text = "אנא הכנס ספרות בלבד בתעודת הזהות";
                        ExistUserErrorLabel.Visible = true;
                        return false;
                    }
                }
                else
                {
                    ExistUserErrorLabel.Text = "חובה להכניס תעודת זהות";
                    ExistUserErrorLabel.Visible = true;
                    return false;
                }
            } // End Of Existing User

            else if (RadioButtonNew.Checked)
            {
                if (TextBoxID.Text != "" && TextBoxFName.Text != "" && TextBoxLName.Text != "" && TextBoxP1.Text != "")
                // Check If Id ,fName ,Lname And Phone1 TextBoxes Are Filled
                {
                    if (cbl.ClientExist(TextBoxID.Text))
                    {
                        NewUserErrorLabel.Text = "מספר הזהות כבר קיים במערכת";
                        NewUserErrorLabel.Visible = true;
                        return false;
                    }
                    else
                    {
                        if (!GeneralMethods.IsDigitsOnly(TextBoxID.Text) || !GeneralMethods.IsDigitsOnly(TextBoxP1.Text) || !GeneralMethods.IsDigitsOnly(TextBoxP2.Text) || !GeneralMethods.IsDigitsOnly(TextBoxP3.Text))
                        {
                            NewUserErrorLabel.Text = "תעודת זהות ומספרי טלפון חייבים להכיל ספרות בלבד";
                            NewUserErrorLabel.Visible = true;
                            return false;
                        }
                        else if (!((Regex.IsMatch(TextBoxFName.Text, @"^[a-zA-Z ]+$") && Regex.IsMatch(TextBoxLName.Text, @"^[a-zA-Z ]+$")) || (Regex.IsMatch(TextBoxFName.Text, @"^[א-ת ]+$") && Regex.IsMatch(TextBoxLName.Text, @"^[א-ת ]+$"))))// Check If Only Letters In The FirstName And LastNmae TextBoxes Hebrow And English
                        {
                            NewUserErrorLabel.Text = "שם פרטי ומשפחה חייבים להכיל אותיות בלבד";
                            NewUserErrorLabel.Visible = true;
                            return false;
                        }
                    }
                }
                else
                {
                    NewUserErrorLabel.Text = "חובה למלא את השדות הבאים : תעודת זהות , שם פרטי , שם משפחה ושדה טלפון1 לפחות";
                    NewUserErrorLabel.Visible = true;
                    return false;
                }
            }
            return true;

        }

         
        protected bool validEstateField()
        {
            EstateErrorLabel.Visible = false;

            if ( // Check If All Fields Are Full
                ddlEstateKind.SelectedIndex == 0 || ddlCities.SelectedIndex == 0
                || ddlBedroomNumFrom.SelectedIndex == 0 
                || ddlBedroomNumTo.SelectedIndex == 0 || ddlFloorFrom.SelectedIndex == 0 
                || ddlFloorTo.SelectedIndex == 0 || ddlGarden.SelectedIndex == 0
                || TextBox13.Text == "" || TextBox14.Text == "" || TextBox13.Text == ""
                || TextBox18.Text == "" || TextBox19.Text == ""
                
               )
            {
                EstateErrorLabel.Text = ("חובה להזין את כל הפרטים");
                EstateErrorLabel.Visible = true;
                return false;
            }


            //Check If All Fields That Required Digits Are Correct
            if (!(GeneralMethods.IsDigitsOnly(TextBox13.Text) && GeneralMethods.IsDigitsOnly(TextBox14.Text)
                && GeneralMethods.IsDigitsOnly(TextBox18.Text) && GeneralMethods.IsDigitsOnly(TextBox19.Text)))
            {
                EstateErrorLabel.Text = ("בשדות : מחיר , מספר ושטח  חובה להכניס רק ספרות");
                EstateErrorLabel.Visible = true;
                return false;
            }
            int priceFrom , priceTo , areaFrom , areaTo;
            areaFrom = Convert.ToInt32(TextBox13.Text);
            areaTo = Convert.ToInt32(TextBox14.Text);
            priceFrom = Convert.ToInt32(TextBox18.Text);
            priceTo = Convert.ToInt32(TextBox19.Text);
            if (ddlFloorFrom.SelectedIndex > ddlFloorTo.SelectedIndex || ddlBedroomNumFrom.SelectedIndex > ddlBedroomNumTo.SelectedIndex
                || priceFrom > priceTo || areaFrom > areaTo)
            {
                EstateErrorLabel.Text = ("בבחירת חדרים , שטח , קומה ומחיר , הערכים צריכים להיות הגיוניים");
                EstateErrorLabel.Visible = true;
                return false;
            }
            else return true;

        }
    }
}