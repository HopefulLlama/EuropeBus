<%@ Page Title="" Language="C#" MasterPageFile="~/customer/EuropeBus.Master" AutoEventWireup="true" CodeBehind="MyBooking.aspx.cs" Inherits="WebApp.customer.MyBooking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>My Bookings</h1>
    <p>Here you can view a listing of all your bookings.</p>
    <asp:Panel ID="mainContent" runat="server">
    </asp:Panel>
</asp:Content>
