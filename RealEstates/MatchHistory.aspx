<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MatchHistory.aspx.cs" Inherits="RealEstates.MatchHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="CloseMatches">
        <h3>התאמות סגורות</h3>
        <%
            RealEstates.MatchesBL mbl = new RealEstates.MatchesBL();
            RealEstates.ServerSide.ClientsBL cbl = new RealEstates.ServerSide.ClientsBL();
            RealEstates.SellerEstateBL sbl = new RealEstates.SellerEstateBL();
            LinkedList<RealEstates.Matches> closeMatchList = mbl.getMatchesByType(2);
            foreach (RealEstates.Matches m in closeMatchList)
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
                <b ><%=sellerAddress %></b>
                &nbsp
                <a href="DetailedPage.aspx?buyerEstateId=<%=m.BuyerEstateId %> &sellerEstateId=<%=m.SellerEstateId %> ">הצג פרטים</a>
            </div>
        </div>
        <% } %>
    </div>
</asp:Content>
