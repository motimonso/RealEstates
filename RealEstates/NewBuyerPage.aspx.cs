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
            }
            RadioButton1.Checked = true;
            if (RadioButton2.Checked)
                RadioButton1.Checked = false;
        }

        protected void Button1Changed(object sender, EventArgs e)
        {
            RadioButton2.Checked = false;
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
        }
        protected void Button2Changed(object sender, EventArgs e)
        {
            RadioButton1.Checked = false;
            TextBox1.Text = "";
        }

        protected void SendNewBuyer(object sender, EventArgs e)
        {
            if (validUserField() && validEstateField())
            {
                ClientsBL cbl = new ClientsBL();
                BuyerEstateBL sbl = new BuyerEstateBL();
                string id;
                if (RadioButton1.Checked)
                    id = TextBox1.Text;
                else
                {
                    id = TextBox2.Text;
                    cbl.NewClient(TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text);
                }
                string hoodCheck = ddlHood.SelectedItem.Text;
                if(ddlHood.SelectedIndex==0)
                {
                    hoodCheck = "";
                }
                sbl.NewBuyerEstate(id,ddlEstateKind.SelectedItem.Text,ddlCities.SelectedItem.Text,hoodCheck,ddlBedroomNumFrom.SelectedItem.Text,ddlBedroomNumTo.SelectedItem.Text,TextBox13.Text,TextBox14.Text,ddlFloorFrom.SelectedItem.Text,ddlFloorTo.SelectedItem.Text,ddlGarden.SelectedItem.Text,TextBox18.Text,TextBox19.Text);
                OKmessage();
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
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox13.Text = "";
            TextBox14.Text = "";
            TextBox18.Text = "";
            TextBox19.Text = "";
            ddlCities.Items.Clear();
            BindDDLCities();
            ddlHood.Items.Clear();
            RadioButton1.Checked = true;
            RadioButton2.Checked = false;
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
            if (RadioButton1.Checked)
            {
                if (TextBox1.Text != "") // Only If The Word Isnt Empty Do The Rest
                {
                    if (GeneralMethods.IsDigitsOnly(TextBox1.Text))
                    {
                        if (!cbl.ClientExist(TextBox1.Text))
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

            else if (RadioButton2.Checked)
            {
                if (TextBox2.Text != "" && TextBox3.Text != "" && TextBox4.Text != "" && TextBox5.Text != "")
                // Check If Id ,fName ,Lname And Phone1 TextBoxes Are Filled
                {
                    if (cbl.ClientExist(TextBox2.Text))
                    {
                        NewUserErrorLabel.Text = "מספר הזהות כבר קיים במערכת";
                        NewUserErrorLabel.Visible = true;
                        return false;
                    }
                    else
                    {
                        if (!GeneralMethods.(TextBox2.Text) || !GeneralMethods.IsDigitsOnly(TextBox5.Text) || !GeneralMethods.IsDigitsOnly(TextBox6.Text) || !IsDigitsOnly(TextBox7.Text))
                        {
                            NewUserErrorLabel.Text = "תעודת זהות ומספרי טלפון חייבים להכיל ספרות בלבד";
                            NewUserErrorLabel.Visible = true;
                            return false;
                        }
                        else if (!((Regex.IsMatch(TextBox3.Text, @"^[a-zA-Z ]+$") && Regex.IsMatch(TextBox4.Text, @"^[a-zA-Z ]+$")) || (Regex.IsMatch(TextBox3.Text, @"^[א-ת ]+$") && Regex.IsMatch(TextBox4.Text, @"^[א-ת ]+$"))))// Check If Only Letters In The FirstName And LastNmae TextBoxes Hebrow And English
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
        public void OKmessage()
        {
            string message = "Hello! Mudassar.";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());

        }
    }
}