<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="NewBuyerPage.aspx.cs" Inherits="Moti.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="row fixCenter">

        <h1>הוספת קונה למאגר</h1>
    </div>
    <div class="row fixRTL">
        <a class="mediumHeader">פרטי הלקוח : </a>
    </div>
    <div class="row fixRTL ">
        <div class="row">
            <div class="col-md-12">
                <asp:RadioButton CssClass="fixPaddRight6PX" GroupName="ClientRadio" AutoPostBack="true" OnCheckedChanged="radiobuttonChenched" ID="RadioButtonExist" runat="server" Text="לקוח קיים" />
                <asp:Label runat="server" Visible="false" ID="ExistUserErrorLabel" Text="מספר הזהות שגוי או שאינו קיים במערכת" ForeColor="Red"></asp:Label>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:RadioButton CssClass="fixPaddRight6PX" GroupName="ClientRadio" AutoPostBack="true" OnCheckedChanged="radiobuttonChenched" ID="RadioButtonNew" runat="server" Text="לקוח חדש" />
                <asp:Label runat="server" Visible="false" ID="NewUserErrorLabel" Text="מספר הזהות קיים במערכת" ForeColor="Red"></asp:Label>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label30" runat="server" Text="תעודת זהות :"></asp:Label>
                <asp:TextBox CssClass="largeDDL" ID="TextBoxID" runat="server"></asp:TextBox>
            </div>
            <asp:Panel ID="Panel1" runat="server">
                <div class="DetailDiv">
                    <asp:Label CssClass="DetailsToFill" ID="Label31" runat="server" Text="שם פרטי :"></asp:Label>
                    <asp:TextBox CssClass="largeDDL" ID="TextBoxFName" runat="server"></asp:TextBox>
                </div>
                <div class="DetailDiv">
                    <asp:Label CssClass="DetailsToFill" ID="Label32" runat="server" Text="שם משפחה :"></asp:Label>
                    <asp:TextBox CssClass="largeDDL" ID="TextBoxLName" runat="server"></asp:TextBox>
                </div>
                <div class="DetailDiv">
                    <asp:Label CssClass="DetailsToFill" ID="Label33" runat="server" Text="טלפון 1 :"></asp:Label>
                    <asp:TextBox CssClass="largeDDL" ID="TextBoxP1" runat="server"></asp:TextBox>
                </div>
                <div class="DetailDiv">
                    <asp:Label CssClass="DetailsToFill" ID="Label34" runat="server" Text="טלפון 2 :"></asp:Label>
                    <asp:TextBox CssClass="largeDDL" ID="TextBoxP2" runat="server"></asp:TextBox>
                </div>
                <div class="DetailDiv">
                    <asp:Label CssClass="DetailsToFill" ID="Label35" runat="server" Text="טלפון 3 :"></asp:Label>
                    <asp:TextBox CssClass="largeDDL" ID="TextBoxP3" runat="server"></asp:TextBox>
                </div>
            </asp:Panel>
        </div>
    </div>
    <div class="row fixRTL">
        <div class="col-md-12">
            <a class="mediumHeader">פרטי הנכס : </a>
            <asp:Label ID="EstateErrorLabel" runat="server" ForeColor="Red" Text="חובה להזין את כל הפרטים" Visible="False"></asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-12">
            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label8" runat="server" Text="סוג הנכס :"></asp:Label>
                <asp:DropDownList CssClass="DetailsToFill" ID="ddlEstateKind" runat="server"></asp:DropDownList>
            </div>

            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label9" runat="server" Text="עיר :"></asp:Label>
                <asp:DropDownList CssClass="AddressDDL" ID="ddlCities" runat="server" OnSelectedIndexChanged="ddlCities_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
            </div>

            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label10" runat="server" Text="שכונה :"></asp:Label>
                <asp:DropDownList CssClass="AddressDDL" ID="ddlHood" runat="server" AutoPostBack="True"></asp:DropDownList>
            </div>

            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label11" runat="server" Text="חדרים מ :"></asp:Label>
                <asp:DropDownList CssClass="smallDDL" ID="ddlBedroomNumFrom" runat="server"></asp:DropDownList>
            </div>

            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label12" runat="server" Text="חדרים עד :"></asp:Label>
                <asp:DropDownList CssClass="SmallDDL" ID="ddlBedroomNumTo" runat="server"></asp:DropDownList>
            </div>

            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label13" runat="server" Text="שטח מ :"></asp:Label>
                <asp:TextBox CssClass="SmallDDL" ID="TextBox13" runat="server"></asp:TextBox>
            </div>

            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label14" runat="server" Text="שטח עד :"></asp:Label>
                <asp:TextBox CssClass="SmallDDL" ID="TextBox14" runat="server"></asp:TextBox>
            </div>

            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label15" runat="server" Text="קומה מ :"></asp:Label>
                <asp:DropDownList CssClass="SmallDDL" ID="ddlFloorFrom" runat="server"></asp:DropDownList>
            </div>

            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label16" runat="server" Text="קומה עד :"></asp:Label>
                <asp:DropDownList CssClass="SmallDDL" ID="ddlFloorTo" runat="server"></asp:DropDownList>
            </div>

            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label17" runat="server" Text="גינה :"></asp:Label>
                <asp:DropDownList CssClass="SmallDDL" ID="ddlGarden" runat="server"></asp:DropDownList>
            </div>

            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label18" runat="server" Text="מחיר מ :"></asp:Label>
                <asp:TextBox CssClass="SmallDDL" ID="TextBox18" runat="server"></asp:TextBox>
            </div>

            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label19" runat="server" Text="מחיר עד :"></asp:Label>
                <asp:TextBox CssClass="SmallDDL" ID="TextBox19" runat="server"></asp:TextBox>
            </div>
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-md-12 fixCenter fixRTL">
            <asp:Button runat="server" ID="SendButton" Text="שלח" OnClick="SendNewBuyer" />
            <asp:Button runat="server" ID="ClearButton" Text="נקה" OnClick="ClearClicked" />
        </div>
    </div>
</asp:Content>
