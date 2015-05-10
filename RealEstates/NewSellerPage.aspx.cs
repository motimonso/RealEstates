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
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                BindDDLCities();
                BindEstateType();
                BindBedroomNumber();
                BindFloorNumber();
                BindFourItems();
                BindYesNo();
                RadioButtonExist.Checked = true;
                Panel1.Enabled = false;
            }
           


        }
        

        protected void radiobuttonChenched(object sender, EventArgs e)
        {
            ExistUserErrorLabel.Visible = false;
            NewUserErrorLabel.Visible = false;
            if(RadioButtonExist.Checked == false)
            {
                Panel1.Enabled = true;
            }
            else
            {
                Panel1.Enabled = false;
            }
        }
        protected void SendNewSeller(object sender, EventArgs e)
        {
           if (validUserField() && validEstateField())
           {
               ClientsBL cbl = new ClientsBL();
               SellerEstateBL sbl = new SellerEstateBL();
               if (!RadioButtonExist.Checked)
                   cbl.NewClient(TextBoxID.Text, TextBoxFName.Text, TextBoxLName.Text, TextBoxP1.Text, TextBoxP2.Text, TextBoxP3.Text);
               //Add To DB
               sbl.NewSellerEstate(TextBoxID.Text, ddlEstateKind.SelectedItem.Text, TextBox9.Text, ddlCities.SelectedItem.Text,ddlHood.SelectedItem.Text,ddlStreet.SelectedItem.Text,TextBox13.Text,ddlBedroomNum.SelectedItem.Text,TextBox15.Text,ddlFloorNumber.SelectedItem.Text,ddlStairs.SelectedItem.Text,ddlElavator.SelectedItem.Text,ddlBalcony.SelectedItem.Text,ddlToilet.SelectedItem.Text,ddlShowers.SelectedItem.Text,ddlStorge.SelectedItem.Text,ddlParking.SelectedItem.Text,TextBox24.Text,ddlRenovated.SelectedItem.Text,ddlBoyler.SelectedItem.Text,ddlBars.SelectedItem.Text,ddlPladelet.SelectedItem.Text);
               Response.Redirect("MainPage.aspx",false);
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
                ddlStreet.Items.Clear();
            }
           
        }
        protected void ddlHood_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (ddlHood.SelectedItem.Text.CompareTo("בחר שכונה") == 1)
            {
               
                ddlStreet.Items.Clear();
                ddlStreet.Items.Add("בחר רחוב");
                AddressBL abl = new AddressBL();
                LinkedList<ListItem> l = abl.getAllStreet(ddlHood.SelectedItem.Value);
                foreach (ListItem li in l)
                    ddlStreet.Items.Add(li);
            }
            else
            {
                ddlStreet.Items.Clear();
            }
        }

        protected void ClearClicked(object sender, EventArgs e)
        {
            TextBoxID.Text = "";
            TextBoxLName.Text = "";
            TextBoxFName.Text = "";
            TextBoxP1.Text = "";
            TextBoxP2.Text = "";
            TextBoxP3.Text = "";
            ddlEstateKind.SelectedIndex=0;
            TextBox9.Text = "";
            TextBox13.Text = "";
            ddlBedroomNum.SelectedIndex = 0;
            TextBox15.Text = "";
            ddlFloorNumber.SelectedIndex = 0;
            ddlBars.SelectedIndex = 0;
            ddlBoyler.SelectedIndex = 0;
            ddlParking.SelectedIndex = 0;
            ddlPladelet.SelectedIndex = 0;
            ddlRenovated.SelectedIndex = 0;
            ddlStairs.SelectedIndex = 0;
            ddlStorge.SelectedIndex = 0;
            ddlElavator.SelectedIndex = 0;
            ddlBalcony.SelectedIndex = 0;
            ddlToilet.SelectedIndex = 0;
            TextBox24.Text = "";
            ddlCities.Items.Clear();
            BindDDLCities();
            ddlHood.Items.Clear();
            ddlStreet.Items.Clear();
            RadioButtonExist.Checked = true;
            RadioButtonNew.Checked = false;
            ExistUserErrorLabel.Visible = false;
            NewUserErrorLabel.Visible = false;
            EstateErrorLabel.Visible = false;
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
            ddlBedroomNum.Items.Add("בחר ");
            for (int i = 1; i < 11; i++)
            {
                ddlBedroomNum.Items.Add(i.ToString());
            }
        }
        protected void BindFloorNumber()
        {
            ddlFloorNumber.Items.Add("בחר");
            ddlFloorNumber.Items.Add("קרקע");
            for (int i = 1; i < 20; i++)
            {
                ddlFloorNumber.Items.Add(i.ToString());
            }
            ddlFloorNumber.Items.Add("20+");
        }
        protected void BindFourItems()
        {
            ddlBalcony.Items.Add("בחר");
            ddlShowers.Items.Add("בחר");
            ddlToilet.Items.Add("בחר");
            for (int i = 0; i < 4; i++)
            {
                ddlBalcony.Items.Add(i.ToString());
                int t = i + 1;
                ddlShowers.Items.Add(t.ToString());
                ddlToilet.Items.Add(t.ToString());
            }
        }

        protected void BindYesNo()
        {
            ddlBars.Items.Add("בחר");
            ddlBoyler.Items.Add("בחר");
            ddlParking.Items.Add("בחר");
            ddlPladelet.Items.Add("בחר");
            ddlRenovated.Items.Add("בחר");
            ddlStairs.Items.Add("בחר");
            ddlStorge.Items.Add("בחר");
            ddlElavator.Items.Add("בחר");

            ddlElavator.Items.Add("כן");
            ddlBars.Items.Add("כן");
            ddlBoyler.Items.Add("כן");
            ddlParking.Items.Add("כן");
            ddlPladelet.Items.Add("כן");
            ddlRenovated.Items.Add("כן");
            ddlStairs.Items.Add("כן");
            ddlStorge.Items.Add("כן");

            ddlElavator.Items.Add("לא");
            ddlBars.Items.Add("לא");
            ddlBoyler.Items.Add("לא");
            ddlParking.Items.Add("לא");
            ddlPladelet.Items.Add("לא");
            ddlRenovated.Items.Add("לא");
            ddlStairs.Items.Add("לא");
            ddlStorge.Items.Add("לא");
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
                            return  false;
                        }
                    }
                    else
                    {
                        ExistUserErrorLabel.Text = "אנא הכנס ספרות בלבד בתעודת הזהות";
                        ExistUserErrorLabel.Visible = true;
                        return  false;
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
                        return  false;
                    }
                    else
                    {
                        if (!GeneralMethods.IsDigitsOnly(TextBoxID.Text) || !GeneralMethods.IsDigitsOnly(TextBoxP1.Text) || !GeneralMethods.IsDigitsOnly(TextBoxP2.Text) || !GeneralMethods.IsDigitsOnly(TextBoxP3.Text))
                        {
                            NewUserErrorLabel.Text = "תעודת זהות ומספרי טלפון חייבים להכיל ספרות בלבד";
                            NewUserErrorLabel.Visible = true;
                            return  false;
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
                    return  false;
                }
            }
            return true;
        }
        protected bool validEstateField()
        {
            EstateErrorLabel.Visible = false;
            
            if ( // Check If All Fields Are Full
                ddlEstateKind.SelectedIndex == 0    || ddlCities.SelectedIndex == 0
                || ddlHood.SelectedIndex == 0       || ddlStreet.SelectedIndex == 0
                || ddlBalcony.SelectedIndex == 0    || ddlBars.SelectedIndex == 0
                || ddlBedroomNum.SelectedIndex == 0 || ddlBoyler.SelectedIndex == 0
                || ddlElavator.SelectedIndex == 0   || ddlFloorNumber.SelectedIndex == 0
                || ddlParking.SelectedIndex == 0    || ddlPladelet.SelectedIndex == 0
                || ddlStairs.SelectedIndex == 0     || ddlRenovated.SelectedIndex == 0
                || ddlToilet.SelectedIndex == 0     || ddlShowers.SelectedIndex == 0
                || ddlStorge.SelectedIndex == 0     || TextBox24.Text == ""
                || TextBox9.Text == ""              || TextBox13.Text == ""
                || TextBox15.Text == ""
               )
            {
                EstateErrorLabel.Text = ("חובה להזין את כל הפרטים");
                EstateErrorLabel.Visible = true;
                return false;
            }

            //Check If All Fields That Required Digits Are Correct
            if (!(GeneralMethods.IsDigitsOnly(TextBox9.Text) && GeneralMethods.IsDigitsOnly(TextBox24.Text)
                && GeneralMethods.IsDigitsOnlyAddress(TextBox13.Text) && GeneralMethods.IsDigitsOnly(TextBox15.Text)))
            {
                EstateErrorLabel.Text=("בשדות : מחיר , מספר , שטח וגינה חובה להכניס רק ספרות");
                EstateErrorLabel.Visible = true;
                return false;
            }
            else return true;
        }
    }
}