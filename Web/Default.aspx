﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtUrl" runat="server" Text="http://www.baidu.com" Width="200px"></asp:TextBox>
        <asp:Button ID="btnRun" runat="server" Text="Run" OnClick="btnRun_Click" />
        <asp:Button ID="btnRunEO" runat="server" Text="Run EO" OnClick="btnRunEO_Click" />
        <asp:Label ID="lbMessage" runat="server" Text="Click Run"></asp:Label>
    </div>
    </form>
</body>
</html>
