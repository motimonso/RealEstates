<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="NewBuyerPage.aspx.cs" Inherits="Moti.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
     <h1>הוספת קונה למאגר</h1>
    <br />
    <h3>פרטי הלקוח :</h3>
    <div class="DetailDiv">
        <asp:RadioButton GroupName="RadioButton" OnCheckedChanged="Button1Changed" CssClass="DetailsToFill" ID="RadioButton1" runat="server" Text="לקוח קיים" TextAlign="Left" />
        <asp:Label CssClass="DetailsToFill" runat="server" Visible="false" ID="ExistUserErrorLabel" Text="מספר הזהות שגוי או שאינו קיים במערכת" ForeColor="Red"></asp:Label>
        <br />
    </div>
    <br />
    <br />
    <asp:Label CssClass="DetailsToFill" ID="Lable1" runat="server" Text="תעודת זהות :"></asp:Label>
    <asp:TextBox CssClass="largeDDL" ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Label CssClass="DetailsToFill" ID="ErrorLabelM" runat="server" Text="User DoesNot Exist" Visible="False"></asp:Label>
    <br />
    <br />
    <div class="DetailDiv">
        <asp:RadioButton GroupName="RadioButton" OnCheckedChanged="Button2Changed" CssClass="DetailsToFill" ID="RadioButton2" runat="server" Text="לקוח חדש" TextAlign="Left" />
        <asp:Label runat="server" Visible="false" Text="מספר הזהות קיים במערכת" ID="NewUserErrorLabel" ForeColor="Red"></asp:Label>
    </div>
    <br />
    <br />

    <div class="DetailDiv">
        <asp:Label CssClass="DetailsToFill" ID="LabelNewID" runat="server" Text="תעודת זהות :"></asp:Label>
        <asp:TextBox CssClass="largeDDL" ID="TextBox2" runat="server"></asp:TextBox>
    </div>

    <div class="DetailDiv">
        <asp:Label CssClass="DetailsToFill" ID="LabelFName" runat="server" Text="שם פרטי :"></asp:Label>
        <asp:TextBox CssClass="largeDDL" ID="TextBox3" runat="server"></asp:TextBox>
    </div>

    <div class="DetailDiv">
        <asp:Label CssClass="DetailsToFill" ID="LabelLName" runat="server" Text="שם משפחה :"></asp:Label>
        <asp:TextBox CssClass="largeDDL" ID="TextBox4" runat="server"></asp:TextBox>
    </div>

    <div class="DetailDiv">
        <asp:Label CssClass="DetailsToFill" ID="LabelP1" runat="server" Text="טלפון 1 :"></asp:Label>
        <asp:TextBox CssClass="largeDDL" ID="TextBox5" runat="server"></asp:TextBox>
    </div>

    <div class="DetailDiv">
        <asp:Label CssClass="DetailsToFill" ID="LabelP2" runat="server" Text="טלפון 2 :"></asp:Label>
        <asp:TextBox CssClass="largeDDL" ID="TextBox6" runat="server"></asp:TextBox>
    </div>

    <div class="DetailDiv">
        <asp:Label CssClass="DetailsToFill" ID="LabelP3" runat="server" Text="טלפון 3 :"></asp:Label>
        <asp:TextBox CssClass="largeDDL" ID="TextBox7" runat="server"></asp:TextBox>
    </div>

    <br /><br /><br /><br />
    <div class="DetailDiv">
    <h3 class="DetailsHeader">פרטי הנכס :</h3>
    <asp:Label class="DetailsHeader" ID="EstateErrorLabel" runat="server" ForeColor="Red" Text="חובה להזין את כל הפרטים" Visible="False"></asp:Label>
        </div>
    <br /><br />
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
        <asp:TextBox CssClass="SmallDDL" ID="TextBox13" runat="server" ></asp:TextBox>
    </div>

    <div class="DetailDiv">
        <asp:Label CssClass="DetailsToFill" ID="Label14" runat="server" Text="שטח עד :"></asp:Label>
        <asp:TextBox CssClass="SmallDDL" ID="TextBox14" runat="server" ></asp:TextBox>
    </div>

    <div class="DetailDiv">
        <asp:Label CssClass="DetailsToFill" ID="Label15" runat="server" Text="קומה מ :"></asp:Label>
        <asp:DropDownList CssClass="SmallDDL" ID="ddlFloorFrom" runat="server" ></asp:DropDownList>
    </div>

    <div class="DetailDiv">
        <asp:Label CssClass="DetailsToFill" ID="Label16" runat="server" Text="קומה עד :"></asp:Label>
        <asp:DropDownList CssClass="SmallDDL" ID="ddlFloorTo" runat="server" ></asp:DropDownList>
    </div>

    <div class="DetailDiv">
        <asp:Label CssClass="DetailsToFill" ID="Label17" runat="server" Text="גינה :"></asp:Label>
        <asp:DropDownList CssClass="SmallDDL" ID="ddlGarden" runat="server"></asp:DropDownList>
    </div>

    <div class="DetailDiv">
        <asp:Label CssClass="DetailsToFill" ID="Label18" runat="server" Text="מחיר מ :"></asp:Label>
        <asp:TextBox CssClass="SmallDDL" ID="TextBox18" runat="server" ></asp:TextBox>
    </div>

    <div class="DetailDiv">
        <asp:Label CssClass="DetailsToFill" ID="Label19" runat="server" Text="מחיר עד :"></asp:Label>
        <asp:TextBox CssClass="SmallDDL" ID="TextBox19" runat="server"></asp:TextBox>
    </div>

    <br />
    <br />
    <div id="Buttons">
        <asp:Button runat="server" ID="SendButton" Text="שלח" OnClick="SendNewBuyer" />
        <asp:Button runat="server" ID="ClearButton" Text="נקה" OnClick="ClearClicked" />
    </div>
</asp:Content>
