<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplicationFirst.databasework.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <table align="center" style="width: 74%; background-color: #FFFF66">
        <tr>
            <td style="height: 40px; text-align: center;" colspan="2"><b><span style="background-color: #CCFF33">Login here</span></b></td>
        </tr>
        <tr>
            <td style="width: 218px; height: 66px;"><b><span style="background-color: #CCFF33">username:</span></b></td>
            <td style="height: 66px">
                <asp:TextBox ID="TxtUserName" runat="server" style="font-weight: bold; background-color: #CCFF33"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 218px; height: 80px;"><b><span style="background-color: #CCFF33">password:</span></b></td>
            <td style="height: 80px">
                <asp:TextBox ID="TxtPassword" runat="server" style="font-weight: bold; background-color: #CCFF33"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 218px; height: 103px;"></td>
            <td style="height: 103px">
                <asp:Button ID="btnlogin" runat="server" style="background-color: #CCFF33" Text="signin" OnClick="btnlogin_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 218px">&nbsp;</td>
            <td><b>
                <asp:Label ID="lblmsg" runat="server" style="background-color: #CCFF33" ForeColor="#FF3300"></asp:Label>
                </b></td>
        </tr>
    </table>



</asp:Content>
