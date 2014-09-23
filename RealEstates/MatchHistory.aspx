<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MatchHistory.aspx.cs" Inherits="RealEstates.MatchHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="CloseMatches">
        <h3>התאמות סגורות</h3>
        <%
            MatchesBL mbl = new MatchesBL();
            ClientsBL cbl = new ClientsBL();
            SellerEstateBL sbl = new SellerEstateBL();
            LinkedList<Matches> closeMatchList = mbl.getMatchesByType(2);
            foreach (Matches m in closeMatchList)
            {
                string buyerName = cbl.getBuyerNameByEstateID(m.BuyerEstateId);
                string sellerAddress = sbl.getFullAddressByEstateID(m.SellerEstateId);   
        %>
        <div class="row">
            <div class="col-lg-6 col-lg-push-6 matchDiv">
                <b class="detailB">נמצאה התאמה ל: </b>
                <b><%=buyerName %></b>
                &nbsp
                <b>ב: </b>
                <b class="detailB"><%=sellerAddress %></b>
                &nbsp
                <a href="DetailedPage.aspx?buyerEstateId=<%=m.BuyerEstateId %> &sellerEstateId=<%=m.SellerEstateId %> ">הצג פרטים</a>
            </div>
        </div>
        <% } %>
    </div>
</asp:Content>
