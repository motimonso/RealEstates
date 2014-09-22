using RealEstates.ServerSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Moti
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ErrorLabel.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (userNameLogin.Text == "" || passwordLogin.Text == "")
            {
                ErrorLabel.Text = "אנא הכנס שם משתמש וססמא";
                ErrorLabel.Visible = true;
            }
            else //if ((userNameLogin.Text != "" && passwordLogin.Text != ""))
            {
                if (userNameLogin.Text.All(char.IsLetterOrDigit) && passwordLogin.Text.All(char.IsLetterOrDigit)) // Check That The String Is Letters And Digit Only
                {
                    ErrorLabel.Text = "Please Help Me!";
                    ErrorLabel.Visible = true;

                    UsersBL ub = new UsersBL();
                    string userName = ub.GetUser(userNameLogin.Text, passwordLogin.Text);

                    if (userName == null)
                    {
                        ErrorLabel.Text = "שם משתמש או ססמא לא נכונים";
                        ErrorLabel.Visible = true;
                    }
                    else // if (userName != null)
                    {
                        if (ub.isAdmin(userNameLogin.Text))
                        {
                            Session.Add("admin", "yes");
                        }
                        else
                        {
                            Session.Add("admin", "no");
                        }
                        Session.Add("userName", userName);
                        Response.Redirect("MainPage.aspx");
                    }
                }
                else
                {
                    ErrorLabel.Text = "לא חוקי - נא לא להזין אך ורק מספרים ואותיות";
                    ErrorLabel.Visible = true;
                }

            }
        }

    }



}
