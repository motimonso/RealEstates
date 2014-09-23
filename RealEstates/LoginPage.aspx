﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Moti.LoginPage" %>

<%@ Register Src="Header.ascx" TagName="Header" TagPrefix="uc1" %>

<%@ Register Src="LoginHeader.ascx" TagName="LoginHeader" TagPrefix="uc2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="css/login.css" />
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <div class="container">
        <form id="form1" runat="server">
            <div class="row">
                    <div class="col-lg-12  ">
                        <img alt="logo" class="img-responsive fixCenter" src="img/logo.jpg" />
                    </div>
            </div>
            <div class="login">
                <div class="login-screen">
                    <div class="app-title">
                        <h1>כניסה למערכת</h1>
                    </div>
                    <div class="login-form">
                        <div class="control-group">
                            <asp:TextBox runat="server" CssClass="login-field" ID="userNameLogin"></asp:TextBox>
                            <label class="login-field-icon fui-user" for="login-name"></label>
                        </div>
                        <div class="control-group">
                            <asp:TextBox runat="server" CssClass="login-field" TextMode="Password" ID="passwordLogin"></asp:TextBox>
                            <label class="login-field-icon fui-lock" for="login-pass"></label>
                        </div>
                        <asp:LinkButton CssClass="btn btn-primary btn-large btn-block" runat="server" OnClick="Button1_Click" ID="loginButton">התחבר</asp:LinkButton>
                       
                    </div>
                    <div style="text-align:center">
                      <asp:Label runat="server" Visible="false" ID="ErrorLabel" Text="מספר הזהות שגוי או שאינו קיים במערכת" ForeColor="Red"></asp:Label>
                </div>
                    </div>
            </div>
        </form>
    </div>
</body>
</html>
