using System;

using System.Collections.Generic;



namespace ClassLibrary

{

    public class clsInvoiceCollection

    {

        private List<clsInvoice> mInvoiceList = new List<clsInvoice>();

        private clsInvoice mThisInvoice;



        public clsInvoiceCollection()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblInvoice_SelectAll");

            PopulateArray(DB);
        }


        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ServiceID", ThisInvoice.ServiceID);
            DB.AddParameter("@VehicleID", ThisInvoice.VehicleID);
            DB.AddParameter("@PartCost", ThisInvoice.PartCost);
            DB.AddParameter("@LabourCost", ThisInvoice.LabourCost);
            DB.AddParameter("@TotalAmount", ThisInvoice.TotalAmount);
            DB.AddParameter("@Paid", ThisInvoice.Paid);

            return DB.Execute("sproc_tblInvoice_Insert");
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Delete()

        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@InvoiceID", mThisInvoice.InvoiceID);
            DB.Execute("sproc_tblInvoice_Delete");

        }

        public List<clsInvoice> InvoiceList

        {

            get { return mInvoiceList; }

            set { mInvoiceList = value; }

        }



        public int Count

        {

            get { return mInvoiceList.Count; }
            set { }

        }



        public clsInvoice ThisAddress
        {
            get
            {
                return mThisInvoice;
            }
            set
            {
                mThisInvoice = value;
            }
        }

        public clsInvoice ThisInvoice { get; set; }
    


    public void ReportByVehicleID(string VehicleID)
        {

        }


        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = DB.Count;

            mInvoiceList = new List<clsInvoice>();

            while (Index < RecordCount)
            {
                clsInvoice AnInvoice = new clsInvoice();

                AnInvoice.InvoiceID = Convert.ToInt32(DB.DataTable.Rows[Index]["InvoiceID"]);
                AnInvoice.ServiceID = Convert.ToInt32(DB.DataTable.Rows[Index]["ServiceID"]);
                AnInvoice.VehicleID = Convert.ToInt32(DB.DataTable.Rows[Index]["VehicleID"]);
                AnInvoice.PartCost = (double)Convert.ToDecimal(DB.DataTable.Rows[Index]["PartCost"]);
                AnInvoice.LabourCost = (double)Convert.ToDecimal(DB.DataTable.Rows[Index]["LabourCost"]);
                AnInvoice.TotalAmount = (double)Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalAmount"]);
                AnInvoice.Paid = Convert.ToBoolean(DB.DataTable.Rows[Index]["Paid"]);

                mInvoiceList.Add(AnInvoice);

                Index++;
            }
        }
       public void ReportByVehicleID(int VehicleID)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@VehicleID", VehicleID);

            DB.Execute("sproc_tblInvoice_FilterByVehicleID");

            PopulateArray(DB);
        }
    }

        }


    
    



