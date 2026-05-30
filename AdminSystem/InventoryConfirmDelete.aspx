<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InventoryConfirmDelete.aspx.cs" Inherits="InventoryConfirmDelte" %>

<!DOCTYPE html>
<script runat="server">

  
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 76px; top: 55px; position: absolute" Text="Are you sure you want to cancel this inventory?"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 345px; top: 123px; position: absolute; height: 34px; width: 53px" Text="No" />
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 154px; top: 122px; position: absolute" Text="Yes" />
    </form>
</body>
</html>
