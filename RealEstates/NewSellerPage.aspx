<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="NewSellerPage.aspx.cs" Inherits="Moti.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
     <h1>הוספת מוכר למאגר</h1>
        </div>
    <div class="row">
            <h3>פרטי הלקוח : </h3>
    </div>
    <div class="row">
        <div class="col-lg-2 col-lg-push-11">
            <asp:RadioButton  GroupName="RadioButton" OnCheckedChanged="Button1Changed"  ID="RadioButton1" runat="server" Text="לקוח קיים" TextAlign="Left" />
        </div>
        <div class="col-lg-4 col-lg-push-5">
            <asp:Label runat="server" Visible="false" ID="ExistUserErrorLabel" Text="מספר הזהות שגוי או שאינו קיים במערכת" ForeColor="Red"></asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-2 col-lg-push-10  ">
            <asp:Label  ID="Lable1" runat="server" CssClass="DetailsToFill" Text="תעודת זהות :"></asp:Label>
        </div>
        <div class="col-md-2 col-md-push-7">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
    </div>

    <div class="row">
        <div class="col-lg-2 col-lg-push-11">
            <asp:RadioButton GroupName="RadioButton" OnCheckedChanged="Button2Changed"  ID="RadioButton2" runat="server" Text=" לקוח חדש " TextAlign="Left" />
        </div>
        <div class="col-lg-5 col-lg-push-4">
            <asp:Label runat="server" Visible="false" Text="מספר הזהות קיים במערכת" ID="NewUserErrorLabel" ForeColor="Red"></asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-12">
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
        </div>
    </div>


    <div class="row">
        <div class="col-lg-2 col-lg-push-10">
            <h3>פרטי הנכס : </h3>
            <asp:Label class="DetailsHeader" ID="EstateErrorLabel" runat="server" ForeColor="Red" Text="חובה להזין את כל הפרטים" Visible="False"></asp:Label>
        </div>
    </div>

    <div class="row">
        <div class="col-lg-12">
            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label8" runat="server" Text="סוג הנכס :"></asp:Label>
                <asp:DropDownList CssClass="DetailsToFill" ID="ddlEstateKind" runat="server"></asp:DropDownList>
            </div>

            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label9" runat="server" Text="מחיר (בשקלים) :"></asp:Label>
                <asp:TextBox CssClass="SmallDDL" ID="TextBox9" runat="server"></asp:TextBox>
            </div>

            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label10" runat="server" Text="עיר :"></asp:Label>
                <asp:DropDownList CssClass="AddressDDL" ID="ddlCities" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCities_SelectedIndexChanged"></asp:DropDownList>
            </div>

            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label11" runat="server" Text="שכונה :"></asp:Label>
                <asp:DropDownList CssClass="AddressDDL" ID="ddlHood" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlHood_SelectedIndexChanged"></asp:DropDownList>
            </div>

            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label12" runat="server" Text="רחוב :"></asp:Label>
                <asp:DropDownList CssClass="AddressDDL" ID="ddlStreet" runat="server" AutoPostBack="True"></asp:DropDownList>
            </div>

            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label13" runat="server" Text="מספר :"></asp:Label>
                <asp:TextBox CssClass="SmallDDL" ID="TextBox13" runat="server"></asp:TextBox>
            </div>

            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label14" runat="server" Text="מספר חדרי שינה :"></asp:Label>
                <asp:DropDownList CssClass="SmallDDL" ID="ddlBedroomNum" runat="server"></asp:DropDownList>
            </div>

            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label15" runat="server" Text="שטח (מ''ר) :"></asp:Label>
                <asp:TextBox CssClass="SmallDDL" ID="TextBox15" runat="server"></asp:TextBox>
            </div>

            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label16" runat="server" Text="קומה :"></asp:Label>
                <asp:DropDownList CssClass="SmallDDL" ID="ddlFloorNumber" runat="server"></asp:DropDownList>
            </div>

            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label17" runat="server" Text="מדרגות :"></asp:Label>
                <asp:DropDownList CssClass="SmallDDL" ID="ddlStairs" runat="server"></asp:DropDownList>
            </div>

            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label18" runat="server" Text="מעלית :"></asp:Label>
                <asp:DropDownList CssClass="SmallDDL" ID="ddlElavator" runat="server"></asp:DropDownList>
            </div>

            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label19" runat="server" Text="מספר מרפסות :"></asp:Label>
                <asp:DropDownList CssClass="SmallDDL" ID="ddlBalcony" runat="server"></asp:DropDownList>
            </div>

            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label20" runat="server" Text="שירותים :"></asp:Label>
                <asp:DropDownList CssClass="SmallDDL" ID="ddlToilet" runat="server"></asp:DropDownList>
            </div>

            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label21" runat="server" Text="מקלחות :"></asp:Label>
                <asp:DropDownList CssClass="SmallDDL" ID="ddlShowers" runat="server"></asp:DropDownList>
            </div>

            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label22" runat="server" Text="מחסן :"></asp:Label>
                <asp:DropDownList CssClass="SmallDDL" ID="ddlStorge" runat="server"></asp:DropDownList>
            </div>

            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label23" runat="server" Text="חנייה פרטית :"></asp:Label>
                <asp:DropDownList CssClass="SmallDDL" ID="ddlParking" runat="server"></asp:DropDownList>
            </div>

            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label24" runat="server" Text="גינה (מ''ר) :"></asp:Label>
                <asp:TextBox CssClass="SmallDDL" ID="TextBox24" runat="server"></asp:TextBox>
            </div>

            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label25" runat="server" Text="משופצת :"></asp:Label>
                <asp:DropDownList CssClass="SmallDDL" ID="ddlRenovated" runat="server"></asp:DropDownList>
            </div>

            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label26" runat="server" Text="דוד שמש :"></asp:Label>
                <asp:DropDownList CssClass="SmallDDL" ID="ddlBoyler" runat="server"></asp:DropDownList>
            </div>

            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label27" runat="server" Text="סורגים :"></asp:Label>
                <asp:DropDownList CssClass="SmallDDL" ID="ddlBars" runat="server"></asp:DropDownList>
            </div>

            <div class="DetailDiv">
                <asp:Label CssClass="DetailsToFill" ID="Label28" runat="server" Text="פלדלת :"></asp:Label>
                <asp:DropDownList CssClass="SmallDDL" ID="ddlPladelet" runat="server"></asp:DropDownList>
            </div>
        </div>
    </div>

    <div class="row">
        <div id="Buttons">
            <asp:Button runat="server" ID="SendButton" Text="שלח" OnClientClick="return UserValidate();" OnClick="SendNewSeller" />
            <asp:Button runat="server" ID="ClearButton" Text="נקה" OnClick="ClearClicked" />
        </div>
    </div>
</asp:Content>
