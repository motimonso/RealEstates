<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Moti.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <h1>חיפוש</h1>
    </div>
    <div class="row">
        <h3>פרטי החיפוש :</h3>
    </div>
    <div class="row">
        <div class="col-lg-12">
            <asp:Label CssClass="DetailsToFill" ID="ErrorIdLabel" Visible="false" runat="server" Text="אנא הכנס רק ספרות" ForeColor="Red"></asp:Label>
            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="LabelCity" runat="server" Text="עיר :"></asp:Label>
                <asp:DropDownList CssClass="DetailsToFill" ID="ddlCities" OnSelectedIndexChanged="ddlCities_SelectedIndexChanged" runat="server" AutoPostBack="True"></asp:DropDownList>
            </div>

            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label1" runat="server" Text="שכונה :"></asp:Label>
                <asp:DropDownList CssClass="DetailsToFill" ID="ddlHood" runat="server" AutoPostBack="True"></asp:DropDownList>
            </div>

            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label2" runat="server" Text="סוג נכס :"></asp:Label>
                <asp:DropDownList CssClass="DetailsToFill" ID="ddlEstateKind" runat="server"></asp:DropDownList>
                <asp:Button runat="server" ID="Button1" Text="שלח" OnClick="SendSearch" />
            </div>

            <asp:Label CssClass="DetailsToFill" ID="ErrorCityLabel" Visible="false" runat="server" Text="אנא בחר לפחות שדה אחד" ForeColor="Red"></asp:Label>
        </div>
    </div>


</asp:Content>

