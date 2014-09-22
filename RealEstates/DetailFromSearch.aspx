<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DetailFromSearch.aspx.cs" Inherits="Moti.DetailFromSearch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%
        string estateId = Request["estateId"];
        SellerEstateBL sbl = new SellerEstateBL();
        Seller sellerEstate = sbl.getFullSellerByEstateId(estateId);
         %>
    <h3>פרטי הנכס :</h3>
    <br />
    <a>סוג נכס :</a><%=sellerEstate.EstateType %><br />
    <a>מחיר :</a><%=sellerEstate.Price %><br />
    <a>עיר :</a><%=sellerEstate.City %><br />
    <a>שכונה :</a><%=sellerEstate.Hood %><br />
    <a>רחוב :</a><%=sellerEstate.Street %><br />
    <a>מספר :</a><%=sellerEstate.Number %><br />
    <a>חדרים :</a><%=sellerEstate.Rooms %><br />
    <a>שטח :</a><%=sellerEstate.Erea %><br />
    <a>קומה :</a><%=sellerEstate.Floor %><br />
    <a>מדרגות :</a><%=sellerEstate.Stairs %><br />
    <a>מעלית :</a><%=sellerEstate.Elavator %><br />
    <a>מרפסת :</a><%=sellerEstate.Balcony %><br />
    <a>שירותים :</a><%=sellerEstate.Toilets %><br />
    <a>מקלחת :</a><%=sellerEstate.Bath %><br />
    <a>מחסן :</a><%=sellerEstate.Storage %><br />
    <a>חניה :</a><%=sellerEstate.Park %><br />
    <a>גינה :</a><%=sellerEstate.Garden %><br />
    <a>שיפוץ :</a><%=sellerEstate.Renovation %><br />
    <a>דוד שמש :</a><%=sellerEstate.Boiler %><br />
    <a>סורגים :</a><%=sellerEstate.Bars %><br />
    <a>פלדלת :</a><%=sellerEstate.Pladelet %><br />
</asp:Content>
