<%@ Page Language="C#" AutoEventWireup="true"

CodeFile="InventoryDataEntry.aspx.cs"

Inherits="_1_DataEntry" %>



<!DOCTYPE html>



<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <title>Inventory Data Entry</title>

</head>



<body>

<form id="form1" runat="server">



    <asp:Panel ID="pnlInventory" runat="server">



        <table>



            <tr>

                <td>Part ID:</td>

                <td>

                    <asp:TextBox ID="txtPartID" runat="server" />

                </td>

            </tr>



            <tr>

                <td>Part Name:</td>

                <td>

                    <asp:TextBox ID="txtPartName" runat="server" />

                </td>

            </tr>



            <tr>

                <td>Category:</td>

                <td>

                    <asp:DropDownList ID="ddlCategory" runat="server">

                        <asp:ListItem>Engine</asp:ListItem>

                        <asp:ListItem>Brakes</asp:ListItem>

                        <asp:ListItem>Electrical</asp:ListItem>

                        <asp:ListItem>Suspension</asp:ListItem>

                    </asp:DropDownList>

                </td>

            </tr>



            <tr>

                <td>Quantity:</td>

                <td>

                    <asp:TextBox ID="txtQuantity" runat="server" />

                </td>

            </tr>



            <tr>

                <td>Price:</td>

                <td>

                    <asp:TextBox ID="txtPrice" runat="server" />

                </td>

            </tr>



            <tr>

                <td>In Stock:</td>

                <td>

                    <asp:CheckBox ID="chkInStock" runat="server" />

                </td>

            </tr>



            <tr>

                <td>
                    <asp:Label ID="lblCheck" runat="server" style="z-index: 1; left: 10px; top: 258px; position: absolute"></asp:Label>
                </td>

                <td>



                    <asp:Button ID="btnOK"

                        runat="server"

                        Text="OK"

                        OnClick="btnOK_Click" style="height: 35px" />



                    &nbsp;&nbsp;&nbsp;&nbsp;



                    <asp:Button ID="btnCancel"

                        runat="server"

                        Text="Cancel"

                        OnClick="btnCancel_Click" />



                </td>

            </tr>



        </table>



    </asp:Panel>



</form>

</body>

</html>

