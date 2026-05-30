using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class InvoiceConfirmDelete : System.Web.UI.Page
{
    public int InvoiceID { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        InvoiceID = Convert.ToInt32(Session["InvoiceID"]);



    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsInvoiceCollection Invoice = new clsInvoiceCollection();
        Invoice.ThisInvoice.Find(InvoiceID);
        Invoice.Delete();
        Response.Redirect("InvoiceList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("InvoiceList.aspx");

    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}