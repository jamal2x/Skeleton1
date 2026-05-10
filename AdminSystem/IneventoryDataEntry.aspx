<%@ Page Language="C#" AutoEventWireup="true" CodeFile="IneventoryDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <asp:Label ID="lblPartID" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Part ID" width="103px"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 142px; top: 16px; position: absolute"></asp:TextBox>
        </div>
        <asp:Label ID="lblPartName" runat="server" style="z-index: 1; left: 9px; top: 58px; position: absolute" Text="Part Name"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 9px; top: 146px; position: absolute" Text="Price" width="103px"></asp:Label>
        <p>
            <asp:Label ID="lblInStock" runat="server" style="z-index: 1; left: 10px; top: 187px; position: absolute" Text="In Stock " width="103px"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 142px; top: 58px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 146px; top: 105px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblPaid" runat="server" style="z-index: 1; left: 13px; top: 231px; position: absolute; width: 103px" Text="Paid"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 142px; top: 188px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 137px; top: 237px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox6" runat="server" style="z-index: 1; left: 142px; top: 144px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 54px; top: 353px; position: absolute" Text="OK" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 15px; top: 298px; position: absolute"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 135px; top: 354px; position: absolute" Text="Cancel" />
        <p>
            <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 10px; top: 107px; position: absolute; height: 30px" Text="Quantity" width="103px"></asp:Label>
        </p>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 156px; top: 286px; position: absolute; height: 26px; width: 115px" Text="Active" />
    </form>

        <div>
        </div>
    </form>
</body>
</html>
