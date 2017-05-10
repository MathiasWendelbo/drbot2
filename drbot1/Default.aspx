<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="drbot1.Default" %>

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
        .mybtn{
               box-shadow: rgb(255, 255, 255) 0px 1px 0px 0px inset;
    background: linear-gradient(rgb(255, 255, 255) 5%, rgb(246, 246, 246) 100%) rgb(255, 255, 255);
    border-radius: 6px;
    border: 1px solid rgb(220, 220, 220);
    display: inline-block;
    cursor: pointer;
    color: #000;
    font-family: Helvetica;
    font-size: 17px;
    padding: 9px 24px;
    text-decoration: none;
        }
    </style>
</head>
    
<body>
    <form id="form1" runat="server">
        <div>
                        
<div id="main"><!-- start main -->
   <div id="top"><!-- start top -->
       <div id="text">Sp&oslash;rgsm&aring;l drbot</div>
   </div><!-- slut top -->
   <div id="indhold"><!-- start indhold -->
       <div id="indh"><!-- start indh -->
                <div class="sp">
                    Ved du hvad kommunalvalget er?
                </div>

       <asp:Label ID="Label_svar" runat="server" CssClass="sv" ></asp:Label>
           <div class="clear"></div>
           <asp:Literal ID="Literal_sv" runat="server"></asp:Literal>
           <div class="clear"></div>
           <asp:Label ID="Label_sv" runat="server" CssClass="sp"></asp:Label>
           <div class="clear"></div>
       
            <div class="clear"></div>
           <asp:Label ID="Label_s" runat="server" CssClass="sv"></asp:Label>
           <div class="clear"></div>  
    <asp:Label ID="Label_s1" runat="server" CssClass="sp" ></asp:Label>
           <div class="clear"></div>
                                   <asp:Panel ID="Panel1" runat="server" CssClass="bru">

                        </asp:Panel>
                  
                    <asp:Panel ID="Panel2" runat="server" CssClass="pa">                  
</asp:Panel>
       <asp:Label ID="Label_bor" runat="server" CssClass="sp"></asp:Label>
       <div class="clear"></div>  
       <asp:Label ID="Label_bor_sv" runat="server" CssClass="sv"></asp:Label>
       <div class="clear"></div>  
       <asp:Label ID="Label_bor_sp" runat="server" CssClass="sp"></asp:Label>
       <div class="clear"></div>
       <asp:Label ID="Label_bor_sv0" runat="server" CssClass="sp"></asp:Label>
   
        </div>
       <div id="bund">
           <asp:Button ID="Button_mat" runat="server" CssClass="mybtn" Text="Ja" OnClick="Button_mat_Click" />
                <asp:Button ID="Button_mwc" runat="server" CssClass="mybtn" Text="Nej" OnClick="Button_mwc_Click" /> 
                <asp:Button ID="Button_u" runat="server" CssClass="mybtn" Text="Under 18" OnClick="Button_u_Click" /><asp:Button ID="Button_o" runat="server" CssClass="mybtn" Text="Over 18" OnClick="Button_o_Click" />
           <asp:Repeater ID="Repeater_landdele" runat="server">
               <ItemTemplate>
                   <asp:Button ID="Button1" runat="server" CssClass="mybtn" Text='<%# Eval("land") %>' OnCommand="land" CommandArgument='<%# Eval("Id") %>' CommandName="land" />
               </ItemTemplate>
           </asp:Repeater>
  </div>
    </div><!-- slut indh -->
            <div class="bund">
                          </div>
   </div><!-- slut indhold -->
</div><!-- slut main -->
    </form>
</body>
</html>
