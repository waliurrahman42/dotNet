<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" Async="true" AutoEventWireup="true" CodeBehind="ManageUser.aspx.cs" Inherits="WebApplicationFirst.databasework.ManageUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

 <table style="width: 70%; margin:auto; border: 2px solid #0000FF; background-color: #CCFFCC">        <tr>            <td style="width: 255px; background-color: #FFFF00;" class="text-center">M<span style="color: #FF6600">anageUser</td>
            <td style="width: 223px; background-color: #FFFF00;" class="text-center">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 255px; height: 54px; background-color: #FFFF00; color: #FF9900;" class="text-center"><b>User Id</b></span></td>
            <td style="width: 223px; height: 54px" class="text-center">
              
                <asp:TextBox ID="txtUserId" runat="server" style="font-weight: bold; color: #FF6600; background-color: #FFFF00"></asp:TextBox>
              
                <asp:Button ID="btnSearchUser" runat="server" EnableTheming="True" OnClick="btnSearch_Click" Text="find user" style="color: #FF6600; background-color: #FFFF00" />
              
            </td>
        </tr>
        <tr>
            <td style="width: 255px; height: 46px; color: #FF6600; background-color: #FFFF00;" class="text-center"><b>user NAME</b></td>
            <td style="width: 223px; height: 46px" class="text-center">
               
                <asp:TextBox ID="txtUserName" runat="server" style="font-weight: bold; color: #FF6600; background-color: #FFFF00"></asp:TextBox>
               
            </td>
        </tr>
        <tr>
            <td style="width: 255px; height: 41px; color: #FF6600; background-color: #FFFF00;" class="text-center"><b>full name</b></td>
            <td style="width: 223px; height: 41px" class="text-center">
                
                <asp:TextBox ID="txtName" runat="server" style="font-weight: bold; color: #FF6600; background-color: #FFFF00"></asp:TextBox>
                
            </td>
        </tr>
        <tr>
            <td style="width: 255px; height: 49px; color: #FF6600; background-color: #FFFF00;" class="text-center"><b>mobile</b></td>
            <td style="width: 223px; height: 49px" class="text-center">
                
                <asp:TextBox ID="txtMobile" runat="server" style="font-weight: bold; color: #FF6600; background-color: #FFFF00"></asp:TextBox>
                
            </td>
        </tr>
        <tr>
            <td style="height: 161px" class="text-center" colspan="2">
               <asp:Button ID="btnUpdate" runat="server" EnableTheming="True" OnClick="btnUpdate_Click" Text="Update user" style="color: #FF6600; background-color: #FFFF00" />
                <asp:Button ID="btnDelete" runat="server" EnableTheming="True" OnClick="btnDelete_Click" Text="delete user" style="color: #FF6600; background-color: #FFFF00" />
            &nbsp;<asp:Button ID="btnViewAll" runat="server" EnableTheming="True" OnClick="btnViewAll_Click" Text="view all user" style="color: #FF6600; background-color: #FFFF00" />
            </td>
            
            
        </tr>
        <tr>
            <td style="height: 112px" colspan="2">
                <b>
                <asp:Label ID="Label1" runat="server" style="color: #FF6600; background-color: #FFFF00"></asp:Label>
                </b>
            </td>
        </tr>
        <tr>
            <td style="height: 112px" colspan="2">
                <asp:GridView ID="GridView1" runat="server" Height="234px" style="margin-top: 0px" Width="506px">
                </asp:GridView>
            </td>
        </tr>
    </table>

</asp:Content>
