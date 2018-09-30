<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.master" AutoEventWireup="true" CodeBehind="Transfer.aspx.cs" Inherits="SimpleBankManagement.Transfer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style6 {
            width: 445px;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <table class="auto-style1">
        <tr>
            <td class="auto-style6">Login As: Customer</td>
            <td class="auto-style2">Trasnsaction Email:
                <asp:TextBox ID="TEmail" runat="server"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TEmail" ErrorMessage="Transaction Email cannot be empty" ForeColor="#0066FF"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style2">Transfer Amount:
                <asp:TextBox ID="Amount" runat="server"></asp:TextBox>
                <br />
                <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="Amount" ErrorMessage="Amount Cannot be Negative or Null" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">Name: <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:Button ID="Confirm" runat="server" Text="Confirm" OnClick="Confirm_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Button ID="Logout" runat="server"  Text="Logout" style="height: 26px" OnClick="Logout_Click" />
            </td>
            <td class="auto-style2"> <asp:Label ID="Label2" runat="server"></asp:Label>
            </td>
        </tr>
    </table>

</asp:Content>