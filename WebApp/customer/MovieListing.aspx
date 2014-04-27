<%@ Page Title="" Language="C#" MasterPageFile="~/customer/EuropeBus.Master" AutoEventWireup="true" CodeBehind="MovieListing.aspx.cs" Inherits="WebApp.customer.MovieListing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1>Movie Listing</h1>
    <p>This page serves as a view point for browsing through movies, along with their details, which are offered by Movie Rentals. In addition, you should click on a suitable movie if you are interested in booking a rental for a movie for a journey you have booked.</p><br />
    <br />
    <asp:Panel ID="SearchLinkPanel" runat="server" style="margin-left:10%; text-align: left;" BackColor="#EEEEEE" BorderColor="#999999" BorderStyle="Solid" BorderWidth="2px" Width="80%">
         &nbsp;
         <asp:LinkButton ID="SearchLink" runat="server" CssClass="standardLinkButton" OnClick="SearchLinkClicked">Search</asp:LinkButton>
     </asp:Panel>
    <asp:Panel ID="SearchPanel" runat="server" style="margin-left:10%; border-top:none; text-align: center;" Width="80%" BackColor="#EEEEEE" BorderColor="#999999" BorderStyle="Dashed" BorderWidth="2px" Visible="false">
        <br />
        <asp:Label ID="MovieTitleLabel" Text="Movie Title: " runat="server" CssClass="FormLabel" /><asp:TextBox ID="MovieTitleTextbox" runat="server"/>
        <asp:Button ID="Submit" Text="Search!" runat="server" OnClick="SubmitButtonClicked"/>
        <br />
    </asp:Panel>
    <br />
    
    <asp:Panel ID="moviesPanel" runat="server"></asp:Panel>
</asp:Content>
