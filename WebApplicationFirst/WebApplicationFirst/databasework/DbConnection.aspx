<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DbConnection.aspx.cs" Inherits="WebApplicationFirst.databasework.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    

    <asp:Button ID="Button1" runat="server" Text="Connect with database" Height="50px" OnClick="Button1_Click" Width="220px" />

    <br />
    <br />

    <asp:Button ID="Button2" runat="server" Text="Disconnect from database" Height="50px" OnClick="Button2_Click" Width="220px" />

    <br />
    <br />
    <asp:Button ID="Button3" runat="server" Text="check connection state" Height="50px" OnClick="Button3_Click" Width="220px" />









</asp:Content>
