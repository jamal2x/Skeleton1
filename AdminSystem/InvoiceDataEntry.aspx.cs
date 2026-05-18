using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    private decimal labourCosts;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    
protected void btnOK_Click(object sender, EventArgs e)
    {
        clsInvoice AnInvoice = new clsInvoice();

  int serviceID;

        if (!int.TryParse(txtServiceID.Text, out serviceID))
        {
            Response.Write("Service ID must be a number");
            return;
        }

        AnInvoice.ServiceID = serviceID;
        int vehicleID;

        if (!int.TryParse(txtVehicleID.Text, out vehicleID))
        {
            Response.Write("Vehicle ID must be a number");
            return;
        }

        AnInvoice.VehicleID = vehicleID;

        if (!decimal.TryParse(txtLabourCosts.Text, out labourCosts))
        {
            Response.Write("Labour Costs must be a number");
            return;
        }
        AnInvoice.LabourCost = (double)labourCosts;

        AnInvoice.PartCosts = (double)Convert.ToDecimal(txtPartCosts.Text);

   

        AnInvoice.TotalAmount = AnInvoice.LabourCost + AnInvoice.PartCosts;

        txtTotalAmount.Text = AnInvoice.TotalAmount.ToString();

        AnInvoice.Paid = chkPaid.Checked;

        Session["AnInvoice"] = AnInvoice;

        Response.Redirect("InvoiceViewer.aspx");
    }
}
