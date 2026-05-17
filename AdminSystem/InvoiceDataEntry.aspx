<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InvoiceDataEntry.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblServiceID" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; width: 124px" Text="Service ID"></asp:Label>
            <asp:TextBox ID="txtServiceID" runat="server" style="z-index: 1; left: 167px; top: 13px; position: absolute; bottom: 890px" width="188px" height="29px"></asp:TextBox>
        </div>
        <asp:Label ID="lblVehicleID" runat="server" style="z-index: 1; left: 5px; top: 57px; position: absolute" Text="Vehicle ID" width="124px"></asp:Label>
        <asp:Label ID="lblLabourCosts" runat="server" style="z-index: 1; left: 9px; top: 96px; position: absolute; width: 143px" Text="Labour Costs"></asp:Label>
        <p>
            <asp:TextBox ID="txtVehicleID" runat="server" style="z-index: 1; left: 167px; top: 54px; position: absolute" width="188px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblPartCosts" runat="server" style="z-index: 1; left: 11px; top: 142px; position: absolute" Text="Part Costs" width="124px"></asp:Label>
            <asp:TextBox ID="txtLabourCosts" runat="server" style="z-index: 1; left: 167px; top: 97px; position: absolute" width="188px" height="29px" TextMode="Number"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblTotalAmount" runat="server" style="z-index: 1; left: 10px; top: 189px; position: absolute; bottom: 716px; width: 134px; right: 973px" Text="Total Amount"></asp:Label>
        </p>
        <asp:Label ID="lblInvoiceDate" runat="server" style="z-index: 1; left: 10px; top: 233px; position: absolute; width: 124px; height: 30px" Text="Invoice Date"></asp:Label>
        <asp:TextBox ID="txtPartCosts" runat="server"  style="z-index: 1; left: 167px; top: 142px; position: absolute" width="188px" height="29px" TextMode="Number"></asp:TextBox>
        <asp:TextBox ID="txtTotalAmount" runat="server" style="z-index: 1; left: 171px; top: 187px; position: absolute" height="29px" TextMode="Number"></asp:TextBox>
        <asp:TextBox ID="txtInvoiceDate" runat="server" style="z-index: 1; left: 167px; top: 230px; position: absolute" width="188px" height="29px" TextMode="Date"></asp:TextBox>
        <asp:CheckBox ID="chkPaid" runat="server" style="z-index: 1; left: 182px; top: 324px; position: absolute; height: 24px; width: 99px" Text="Paid" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 347px; position: absolute; height: 15px"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 67px; top: 394px; position: absolute; width: 62px" Text="OK" />
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; top: 390px; position: absolute; left: 160px; width: 83px" Text="Cancel" />
    </form>
</body>
</html>
