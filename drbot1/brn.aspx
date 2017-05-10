<%@ Page Title="" Language="C#" MasterPageFile="~/Cms.Master" AutoEventWireup="true" CodeBehind="brn.aspx.cs" Inherits="drbot1.brn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="over">
        <br />
        spørgmål</div>
    <div class="left">

 
        <div class="fed">Opret</div>
        <div class="ned">
            <table>
              
                <tr><td>Brugernavn</td><td>
                    <asp:TextBox ID="TextBox_brn" runat="server"></asp:TextBox></td></tr>
                <tr><td>Password</td><td>
                    <asp:TextBox ID="TextBox_pass" runat="server"></asp:TextBox></td></tr>
                <tr><td><asp:Label ID="Label_opdate" runat="server"></asp:Label></td><td><asp:Button ID="Button_opdate" runat="server" Text="Opdate" OnClick="Button_opdate_Click" /></td></tr>
            </table>
        </div>
        </div>
</asp:Content>
