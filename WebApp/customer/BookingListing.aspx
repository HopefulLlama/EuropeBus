<%@ Page Title="" Language="C#" MasterPageFile="~/customer/EuropeBus.Master" AutoEventWireup="true" CodeBehind="BookingListing.aspx.cs" Inherits="WebApp.customer.BookingListing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Booking Listing</h1>
    <asp:Panel ID="summaryPanel" runat="server" />
    <asp:Panel ID="infoLinkPanel" runat="server" style="margin-left:10%; text-align: left;" BackColor="#EEEEEE" BorderColor="#999999" BorderStyle="Solid" BorderWidth="2px" Width="80%">
         &nbsp;
         <asp:LinkButton ID="infoLink" runat="server" CssClass="standardLinkButton" OnClick="InfoLinkClicked">Selected Items</asp:LinkButton>
     </asp:Panel>
    <asp:Panel ID="infoPanel" runat="server" style="margin-left:10%; border-top:none; text-align: center;" Width="80%" BackColor="#EEEEEE" BorderColor="#999999" BorderStyle="Dashed" BorderWidth="2px" Visible="false">
        <br />
    </asp:Panel>
    <asp:Panel ID="mainContent" runat="server">
    </asp:Panel>
</asp:Content>
