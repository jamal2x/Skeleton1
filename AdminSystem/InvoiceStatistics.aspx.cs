using ClassLibrary;

using System;

using System.Data;

using System.Web.UI;



public partial class InvoiceStatistics : System.Web.UI.Page

{

    protected void Page_Load(object sender, EventArgs e)

    {

        clsInvoice clsinvoice = new clsInvoice();



        // retrieve data from database

        DataTable dT = clsinvoice.StatisticsGroupedByPaid();



        // load first GridView

        GridViewStGroupByPaid.DataSource = dT;

        GridViewStGroupByPaid.DataBind();



        // change header of first column

        GridViewStGroupByPaid.HeaderRow.Cells[0].Text = "Paid Status";







        // retrieve second statistics data

        dT = clsinvoice.StatisticsGroupedByServiceID();



        // load second GridView

        GridViewStGroupByServiceID.DataSource = dT;

        GridViewStGroupByServiceID.DataBind();



        // change header of first column

        GridViewStGroupByServiceID.HeaderRow.Cells[0].Text = "Service ID";

    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("InvoiceList.aspx");
    }

}