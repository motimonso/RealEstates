<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DetailFromSearch.aspx.cs" Inherits="Moti.DetailFromSearch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%
        string estateId = Request["estateId"];
        SellerEstateBL sbl = new SellerEstateBL();
        Seller sellerEstate = sbl.getFullSellerByEstateId(estateId);
         %>
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
