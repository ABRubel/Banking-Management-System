<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="SimpleBankManagement.AdminLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        .content
        {
            text-align:center;
            
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <br />    
    <br />
    <div class="content">
    <h2>
        Admin Login Form
    </h2>
        <br />    
    <br />
    Username: <asp:TextBox ID="adminname" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="adminname" ErrorMessage="Username Cannot be Empty!" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
    Password: <asp:TextBox ID="adminpass" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="adminpass" ErrorMessage="Password Cannot be Empty!" ForeColor="Red"></asp:RequiredFieldValidator>
        <br /><br />
    <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
    </div>
    <br />
    <br />
    <br />    
    <br />
</asp:Content>
