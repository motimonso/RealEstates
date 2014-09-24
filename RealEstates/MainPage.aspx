<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="Moti.MainPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>ראשי - חדשות</h1>
    <div style="max-height: 350px;">
        <asp:GridView ID="NewsRSS" runat="server" AutoGenerateColumns="false" ShowHeader="false">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <div class="col-lg-12">
                            <div class="row fixFeed ">
                                <div class="col-md-12 matchDiv">
                                    <h4><%#Eval("Title") %></h4>
                                </div>
                            </div>
                            <div class="row fixFeed">
                                <div class="col-md-10 matchDiv">
                                    <%#Eval("Description") %>
                                </div>
                                <div class="col-lg-2  matchDiv fixFeed">
                                    <%#Eval("PictureFromDescription") %>
                                </div>
                            </div>
                            <div class="row  fixFeed">
                                <div class="col-lg-1 col-lg-push-1 matchDiv">
                                    <a id="linkA" href='<%#Eval("Link") %>' target="_blank" dir="rtl">קרא עוד...</a>

                                </div>
                            </div>
                            <br />
                        </div>
                        





                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>

        </asp:GridView>


    </div>
</asp:Content>
