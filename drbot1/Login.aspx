<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="drbot1.Login" %>

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
    <style type="text/css">
       
    </style>

</head>
<body>
    <form id="form2" runat="server">
        <div>
                   <div>
                        
<div id="main"><!-- start main -->
   <div id="top"><!-- start top -->
       <div id="text">Sp&oslash;rgsm&aring;l drbot</div>
   </div><!-- slut top -->
   <div id="indhold"><!-- start indhold -->
       <div id="indh"><!-- start indh -->
            <div class="sp">
                <table>
                    <tr><td>Brugenavn</td><td>
                        <asp:TextBox ID="TextBox_brn" runat="server"></asp:TextBox></td></tr>
                    <tr><td>Password</td><td>
                        <asp:TextBox ID="TextBox_pass" runat="server" TextMode="Password"></asp:TextBox></td></tr>
                    <tr><td>
                        <asp:Label ID="Label_login" runat="server"></asp:Label></td><td>
                            <asp:Button ID="Button_login" runat="server" Text="Login" OnClick="Button_login_Click" /></td></tr>
                </table>
            </div>
        </div>
    </div><!-- slut indh -->
            <div class="bund">
                          </div>
   </div><!-- slut indhold -->
</div><!-- slut main -->
        </div>
    </form>
</body>
</html>
