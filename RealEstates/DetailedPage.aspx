<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DetailedPage.aspx.cs" Inherits="Moti.DetailedPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>פרטי התאמה</h1>
    <%
        ClientsBL cbl=new ClientsBL();
        SellerEstateBL sbl = new SellerEstateBL();
        string buyerEstateId = Request["BuyerEstateId"];
        string sellerEstateId = Request["SellerEstateId"];
        Client buyer = cbl.getFullBuyerByEstateId(buyerEstateId);
        Client seller = cbl.getFullSellerByEstateId(sellerEstateId);
        Seller sellerEstate = sbl.getFullSellerByEstateId(sellerEstateId);
        %>
   <h3>פרטי הקונה :</h3>
    <br />
    <a>שם :</a><%=buyer.FName %>
    <a>משפחה :</a><%=buyer.LName %>
    <a>טלפון 1 :</a><%=buyer.P1 %>
     <%if(!buyer.P2.Equals("")){ %>
    <a>טלפון 2 :</a> <%=buyer.P2 %>
     <%}if(!buyer.P3.Equals("")){ %>
    <a>טלפון 3 :</a> <%=buyer.P3 %>
    <%} %>
    <br />
    <h3>פרטי המוכר :</h3>
    <br />
    <a>שם :</a><%=seller.FName %>
    <a>משפחה :</a><%=seller.LName %>
    <a>טלפון 1 :</a><%=seller.P1 %>
     <%if(!buyer.P2.Equals("")){ %>
    <a>טלפון 2 :</a> <%=seller.P2 %>
     <%}if(!buyer.P3.Equals("")){ %>
    <a>טלפון 3 :</a> <%=seller.P3 %>
    <%} %>
    <br />
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
