<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MatchesPage.aspx.cs" Inherits="Moti.MatchesPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>התאמות אוטומטיות</h1>
    <div id="NewMatches">
        <h3>התאמות חדשות</h3>
        <%
            
            MatchesBL mbl = new MatchesBL();
            LinkedList<Matches> newMatchList = mbl.getMatchesByType(0);
            ClientsBL cbl=new ClientsBL();
            SellerEstateBL sbl = new SellerEstateBL();
            foreach (Matches m in newMatchList)
            {
                string buyerName = cbl.getBuyerNameByEstateID(m.BuyerEstateId);
                string sellerAddress = sbl.getFullAddressByEstateID(m.SellerEstateId);
               
        %>
       
        <div>
        <a>נמצאה התאמה ל: </a>
        <a class="datailA"><%=buyerName %></a>
        <a>ב: </a>
        <a class="datailA"><%=sellerAddress %></a>
        <a href="DetailedPage.aspx?buyerEstateId=<%=m.BuyerEstateId %> &sellerEstateId=<%=m.SellerEstateId %> ">הצג פרטים</a>
        
        <br />
            </div>
        


        <% } %>
    </div>
    <div id="OpenMatches">
    </div>

</asp:Content>
