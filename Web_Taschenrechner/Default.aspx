<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web_Taschenrechner._Default" %>

<!DOCTYPE html>
<html>
<head>
    <link href="Style/Taschenrechner.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .display {}
    </style>
</head>
<body>
    <form runat="server">
        <asp:TextBox ID="txtDisplay" CssClass="display" runat="server"></asp:TextBox>

        <div class="buttons">
            <asp:Button ID="btn1" Text="1" CssClass="btn" runat="server"/>
        </div>
    </form>
</body>
</html>

