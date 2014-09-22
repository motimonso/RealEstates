<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="Moti.MainPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>ראשי - חדשות</h1>
    <div style="max-height: 350px; overflow: auto;">
        <asp:GridView ID="NewsRSS" runat="server" AutoGenerateColumns="false" ShowHeader="false" Width="90%">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <table width="100%" cellpadding="0" cellspacing="5">
                            <tr>
                                <td>
                                    <a style="color: #3E7CFF"><%#Eval("Title") %></a>
                                </td>
                                <td width="200px">
                                    <%#Eval("PublishDate") %>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <hr />
                                    <%#Eval("Description") %>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td align="right">
                                    <a href='<%#Eval("Link") %>' target="_blank" dir="rtl">קרא עוד...</a>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>

        </asp:GridView>


    </div>
</asp:Content>
