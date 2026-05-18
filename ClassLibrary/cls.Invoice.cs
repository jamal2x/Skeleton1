using System;
using System.IO;



namespace ClassLibrary

{

    public class clsInvoice

    {

        //private data members

        private Int32 mServiceID;

        private Int32 mVehicleID;

        private double mLabourCosts;

        private double mPartCosts;

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



        //LabourCosts property

        public double LabourCost

        {

            get

            {

                return mLabourCosts;

            }

            set

            {

                mLabourCosts = value;

            }

        }



        //PartCosts property

        public double PartCosts

        {

            get

            {

                return mPartCosts;

            }

            set

            {

                mPartCosts = value;

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
        public string PartCost { get; set; }

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


            decimal partCost;

            if (!decimal.TryParse(partCost, out partCost))
            {
                Error += "Part costs must be numeric : ";
            }
            else
            {
                if (partCost < 0)
                    Error += "Part costs cannot be negative : ";

                if (partCost > 5000)
                    Error += "Part costs too high : ";
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

  


    }
}