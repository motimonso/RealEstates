<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DetailedPage.aspx.cs" Inherits="Moti.DetailedPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>פרטי התאמה</h1>
    <%
        ClientsBL cbl = new ClientsBL();
        SellerEstateBL sbl = new SellerEstateBL();
        string buyerEstateId = Request["BuyerEstateId"];
        string sellerEstateId = Request["SellerEstateId"];
        Client buyer = cbl.getFullBuyerByEstateId(buyerEstateId);
        Client seller = cbl.getFullSellerByEstateId(sellerEstateId);
        Seller sellerEstate = sbl.getFullSellerByEstateId(sellerEstateId);
    %>
    <div class="row">
        <h3>פרטי הקונה :</h3>
    </div>
    <div class="row">
        <div class="col-lg-12 matchDiv">
            <b class="detailB">שם :</b><b><%=buyer.FName %></b>
            <b class="detailB">משפחה :</b><b><%=buyer.LName %></b>
            <b class="detailB">טלפון 1 :</b><b><%=buyer.P1 %></b>
            <%if (!buyer.P2.Equals(""))
              { %>
            <b class="detailB">2 :</b> <b><%=buyer.P2 %></b>
            <%} if (!buyer.P3.Equals(""))
              { %>
            <b class="detailB">טלפון 3 :</b> <b><%=buyer.P3 %></b>
            <%} %>
        </div>
    </div>
    <div class="row">
        <h3>פרטי המוכר :</h3>
    </div>
    <div class="row">
        <div class="col-lg-12 matchDiv">
            <b class="detailB">שם :</b><b><%=seller.FName %></b>
            <b class="detailB">משפחה :</b><b><%=seller.LName %></b>
            <b class="detailB">טלפון 1 :</b><b><%=seller.P1 %></b>
            <%if (!buyer.P2.Equals(""))
              { %>
            <b class="detailB">טלפון 2 :</b> <b><%=seller.P2 %></b>
            <%} if (!buyer.P3.Equals(""))
              { %>
            <b class="detailB">טלפון 3 :</b><b> <%=seller.P3 %></b>
            <%} %>
        </div>
    </div>
    <div class="row">
        <h3>פרטי הנכס :</h3>
    </div>
    <div class="row">
        <div class="col-lg-12 matchDiv">

            <b class="detailB">סוג נכס :</b><b><%=sellerEstate.EstateType %></b><br />
            <b class="detailB">מחיר :</b><b><%=sellerEstate.Price %></b><br />
            <b class="detailB">עיר :</b><b><%=sellerEstate.City %></b><br />
            <b class="detailB">שכונה :</b><b><%=sellerEstate.Hood %></b><br />
            <b class="detailB">רחוב :</b><b><%=sellerEstate.Street %></b><br />
            <b class="detailB">מספר :</b><b><%=sellerEstate.Number %></b><br />
            <b class="detailB">חדרים :</b><b><%=sellerEstate.Rooms %></b><br />
            <b class="detailB">שטח :</b><b><%=sellerEstate.Erea %></b><br />
            <b class="detailB">קומה :</b><b><%=sellerEstate.Floor %></b><br />
            <b class="detailB">מדרגות :</b><b><%=sellerEstate.Stairs %></b><br />
            <b class="detailB">מעלית :</b><b><%=sellerEstate.Elavator %></b><br />
            <b class="detailB">מרפסת :</b><b><%=sellerEstate.Balcony %></b><br />
            <b class="detailB">שירותים :</b><b><%=sellerEstate.Toilets %></b><br />
            <b class="detailB">מקלחת :</b><b><%=sellerEstate.Bath %></b><br />
            <b class="detailB">מחסן :</b><b><%=sellerEstate.Storage %></b><br />
            <b class="detailB">חניה :</b><b><%=sellerEstate.Park %></b><br />
            <b class="detailB">גינה :</b><b><%=sellerEstate.Garden %></b><br />
            <b class="detailB">שיפוץ :</b><b><%=sellerEstate.Renovation %></b><br />
            <b class="detailB">דוד שמש :</b><b><%=sellerEstate.Boiler %></b><br />
            <b class="detailB">סורגים :</b><b><%=sellerEstate.Bars %></b><br />
            <b class="detailB">פלדלת :</b><b><%=sellerEstate.Pladelet %></b><br />
        </div>
    </div>


</asp:Content>
