<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web_Taschenrechner._Default" %>

<!DOCTYPE html>
<html>
<head>
    <link href="Style/Taschenrechner.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        form{
            margin: 10% 20%;
            background-color: gray;
        }

        .panDisplay, .row {

        }
    </style>
</head>
<body>
    <form runat="server">
        <div class="panDisplay" >
            <asp:TextBox ID="txtDisplay" CssClass="display" runat="server" />
            <asp:Label ID="labRechenzeichen" CssClass="label" runat="server" Text="hallo" />
        </div>

        <div class="allButtons">
            <div class="panNumbs">
                <asp:Button ID="btnClear" Text="C" CssClass="btnlong operator" runat="server"/>
            
                <div class="row">                
                    <asp:Button ID="btn1" Text="1" CssClass="btn numb" runat="server"/>
                    <asp:Button ID="btn2" Text="2" CssClass="btn numb" runat="server"/>
                    <asp:Button ID="btn3" Text="3" CssClass="btn numb" runat="server"/>
                </div>
            
                <div class="row">                
                    <asp:Button ID="Button4" Text="4" CssClass="btn numb" runat="server"/>
                    <asp:Button ID="Button5" Text="5" CssClass="btn numb" runat="server"/>
                    <asp:Button ID="Button6" Text="6" CssClass="btn numb" runat="server"/>
                </div>
            
                <div class="row">                
                    <asp:Button ID="Button7" Text="7" CssClass="btn numb" runat="server"/>
                    <asp:Button ID="Button8" Text="8" CssClass="btn numb" runat="server"/>
                    <asp:Button ID="Button9" Text="9" CssClass="btn numb" runat="server"/>
                </div>
            
                <div class="row" >
                    <asp:Button ID="btnKomma" Text="0" CssClass="btn operator" runat="server"/>
                    <asp:Button ID="btn0" Text="0" CssClass="btn numb" runat="server"/>
                    <asp:Button ID="btnGleich" Text="0" CssClass="btn operator" runat="server"/>
                </div>
            </div>

            <div class="panOperatoren" >
                <asp:Button ID="btnPlus" Text="+" CssClass="btn operator" runat="server" />
                <asp:Button ID="btnMinus" Text="-" CssClass="btn operator" runat="server"/>
                <asp:Button ID="btnMal" Text="*" CssClass="btn operator" runat="server"/>
                <asp:Button ID="btnGeteilt" Text="÷" CssClass="btn operator" runat="server"/>
            </div>
        </div>
    </form>
</body>
</html>

