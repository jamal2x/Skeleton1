using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InvoiceList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayInvoices();
        }

        void DisplayInvoices()
        {
            clsInvoiceCollection Invoices = new clsInvoiceCollection();

            lstInvoiceList.DataSource = Invoices.InvoiceList;

            lstInvoiceList.DataValueField = "InvoiceID";

            lstInvoiceList.DataTextField = "ServiceID";

            lstInvoiceList.DataBind();
        }
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["InvoiceNo"] = -1;
        Response.Redirect("InvoiceDataEntry.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 InvoiceID;
        if (lstInvoiceList.SelectedIndex != -1)
        {
            InvoiceID = Convert.ToInt32(lstInvoiceList.SelectedIndex);
            Session["InvoiceID"] = InvoiceID;
            Response.Redirect("InvoiceConfirmDelete.aspx");

        }
        else
        {
            lblError.Text = "Please select an invoice to delete from the list";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsInvoiceCollection Invoice = new clsInvoiceCollection();

        Invoice.ReportByVehicleID(txtVehicleID.Text);

        lstInvoiceList.DataSource = Invoice.InvoiceList;
        lstInvoiceList.DataValueField = "InvoiceNo";
        lstInvoiceList.DataTextField = "VehicleID";
        lstInvoiceList.DataBind();
    }



    protected void btnClear_Click(object sender, EventArgs e)
    {
        txtVehicleID.Text = "";

        clsInvoiceCollection Invoice = new clsInvoiceCollection();

        lstInvoiceList.DataSource = Invoice.InvoiceList;
        lstInvoiceList.DataValueField = "InvoiceID";
        lstInvoiceList.DataBind();
    }



    class lstInvoiceList
    {
        public static List<clsInvoice> DataSource { get; internal set; }
        public static string DataValueField { get; internal set; }
        public static string DataTextField { get; internal set; }
        public static int SelectedIndex { get; internal set; }

        internal static void DataBind()
        {
            throw new NotImplementedException();
        }
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}