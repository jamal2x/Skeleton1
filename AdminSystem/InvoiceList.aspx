<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InvoiceList.aspx.cs" Inherits="InvoiceList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:ListBox ID="ListBox1" runat="server" style="z-index: 1; left: 19px; top: 21px; position: absolute; height: 498px; width: 556px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
    
            </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 16px; top: 546px; position: absolute; height: 37px; width: 65px; right: 1036px;" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 125px; top: 546px; position: absolute" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 215px; top: 546px; position: absolute" Text="Delete" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 625px; top: 482px; position: absolute"></asp:Label>
        <asp:Label ID="Label1" runat="server" Font-Bold="False" style="z-index: 1; left: 35px; top: 620px; position: absolute" Text="Enter a Vehicle ID"></asp:Label>
        <asp:TextBox ID="txtVehicleID" runat="server" style="z-index: 1; left: 235px; top: 614px; position: absolute; height: 28px; width: 205px; right: 631px"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 40px; top: 677px; position: absolute" Text="Apply Filter" OnClick="Button1_Click1" />
        <asp:Button ID="btnClear" runat="server" style="z-index: 1; left: 209px; top: 680px; position: absolute" Text="Clear Filter" />
        <asp:Button ID="Button3" runat="server" style="z-index: 1; left: 393px; top: 679px; position: absolute" Text="Statistics Page" />
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" style="z-index: 1; left: 657px; top: 679px; position: absolute; width: 204px" Text="Return to Main Menu" />
        </p>
    </form>
</body>
</html>
