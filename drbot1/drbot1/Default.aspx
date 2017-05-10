<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="drbot1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>     
    <link rel="stylesheet" href="http://www.dr.dk/assets/css/007/global.css">
  <script src="http://www.dr.dk/drdkTopbar/topbarbundle.js?version=007"></script>
    <link rel="stylesheet/less" type="text/css" href="css/style.less" />             <!-- Latest compiled and minified CSS -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" />

<!-- Optional theme -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous">

<!-- Latest compiled and minified JavaScript -->
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
  <script src="js/less.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                        
<div id="main"><!-- start main -->
   <div id="top"><!-- start top -->
       <div id="text">Sp&oslash;rgsm&aring;l drbot</div>
   </div><!-- slut top -->
   <div id="indhold"><!-- start indhold -->
                <div class="sp">
                    Ved du hvad kommunalvalget er?
                </div>

                    
                        <asp:Label ID="Label_sv" CssClass="sv" runat="server"></asp:Label>
                <tr><td>
                    <asp:Label ID="Label_m" runat="server"></asp:Label>
                    </td><td>
                        </td><td>
                        <asp:Label ID="Label_sv1" runat="server"></asp:Label></td></tr>
                <tr><td>
            </table>
                               <asp:Panel ID="Panel1" runat="server" CssClass="bru"><asp:Button ID="Button_mat" runat="server" CssClass="mybutton" Text="Ja" OnClick="Button_mat_Click" />
                            <asp:Button ID="Button_mwc" runat="server" CssClass="mybutton" Text="Nej" OnClick="Button_mwc_Click" />
                        </asp:Panel>
                    <asp:Panel ID="Panel2" runat="server" CssClass="bru"><asp:Button ID="Button_o" runat="server" CssClass="mybutton" Text="Over 18" OnClick="Button_o_Click" />
                        <asp:Button ID="Button_u" runat="server" CssClass="mybutton" Text="Under 18" OnClick="Button_u_Click" />
</asp:Panel>
        </div>
      

   </div><!-- slut indhold -->
</div><!-- slut main -->
    </form>
</body>
</html>
