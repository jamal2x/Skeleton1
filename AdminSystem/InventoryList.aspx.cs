using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InventoryList : System.Web.UI.Page
{
    private static List<clsInventory> DataSource;
    private static string DataValueField;
    private static string DataTextField;
    private static int SelectedIndex;
    private static object SelectedValue;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayInventory();
        }
    }

    void DisplayInventory()
    {
        clsInventoryCollection Inventory = new clsInventoryCollection();

        InventoryList.DataSource = Inventory.InventoryList;

        InventoryList.DataValueField = "PartID";

        InventoryList.DataTextField = "PartName";

        InventoryList.DataBind();
    }

    protected void lstInventoryList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["PartID"] = -1;
        Response.Redirect("InventoryDataEntry.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        int PartID;

        if (InventoryList.SelectedIndex != -1)
        {
            PartID = Convert.ToInt32(InventoryList.SelectedValue);

            Session["PartID"] = PartID;

            Response.Redirect("InventoryConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select an inventory item to delete from the list";
        }
    }
}