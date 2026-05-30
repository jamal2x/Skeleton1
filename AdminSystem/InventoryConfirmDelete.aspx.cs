using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InventoryConfirmDelte : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsInventoryCollection Inventory = new clsInventoryCollection();
        Inventory.ThisInventory.Find(InventoryID);
        Inventory.Delete();
        Response.Redirect("InventoryList.aspx")
    }
}