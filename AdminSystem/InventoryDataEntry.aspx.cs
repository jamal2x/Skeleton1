using System;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsInventory AnItem = new clsInventory();

        int partID;
        int quantity;
        double price;

        int.TryParse(txtPartID.Text, out partID);
        int.TryParse(txtQuantity.Text, out quantity);
        double.TryParse(txtPrice.Text, out price);

        AnItem.PartID = partID;
        AnItem.PartName = txtPartName.Text;
        AnItem.Category = ddlCategory.SelectedItem.Text;
        AnItem.Quantity = quantity;
        AnItem.Price = price;
        AnItem.InStock = chkInStock.Checked;

        Session["AnItem"] = AnItem;
        clsInventory AnInventory = new clsInventory();

        AnInventory.Quantity = Convert.ToInt32(txtQuantity.Text);

        AnInventory.Price = Convert.ToDouble(txtPrice.Text);

        AnInventory.CalculateTotal();

        txtPrice.Text = AnInventory.Price.ToString("C");


        Response.Redirect("InventoryViewer.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        // clear all fields
        txtPartID.Text = "";
        txtPartName.Text = "";
        txtQuantity.Text = "";
        txtPrice.Text = "";

        chkInStock.Checked = false;

        ddlCategory.SelectedIndex = 0;
    }
}