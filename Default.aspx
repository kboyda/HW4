<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Net Pay Estimator</title>
    <link rel="stylesheet" type="text/css" href="style.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="main">
    
        <h1 id="header"> Net Pay Estimator </h1>
        Wage (Hourly):<br />
        <asp:TextBox ID="tbWage" runat="server"></asp:TextBox>
        <br />
        <br />
        Hours Worked:<br />
        <asp:TextBox ID="tbHours" runat="server"></asp:TextBox>
        <br />
        <br />
        Pre-Tax Deductions:<br />
        <asp:TextBox ID="tbPreTax" runat="server"></asp:TextBox>
        <br />
        <br />
        After Tax Deductions:<br />
        <asp:TextBox ID="tbAfterTax" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lbNetPay" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnCalculate" runat="server" Text="Calculate" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnClear" runat="server" Text="Clear" />
    
    </div>
    </form>
</body>
</html>
