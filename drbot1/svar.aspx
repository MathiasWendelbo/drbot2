<%@ Page Title="" Language="C#" MasterPageFile="~/Cms.Master" AutoEventWireup="true" CodeBehind="svar.aspx.cs" Inherits="drbot1.svar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="over">Svar</div>
    <div class="left">
        <div class="fed">Vis</div>
        <div class="ned">
            <asp:GridView ID="GridView_spoerg" runat="server"></asp:GridView>
        </div>

        <div class="fed">Slet</div>
        <div  class="ned">
             <table>
            <tr><td>Post</td><td><asp:DropDownList ID="DropDownList_slet" runat="server"></asp:DropDownList></td></tr>
            <tr><td><asp:Label ID="Label_slet" runat="server"></asp:Label></td><td><asp:Button ID="Button_slet" runat="server" Text="Slet" /></td></tr>     </table>
        </div>
    </div>
    <div class="left">
        <div class="fed">Opret</div>
        <div class="ned">
            <table>
                <tr><td>Spørgsmål</td><td>
                    <asp:DropDownList ID="DropDownList_land" runat="server" ValidationGroup="form"></asp:DropDownList></td><td>
                        <asp:RequiredFieldValidator ControlToValidate="DropDownList_land" ID="RequiredFieldValidator_land" ValidationGroup="form" ErrorMessage="Du kan valg en reg" InitialValue="0" runat="server"  Display="Dynamic">*</asp:RequiredFieldValidator></td></tr>
                <tr><td>Svar</td><td>
                    <asp:TextBox ID="TextBox_sv" runat="server" ValidationGroup="form"></asp:TextBox>
                        </td><td>
                                          <asp:RequiredFieldValidator ID="RequiredFieldValidator_sv" runat="server" ErrorMessage="Du skriv svar" ControlToValidate="TextBox_sv" ValidationGroup="form">*</asp:RequiredFieldValidator></td></tr>
               <tr><td>Knap</td><td><asp:TextBox ID="TextBox_knap" runat="server" ValidationGroup="form"></asp:TextBox>
                        </td><td>
                                          <asp:RequiredFieldValidator ID="RequiredFieldValidator_knap" runat="server" ErrorMessage="Du skriv knap" ControlToValidate="TextBox_knap" ValidationGroup="form">*</asp:RequiredFieldValidator></td></tr>
                <tr><td><asp:Label ID="Label_opret" runat="server"></asp:Label></td><td><asp:Button ID="Button_opret" runat="server" Text="Opret" ValidationGroup="form" /></td></tr>
            </table>
        </div>
        <div class="ned">
            <asp:ValidationSummary ID="ValidationSummary_form" runat="server" ValidationGroup="form" />
        </div>
 
        <div class="fed">Opret</div>
        <div class="ned">
            <table>
                <tr><td>Valg</td><td>

                    <asp:DropDownList ID="DropDownList_valg" runat="server" AutoPostBack="true"></asp:DropDownList>

                                 </td></tr>
                <tr><td>Spørgsmål</td><td>
                    <asp:TextBox ID="TextBox_osp" runat="server"></asp:TextBox></td></tr>
                <tr><td>Svar</td><td>
                    <asp:TextBox ID="TextBox_osv" runat="server"></asp:TextBox></td></tr>
                <tr><td><asp:Label ID="Label_opdate" runat="server"></asp:Label></td><td><asp:Button ID="Button_opdate" runat="server" Text="Opdate" OnClick="Button_opdate_Click"  /></td></tr>
            </table>
        </div>
        </div>
</asp:Content>
