using System;

using ClassLibrary;



public partial class InventoryViewer : System.Web.UI.Page

{

    protected void Page_Load(object sender, EventArgs e)
    {
        clsInventory AnItem = new clsInventory();

        AnItem = (clsInventory)Session["AnItem"];

        if (AnItem.PartName != "")
        {
            Response.Write("Part Name: " + AnItem.PartName + "<br />");
        }

        if (AnItem.PartID != 0)
        {
            Response.Write("Part ID: " + AnItem.PartID + "<br />");
        }

        if (AnItem.Quantity != 0)
        {
            Response.Write("Quantity: " + AnItem.Quantity + "<br />");
        }

        if (AnItem.Price != 0)
        { 
            Response.Write("Price: " + AnItem.Price + "<br />");
        }

        if (AnItem.InStock == true)
        {
            Response.Write("In Stock: In Stock<br>");
        }
        else
        {
            Response.Write("In Stock: Not in Stock<br>");
        }

        Response.Write("Category: " + AnItem.Category + "<br>");
    }
}
    