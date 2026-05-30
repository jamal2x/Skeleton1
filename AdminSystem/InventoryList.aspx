<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InventoryList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<script runat="server">

    protected void btnAdd_Click(object sender, EventArgs e)
    {

    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="ListBox1" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 513px; width: 558px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 31px; top: 559px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 162px; top: 558px; position: absolute; right: 867px" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" 
            style="z-index: 1; left: 282px; top: 559px; position: absolute" Text="Delete" />
    </form>
    </body>
</html>


