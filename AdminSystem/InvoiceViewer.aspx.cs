using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class InvoiceViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // create instance of clsInvoice
        clsInvoice AnInvoice = new clsInvoice();

        // retrieve object from session
        AnInvoice = (clsInvoice)Session["AnInvoice"];

        // display values
        Response.Write("Service ID: " + AnInvoice.ServiceID + "<br>");

        Response.Write("Vehicle ID: " + AnInvoice.VehicleID + "<br>");

        Response.Write("Labour Costs: " + AnInvoice.LabourCost + "<br>");

        Response.Write("Parts Cost: " + AnInvoice.PartCost + "<br>");

        Response.Write("Total Amount: " + AnInvoice.TotalAmount + "<br>");

        Response.Write("Invoice Date: " + AnInvoice.InvoiceDate + "<br>");

        Response.Write("Paid: " + AnInvoice.Paid);
    }
}