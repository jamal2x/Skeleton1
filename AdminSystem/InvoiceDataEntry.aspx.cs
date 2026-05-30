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

    public object txtPaid { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsInvoice AnInvoice = new clsInvoice();
        clsInvoiceCollection InvoiceBook = new clsInvoiceCollection();

      
        string ServiceID = txtServiceID.Text;
        string VehicleID = txtVehicleID.Text;
        string LabourCost = txtLabourCost.Text;
        string PartCost = txtPartCost.Text;
        string TotalAmount = txtTotalAmount.Text;
        string Paid = chkPaid.Text;
        string InvoiceDate = txtInvoiceDate.Text;
        int serviceID;

        string Error = "";

        Error = AnInvoice.Valid(ServiceID,
                          VehicleID,
                          LabourCost,
                          PartCost,
                          TotalAmount,
                          Paid,
                          InvoiceDate);
       


        if (Error == "")
        {

            lblError.Text = "Data is valid";
        }
        else
        {
            lblError.Text = Error;
        }
    

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

        if (!decimal.TryParse(txtLabourCost.Text, out labourCosts))
        {
            Response.Write("Labour Costs must be a number");
            return;
        }
        AnInvoice.LabourCost = (double)labourCosts;

        AnInvoice.PartCost = (double)Convert.ToDecimal(txtPartCost.Text);

   

        AnInvoice.TotalAmount = AnInvoice.LabourCost + AnInvoice.PartCost;

        txtTotalAmount.Text = AnInvoice.TotalAmount.ToString();

        AnInvoice.Paid = chkPaid.Checked;

        Session["AnInvoice"] = AnInvoice;

        Response.Redirect("InvoiceList.aspx");


        InvoiceBook.ThisInvoice = AnInvoice;

        if (Convert.ToInt32(Session["InvoiceNo"]) == -1)
        {
            InvoiceBook.Add();
        }
        else
        {
            AnInvoice.InvoiceNo = Convert.ToInt32(Session["InvoiceNo"]);
            InvoiceBook.ThisInvoice = AnInvoice;
            InvoiceBook.Update();
        }
    }
    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("InvoiceList.aspx");
    }
}
