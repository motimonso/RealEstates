﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Moti
{
    public partial class MatchesPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void HistoryClicked(object sender, EventArgs e)
        {
            Response.Redirect("MatchHistory.aspx");
        }
       
    }
}