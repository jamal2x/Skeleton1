using System;
using System.Web.UI;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    decimal price;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsInventory AnInventory = new clsInventory();
        clsInventoryCollection InventoryBook = new clsInventoryCollection();

        string PartID = txtPartID.Text;
        string PartName = txtPartName.Text;
        string Category = txtCategory.Text;
        string Quantity = txtQuantity.Text;
        string InStock = chkInStock.Text;
        string Price = txtPrice.Text;

        int partID;
        int quantity;

        string Error = "";

        Error = AnInventory.Valid(
                    PartID,
                    PartName,
                    Category,
                    Quantity,
                    InStock,
                    Price);

        if (Error == "")
        {
            lblError.Text = "Data is valid";
        }
        else
        {
            lblError.Text = Error;
            return;
        }

        // Part ID validation
        if (!int.TryParse(txtPartID.Text, out partID))
        {
            Response.Write("Part ID must be a number");
            return;
        }

        AnInventory.PartID = partID;

        // Quantity validation
        if (!int.TryParse(txtQuantity.Text, out quantity))
        {
            Response.Write("Quantity must be a number");
            return;
        }

        AnInventory.Quantity = quantity;

        // Price validation
        if (!decimal.TryParse(txtPrice.Text, out price))
        {
            Response.Write("Price must be a number");
            return;
        }

        AnInventory.Price = price;

        // Other fields
        AnInventory.PartName = txtPartName.Text;
        AnInventory.Category = txtCategory.Text;
        AnInventory.InStock = chkInStock.Checked;

        Session["AnInventory"] = AnInventory;

        InventoryBook.ThisInventory = AnInventory;

        if (Convert.ToInt32(Session["PartID"]) == -1)
        {
            InventoryBook.Add();
        }
        else
        {
            AnInventory.PartID = Convert.ToInt32(Session["PartID"]);

            InventoryBook.ThisInventory = AnInventory;

            InventoryBook.Update();
        }

        Response.Redirect("InventoryList.aspx");
    }
}