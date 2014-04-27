<%@ Page Title="" Language="C#" MasterPageFile="~/customer/EuropeBus.Master" AutoEventWireup="true" CodeBehind="RouteListing.aspx.cs" Inherits="WebApp.customer.RouteListing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Route Listing</h1>
    <p>This page serves as a view point for browsing through routes, along with their details, which are offered by EuropeBus. In addition, you should click on a suitable route if you are interested in booking a ticket for a journey on that route.</p><br />
    <br />
    <asp:Panel ID="SearchLinkPanel" runat="server" style="margin-left:10%; text-align: left;" BackColor="#EEEEEE" BorderColor="#999999" BorderStyle="Solid" BorderWidth="2px" Width="80%">
         &nbsp;
         <asp:LinkButton ID="SearchLink" runat="server" CssClass="standardLinkButton" OnClick="SearchLinkClicked">Search</asp:LinkButton>
     </asp:Panel>
    <asp:Panel ID="SearchPanel" runat="server" style="margin-left:10%; border-top:none; text-align: center;" Width="80%" BackColor="#EEEEEE" BorderColor="#999999" BorderStyle="Dashed" BorderWidth="2px" Visible="false">
        <br />
        <asp:Table runat="server">
            <asp:TableHeaderRow runat="server">
                <asp:TableHeaderCell Text="" runat="server"></asp:TableHeaderCell>
                <asp:TableHeaderCell Text="Departure" runat="server"></asp:TableHeaderCell>
                <asp:TableHeaderCell Text="Destination" runat="server"></asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow runat="server">
                <asp:TableCell Text="Country" runat="server"></asp:TableCell>
                <asp:TableCell runat="server"><asp:TextBox ID="DepartureCountryTextbox" runat="server"></asp:TextBox></asp:TableCell>
                <asp:TableCell runat="server"><asp:TextBox ID="DestinationCountryTextbox" runat="server"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell Text="Town" runat="server"></asp:TableCell>
                <asp:TableCell runat="server"><asp:TextBox ID="DepartureTownTextbox" runat="server"></asp:TextBox></asp:TableCell>
                <asp:TableCell runat="server"><asp:TextBox ID="DestinationTownTextbox" runat="server"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <br />
        <asp:Label Text="Date of departure:" CssClass="FormLabel" runat="server"></asp:Label><asp:Calendar ID="DateOfDepartureCalendar" runat="server"></asp:Calendar>
        <br />
        <br />
        <asp:Label Text="Number of passengers: " CssClass="FormLabel" runat="server"></asp:Label><asp:TextBox ID="NumberOfPassengersTextbox" runat="server" TextMode="Number"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Submit" Text="Search!" runat="server" OnClick="SubmitButtonClicked"/>
    </asp:Panel>
    <br />
    
    <asp:Panel ID="routesPanel" runat="server"></asp:Panel>
</asp:Content>
