<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SideBar.ascx.cs" Inherits="RealEstates.SideBar" %>

<%string h = (string)System.Web.HttpContext.Current.Session["userName"]; %>




<ul class="sidebar-nav">
    <li class="sidebar-brand">
        <a >ברוך הבא : <%=h %></a>
    </li>
    <li >
        <a href="MainPage.aspx">ראשי</a>
    </li>
    <li>
        <a href="NewSellerPage.aspx">הוסף מוכר</a>
    </li>
    <li>
        <a href="NewBuyerPage.aspx">הוסף קונה</a>
    </li>
    <li>
        <a href="MatchesPage.aspx">התאמות</a>
    </li>
    <li>
        <a href="SearchPage.aspx">חיפוש</a>
    </li>
    <li>
        <%
       
            string n = (string)System.Web.HttpContext.Current.Session["admin"];

            if (n.Equals("yes"))
            { 
        %>
        <a href="UserManagePage.aspx">ניהול עובדים</a>
        <%} %>
    </li>
    <li>
        <a href="LoginPage.aspx" onclick="ExitClick">יציאה</a>
    </li>

</ul>
