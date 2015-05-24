<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormWithADO.net._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:GridView ID="GridView1" runat="server">
        <Columns>
            <asp:BoundField DataField="ProductName" HeaderText="ProductName" />
        </Columns>
    </asp:GridView>

</asp:Content>
