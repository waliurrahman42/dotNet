<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="WebApplicationFirst.databasework.AddUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table style="width: 70%; margin:auto; border: 2px solid #0000FF; background-color: #CCFFCC">        <tr>            <td style="width: 255px">ADD NEW USER&nbsp;</td>
            <td style="width: 389px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 255px; height: 54px">username</td>
            <td style="width: 389px; height: 54px">
              
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
              
            </td>
        </tr>
        <tr>
            <td style="width: 255px; height: 46px">password</td>
            <td style="width: 389px; height: 46px">
               
                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
               
            </td>
        </tr>
        <tr>
            <td style="width: 255px; height: 41px">full name</td>
            <td style="width: 389px; height: 41px">
                
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                
            </td>
        </tr>
        <tr>
            <td style="width: 255px; height: 49px">mobile</td>
            <td style="width: 389px; height: 49px">
                
                <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
                
            </td>
        </tr>
        <tr>
            <td style="width: 255px; height: 67px"></td>
            <td style="width: 389px; height: 67px">
                <asp:Button ID="btnsave" runat="server" EnableTheming="True" OnClick="btnSave_Click" Text="Add User" />
            </td>
        </tr>
        <tr>
            <td style="width: 255px; height: 112px"></td>
            <td style="height: 112px; width: 389px">
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
    </table>


  


   


  


</asp:Content>
