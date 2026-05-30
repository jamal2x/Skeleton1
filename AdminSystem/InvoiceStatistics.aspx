<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InvoiceStatistics.aspx.cs" Inherits="InvoiceStatistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

        </div>
        <asp:GridView ID="GridViewStGroupByServiceID" runat="server" style="z-index: 1; left: 619px; top: 429px; position: absolute; height: 180px; width: 289px" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <asp:GridView ID="GridViewStGroupByPaid" runat="server" style="z-index: 1; left: 617px; top: 141px; position: absolute; height: 180px; width: 289px" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <p>
            <asp:Label ID="lblStatistics" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 656px; top: 36px; position: absolute; height: 32px; width: 283px; bottom: 864px" Text="Statistics Page"></asp:Label>
        </p>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" style="z-index: 1; left: 611px; top: 95px; position: absolute" Text="Invoice List - Grouped by Paid"></asp:Label>
        <asp:Label ID="Label2" runat="server" Font-Bold="True" style="z-index: 1; left: 599px; top: 372px; position: absolute" Text="Invoice List - Grouped by Service ID"></asp:Label>
        <asp:Button ID="btnBack" runat="server" BorderStyle="Outset" style="z-index: 1; left: 623px; top: 676px; position: absolute; height: 35px" Text="Back to Previous Page" />
    </form>
</body>
</html>
