using System;
using System.Collections.Generic;
using System.Data;
using System.IO;



namespace ClassLibrary

{

    public class clsInvoice

    {

        //private data members

        private Int32 mServiceID;

        private Int32 mVehicleID;

        private double mLabourCost;

        private double mPartCost;

        private double mTotalAmount;

        private Boolean mPaid;

        private DateTime mInvoiceDate;



        //ServiceID property

        public int ServiceID

        {

            get

            {

                return mServiceID;

            }

            set

            {

                mServiceID = value;

            }

        }



        //VehicleID property

        public int VehicleID

        {

            get

            {

                return mVehicleID;

            }

            set

            {

                mVehicleID = value;

            }

        }



        //LabourCost property

        public double LabourCost

        {

            get

            {

                return mLabourCost;

            }

            set

            {

                mLabourCost = value;

            }

        }



        //PartCosts property

        public double PartCost

        {

            get

            {

                return mPartCost;

            }

            set

            {

                mPartCost = value;

            }

        }



        //TotalAmount property

        public double TotalAmount

        {

            get

            {

                return mTotalAmount;

            }

            set

            {

                mTotalAmount = value;

            }

        }



        //Paid property

        public bool Paid

        {

            get

            {

                return mPaid;

            }

            set

            {

                mPaid = value;

            }

        }



        //InvoiceDate property

        public DateTime InvoiceDate

        {

            get

            {

                return mInvoiceDate;

            }

            set

            {

                mInvoiceDate = value;

            }

        }

        public string Error { get; private set; }
        public int Count { get; set; }
        public int InvoiceNo { get; set; }
        public int InvoiceID { get; set; }

        public void Add(clsInvoice testItem)
        {
            throw new NotImplementedException();
        }

        public bool Find(int primaryKey)
        {
            throw new NotImplementedException();
        }

        public string Valid(string serviceID,
                     string vehicleID,
                     string labourCost,
                     string partCost,
                     string totalAmount,
                     string paid,
                     string invoiceDate)
        {
            String Error = "";

            //if ServiceID is blank
            if (serviceID.Length == 0)
            {
                Error = Error + "The service ID can not be blank : ";
            }

            //if ServiceID is too long
            if (serviceID.Length > 10)
            {
                Error = Error + "Service ID too long : ";
            }

            if (vehicleID.Length > 10)
            {
                Error = Error + "Vehicle ID too long : ";
            }


            if (vehicleID.Length == 0)
            {
                Error = Error + "Vehicle ID cant not be blank : ";
            }

            if (paid != "true" && paid != "false")
            {
                Error += "Paid must be true or false : ";
            }

            DateTime DateTemp;

            try
            {
                DateTemp = Convert.ToDateTime(invoiceDate);

                if (DateTemp < DateTime.Now.Date.AddYears(-10))
                    Error += "Invoice date too old : ";

                if (DateTemp > DateTime.Now.Date)
                    Error += "Invoice date cannot be in future : ";
            }
            catch
            {
                Error += "Invoice date invalid : ";
            }

            decimal total;

            if (!decimal.TryParse(totalAmount, out total))
            {
                Error += "Total amount must be numeric : ";
            }
            else
            {
                if (total <= 0)
                    Error += "Total must be greater than 0 : ";

                if (total > 10000)
                    Error += "Total too large : ";
            }


            decimal labour;

            if (!decimal.TryParse(labourCost, out labour))
            {
                Error += "Labour costs must be numeric : ";
            }
            else
            {
                if (labour < 0)
                    Error += "Labour costs cannot be negative : ";

                if (labour > 5000)
                    Error += "Labour costs too high : ";
            }

            return Error;
        }

        public static implicit operator List<object>(clsInvoice v)
        {
            throw new NotImplementedException();
        }
    

    public DataTable StatisticsGroupedByPaid()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblInvoice_Count_GroupByPaid");

            return DB.DataTable;
        }

        public DataTable StatisticsGroupedByServiceID()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblInvoice_Count_GroupByServiceID");

            return DB.DataTable;
        }

    }
    }