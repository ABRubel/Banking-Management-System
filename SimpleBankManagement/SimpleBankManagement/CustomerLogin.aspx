<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.master" AutoEventWireup="true" CodeBehind="CustomerLogin.aspx.cs" Inherits="SimpleBankManagement.CustomerLogin" %>
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
        Customer Login Form
    </h2>
        <br />    
    <br />
    Username: <asp:TextBox ID="custname" runat="server"></asp:TextBox>&nbsp;<br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="custname" ErrorMessage="Username Cannot be Empty!" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
    Password: &nbsp;<asp:TextBox ID="custpass" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="custpass" ErrorMessage="Password Cannot be Empty!" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />

        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" /><br />
        <asp:CheckBox ID="CheckBox1" runat="server" Checked="True" />Remember me<br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
    <p>
        Don't have an account?&nbsp;&nbsp; <a href="CustomerSignUp.aspx">SignUp</a>
    </p>
    </div>
    <br />
    <br />
    <br />    
    <br />
</asp:Content>

