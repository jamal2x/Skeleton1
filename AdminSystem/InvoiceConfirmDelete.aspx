<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InvoiceConfirmDelete.aspx.cs" Inherits="InvoiceConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        
        <p>
            &nbsp;</p>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 79px; top: 78px; position: absolute" Text="Are you sure you want to cancel this invoice?"></asp:Label>
        <p>
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 322px; top: 139px; position: absolute; height: 31px; width: 89px" Text="No" />
        </p>
        <p>
            <asp:Button ID="btnYes" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 125px; top: 140px; position: absolute; height: 31px; width: 83px" Text="Yes" />
        </p>
        
    </form>
</body>
</html>
