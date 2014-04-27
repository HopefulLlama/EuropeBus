<%@ Page Title="" Language="C#" MasterPageFile="~/customer/EuropeBus.Master" AutoEventWireup="true" CodeBehind="CoachListing.aspx.cs" Inherits="WebApp.customer.CoachListing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Coach Listing</h1>
    <p>Please select a coach that you wish to travel on.</p><br />
    <asp:Panel ID="infoLinkPanel" runat="server" style="margin-left:10%; text-align: left;" BackColor="#EEEEEE" BorderColor="#999999" BorderStyle="Solid" BorderWidth="2px" Width="80%">
         &nbsp;
         <asp:LinkButton ID="infoLink" runat="server" CssClass="standardLinkButton" OnClick="InfoLinkClicked">Selected Items</asp:LinkButton>
     </asp:Panel>
    <asp:Panel ID="infoPanel" runat="server" style="margin-left:10%; border-top:none; text-align: center;" Width="80%" BackColor="#EEEEEE" BorderColor="#999999" BorderStyle="Dashed" BorderWidth="2px" Visible="false">
        <br />
    </asp:Panel>
    <br />
    <asp:Panel ID="coachPanel" runat="server">
        <h2>Available Coaches</h2>
    </asp:Panel>
</asp:Content>
