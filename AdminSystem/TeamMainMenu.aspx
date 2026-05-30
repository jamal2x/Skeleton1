<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblMainMenu" runat="server" style="z-index: 1; left: 316px; top: 29px; position: absolute; width: 336px; height: 36px" Text="Car Garage Manager Main Menu"></asp:Label>
        </div>
        <asp:Button ID="btnCustomer" runat="server" style="z-index: 1; left: 36px; top: 99px; position: absolute; width: 218px" Text="Customer Management" />
        <asp:Button ID="btnVehicle" runat="server" style="z-index: 1; left: 763px; top: 98px; position: absolute; width: 217px" Text="Vehicle Management" />
        <asp:Button ID="btnService" runat="server" style="z-index: 1; top: 100px; position: absolute; left: 526px; width: 182px" Text="Service &amp; Repair" />
        <asp:Button ID="btnInvoice" runat="server" OnClick="btnInvoice_Click" style="z-index: 1; left: 282px; top: 100px; position: absolute; width: 199px" Text="Invoice &amp; Inventory" />
    </form>
</body>
</html>
