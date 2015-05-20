<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MatchesPage.aspx.cs" Inherits="Moti.MatchesPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>התאמות אוטומטיות</h1>
    <div id="NewMatches">
        <h3>התאמות חדשות</h3>
        <%
            RealEstates.MatchesBL mbl = new RealEstates.MatchesBL();
            LinkedList<RealEstates.Matches> newMatchList = mbl.getMatchesByType(0);
            RealEstates.ServerSide.ClientsBL cbl = new RealEstates.ServerSide.ClientsBL();
            RealEstates.SellerEstateBL sbl = new RealEstates.SellerEstateBL();
            foreach (RealEstates.Matches m in newMatchList)
            {
                string buyerName = cbl.getBuyerNameByEstateID(m.BuyerEstateId);
                string sellerAddress = sbl.getFullAddressByEstateID(m.SellerEstateId);
        %>
        <div class="row">
            <div class="col-lg-7 col-lg-push-5 matchDiv">
                <b class="detailB">נמצאה התאמה ל: </b>
                <b><%=buyerName %></b>
                &nbsp
        <b class="detailB">ב: </b>
                <b><%=sellerAddress %></b>
                &nbsp
        <a href="DetailedPage.aspx?buyerEstateId=<%=m.BuyerEstateId %> &sellerEstateId=<%=m.SellerEstateId %> ">הצג פרטים</a>
            </div>
        </div>
        <% } %>
    </div>

    <div id="OpenMatches">
        <h3>התאמות פתוחות</h3>
        <%
            LinkedList<RealEstates.Matches> openMatchList = mbl.getMatchesByType(1);
            foreach (RealEstates.Matches m in openMatchList)
            {
                string buyerName = cbl.getBuyerNameByEstateID(m.BuyerEstateId);
                string sellerAddress = sbl.getFullAddressByEstateID(m.SellerEstateId);   
        %>
       <div class="row">
            <div class="col-lg-7 col-lg-push-5 matchDiv">
                <b class="detailB">נמצאה התאמה ל: </b>
                <b><%=buyerName %></b>
                &nbsp
                <b class="detailB">ב: </b>
                <b><%=sellerAddress %></b>
                &nbsp
                <a href="DetailedPage.aspx?buyerEstateId=<%=m.BuyerEstateId %> &sellerEstateId=<%=m.SellerEstateId %> ">הצג פרטים</a>
            </div>
        </div>
        <% } %>
    </div>
    <div class="row fixRTL">
        <br />
        <div class="col-md-12">
            <asp:Button runat="server" OnClick="HistoryClicked" Text="התאמות סגורות" />
        </div>
    </div>
</asp:Content>
