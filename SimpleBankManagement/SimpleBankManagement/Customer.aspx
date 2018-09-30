<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="SimpleBankManagement.Customer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style6 {
            width: 395px;
            text-align: center;
        }
        .auto-style7 {
            width: 102%;
        }
        .auto-style8 {
            width: 20%;
            text-align: center;
        }
        .auto-style9 {
            width: 20%;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <br />
    <table class="auto-style7">
        <tr>
            <td class="auto-style6">Login As: Customer</td>
            <td class="auto-style8" rowspan="3">
                <asp:Button ID="Deposit" runat="server" OnClick="Diposit_Click" Text="Deposit Money" />
            </td>
            <td class="auto-style9" rowspan="3">
                <asp:Button ID="Withdraw" runat="server" OnClick="Withdraw_Click" Text="Withdraw Money" />
            </td>
            <td class="auto-style2" rowspan="3">
                <asp:Button ID="Transfer" runat="server" OnClick="Transfer_Click" Text="Transfer Money" />
            </td>
        </tr>
        <tr>
            <td class="auto-style6">Name: <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Logout" />
            </td>
        </tr>
    </table>

</asp:Content>
