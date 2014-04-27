<%@ Page Title="" Language="C#" MasterPageFile="~/customer/EuropeBus.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApp.EuropeBus.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Register an Account</h1>
<p>
    <asp:Label ID="Label2" runat="server" Text="E-mail Address: " CssClass="FormLabel"></asp:Label>
    <asp:TextBox ID="txtboxEmail" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label6" runat="server" Text="Password: " CssClass="FormLabel"></asp:Label>
    <asp:TextBox ID="txtboxPassword" runat="server" TextMode="Password"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label7" runat="server" Text="Confirm Password: " CssClass="FormLabel"></asp:Label>
    <asp:TextBox ID="txtboxConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
</p>
<p>
    &nbsp;</p>
<p>
    <asp:Label ID="Label8" runat="server" Text="First Name: " CssClass="FormLabel"></asp:Label>
    <asp:TextBox ID="txtboxFirstName" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label1" runat="server" Text="Surname: " CssClass="FormLabel"></asp:Label>
    <asp:TextBox ID="txtboxSurname" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label9" runat="server" Text="Gender: " CssClass="FormLabel"></asp:Label>
    <asp:DropDownList ID="dropGender" runat="server">
        <asp:ListItem Value="1">Male</asp:ListItem>
        <asp:ListItem Value="0">Female</asp:ListItem>
    </asp:DropDownList>
</p>
<p>
    <asp:Label ID="Label3" runat="server" Text="Date of Birth: " CssClass="FormLabel"></asp:Label>
    <asp:Calendar ID="calDateOfBirth" runat="server"></asp:Calendar>
</p>
<p>
    <asp:Label ID="Label4" runat="server" Text="Phone Number: " CssClass="FormLabel"></asp:Label>
    <asp:TextBox ID="txtboxPhoneNumber" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label5" runat="server" Text="Address: " CssClass="FormLabel"></asp:Label>
    <asp:TextBox ID="txtboxAddress" runat="server" Rows="5" TextMode="MultiLine"></asp:TextBox>
</p>
<p>
    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit!" />
</p>
</asp:Content>
