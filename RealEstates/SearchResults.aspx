<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SearchResults.aspx.cs" Inherits="Moti.SearchResults" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <h1>תוצאות חיפוש</h1>
    </div>

    <%
        string CityFromSearch = Request["city"];
        string hoodFromSearch = Request["hood"];
        string estateFromSearch = Request["estateKind"];
        SellerEstateBL sbl = new SellerEstateBL();
        LinkedList<Seller> sellerList = sbl.SearchSellers(CityFromSearch, hoodFromSearch, estateFromSearch);
        foreach (Seller s in sellerList)
        {
        
        
    %>
    <div class="row matchDiv">
        <div class="col-lg-12">
            <a class="detailB" href="DetailFromSearch.aspx?estateId=<%=s.EstateID %>">סוג הנכס : <%=s.EstateType%><br />
                כתובת : <%=s.City %> <%=s.Hood %> <%=s.Street %> <%=s.Number %>
            </a>
        </div>
        
    </div>
    <br />
    <%} %>
</asp:Content>
