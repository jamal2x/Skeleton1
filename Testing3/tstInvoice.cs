using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3


{
    [TestClass]
    public class tstInvoice
    { //good test data
        string LabourCost = "50";
        string PartCost = "100";
        string ServiceID = "1";
        string VehicleID = "2";
        string TotalAmount = "150";
        string InvoiceDate = DateTime.Now.Date.ToString();


        [TestMethod]
        public void ValidMethodOK()
        {
            clsInvoice AnInvoice = new clsInvoice();

            string Error = "";

            Error = AnInvoice.Valid
            (
                LabourCost,
                PartCost,
                ServiceID,
                VehicleID,
                TotalAmount,
                InvoiceDate
            );

            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void InvoiceDatePropertyOK()
        {
            clsInvoice AnInvoice = new clsInvoice();
            DateTime TestData = DateTime.Now.Date;
            AnInvoice.InvoiceDate = TestData;
            Assert.AreEqual(AnInvoice.InvoiceDate, TestData);
        }

        [TestMethod]
        public void PartsCostPropertyOK()
        {
            clsInvoice AnInvoice = new clsInvoice();
            decimal TestData = 60.00m;
            AnInvoice.PartsCost = TestData;
            Assert.AreEqual(AnInvoice.PartsCost, TestData);
        }

        [TestMethod]
        public void LabourCostPropertyOK()
        {
            clsInvoice AnInvoice = new clsInvoice();
            decimal TestData = 30.00m;
            AnInvoice.LabourCost = TestData;
            Assert.AreEqual(AnInvoice.LabourCost, TestData);
        }

        [TestMethod]
        public void VehicleIDPropertyOK()
        {
            clsInvoice AnInvoice = new clsInvoice();
            int TestData = 1;
            AnInvoice.VehicleID = TestData;
            Assert.AreEqual(AnInvoice.VehicleID, TestData);
        }

        [TestMethod]
        public void ServiceIDPropertyOK()
        {
            clsInvoice AnInvoice = new clsInvoice();
            int TestData = 1;
            AnInvoice.ServiceID = TestData;
            Assert.AreEqual(AnInvoice.ServiceID, TestData);
        }


    }
    public class clsInvoice
    {
        public DateTime InvoiceDate { get; set; }
        public decimal TotalAmount { get; set; }
 
        public int VehicleID { get; set; }
        public int ServiceID { get; set; }
        public object PartCost { get; private set; }
       
        public object Paid { get; private set; }
        public decimal PartsCosts { get; internal set; }
        public object LabourCost { get; set; }
        public decimal PartsCost { get; internal set; }
        public int Count { get; internal set; }

        [TestMethod]
        public void ServiceIDMinLessOne()
        {
            clsInvoice AnInvoice = new clsInvoice();

            String Error = "";

            string ServiceID = "2";

            Error = AnInvoice.Valid(ServiceID,
                                    VehicleID,
                                    LabourCost,
                                    PartCost,
                                    TotalAmount,
                                    Paid,
                                    InvoiceDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ServiceIDMaxPlusOne()
        {
            clsInvoice AnInvoice = new clsInvoice();

            String Error = "";

            string ServiceID = "14565";

            Error = AnInvoice.Valid(ServiceID,
                                    VehicleID,
                                    LabourCost,
                                    PartCost,
                                    TotalAmount,
                                    Paid,
                                    InvoiceDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VehicleIDMaxPlusOne()
        {
            clsInvoice AnInvoice = new clsInvoice();

            String Error = "";

            string ServiceID = "14565";

            Error = AnInvoice.Valid(ServiceID,
                                    VehicleID,
                                    LabourCost,
                                    PartCost,
                                    TotalAmount,
                                    Paid,
                                    InvoiceDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VehicleIDMinLessOne()
        {
            clsInvoice AnInvoice = new clsInvoice();

            String Error = "";

            string ServiceID = "2";

            Error = AnInvoice.Valid(ServiceID,
                                    VehicleID,
                                    LabourCost,
                                    PartCost,
                                    TotalAmount,
                                    Paid,
                                    InvoiceDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PaidMin()
        {
            clsInvoice AnInvoice = new clsInvoice();

            String Error = "";

            string Paid = "false";

            Error = AnInvoice.Valid(ServiceID,
                                    VehicleID,
                                    LabourCost,
                                    PartCost,
                                    TotalAmount,
                                    Paid,
                                    InvoiceDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PaidMax()
        {
            clsInvoice AnInvoice = new clsInvoice();

            String Error = "";

            string Paid = "true";

            Error = AnInvoice.Valid(ServiceID,
                                    VehicleID,
                                    LabourCost,
                                    PartCost,
                                    TotalAmount,
                                    Paid,
                                    InvoiceDate);

            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void InvoiceDateMin()
        {
            clsInvoice AnInvoice = new clsInvoice();

            String Error = "";

            DateTime TestDate = DateTime.Now.Date.AddYears(-10);
            string InvoiceDate = TestDate.ToString();

            Error = AnInvoice.Valid(ServiceID,
                                    VehicleID,
                                    LabourCost,
                                    PartCost,
                                    TotalAmount,
                                    Paid,
                                    InvoiceDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void InvoiceDateMid()
        {
            clsInvoice AnInvoice = new clsInvoice();

            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            string InvoiceDate = TestDate.ToString();

            Error = AnInvoice.Valid(ServiceID,
                                    VehicleID,
                                    LabourCost,
                                    PartCost,
                                    TotalAmount,
                                    Paid,
                                    InvoiceDate);

            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void InvoiceDateMax()
        {
            clsInvoice AnInvoice = new clsInvoice();

            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            string InvoiceDate = TestDate.ToString();

            Error = AnInvoice.Valid(ServiceID,
                                    VehicleID,
                                    LabourCost,
                                    PartCost,
                                    TotalAmount,
                                    Paid,
                                    InvoiceDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountMin()
        {
            clsInvoice AnInvoice = new clsInvoice();

            String Error = "";

            string TotalAmount = "0.01";

            Error = AnInvoice.Valid(ServiceID,
                                    VehicleID,
                                    LabourCost,
                                    PartCost,
                                    TotalAmount,
                                    Paid,
                                    InvoiceDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountMid()
        {
            clsInvoice AnInvoice = new clsInvoice();

            String Error = "";
            string TotalAmount = "250.00";

            Error = AnInvoice.Valid(ServiceID,
                                    VehicleID,
                                    LabourCost,
                                    PartCost,
                                    TotalAmount,
                                    Paid,
                                    InvoiceDate);

            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void TotalAmountMax()
        {
            clsInvoice AnInvoice = new clsInvoice();

            String Error = "";
            string TotalAmount = "10000.00";

            Error = AnInvoice.Valid(ServiceID,
                                    VehicleID,
                                    LabourCost,
                                    PartCost,
                                    TotalAmount,
                                    Paid,
                                    InvoiceDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PartCostMin()
        {
            clsInvoice AnInvoice = new clsInvoice();

            String Error = "";

            string TotalAmount = "0.01";

            Error = AnInvoice.Valid(ServiceID,
                                    VehicleID,
                                    LabourCost,
                                    PartCost,
                                    TotalAmount,
                                    Paid,
                                    InvoiceDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PartCostMid()
        {
            clsInvoice AnInvoice = new clsInvoice();

            String Error = "";
            string PartCost = "250.00";

            Error = AnInvoice.Valid(ServiceID,
                                    VehicleID,
                                    LabourCost,
                                    PartCost,
                                    TotalAmount,
                                    Paid,
                                    InvoiceDate);

            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void PartCostMax()
        {
            clsInvoice AnInvoice = new clsInvoice();

            String Error = "";
            string PartCost = "4000.00";

            Error = AnInvoice.Valid(ServiceID,
                                    VehicleID,
                                    LabourCost,
                                    PartCost,
                                    TotalAmount,
                                    Paid,
                                    InvoiceDate);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LabourCostMin()
        {
            clsInvoice AnInvoice = new clsInvoice();

            String Error = "";
            string LabourCost = "0.01";

            Error = AnInvoice.Valid(ServiceID,
                                    VehicleID,
                                    LabourCost,
                                    PartCost,
                                    TotalAmount,
                                    Paid,
                                    InvoiceDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LabourCostMid()
        {
            clsInvoice AnInvoice = new clsInvoice();

            String Error = "";
            string LabourCost = "200.00";

            Error = AnInvoice.Valid(ServiceID,
                                    VehicleID,
                                    LabourCost,
                                    PartCost,
                                    TotalAmount,
                                    Paid,
                                    InvoiceDate);

            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void LabourCostMax()
        {
            clsInvoice AnInvoice = new clsInvoice();

            String Error = "";
            string LabourCost = "5000.00";

            Error = AnInvoice.Valid(ServiceID,
                                    VehicleID,
                                    LabourCost,
                                    PartCost,
                                    TotalAmount,
                                    Paid,
                                    InvoiceDate);

            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void  StatStatisticsGroupedByPaid()
        {
            clsInvoice AnInvoice = new clsInvoice();

            DataTable dT = AnInvoice.StatisticsGroupedByPaid() ;


            int noOfRecords = 1;

            Assert.AreEqual(noOfRecords, dT.Rows.Count);
        }

        private DataTable StatisticsGroupedByPaid()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void StatStatisticsGroupedByServiceID()
        {
            clsInvoice AnInvoice = new clsInvoice();

            DataTable TestData;

            TestData = AnInvoice.StatisticsGroupedByServiceID();

            int noOfRecords = 3;

            Assert.AreEqual(noOfRecords, dT.Rows.Count);
        }

        private DataTable StatisticsGroupedByServiceID()
        {
            throw new NotImplementedException();
        }

        private string Valid(int serviceID, int vehicleID, string labourCost, object partCost, decimal totalAmount, object paid, DateTime invoiceDate)
        {
            throw new NotImplementedException();
        }

        private string Valid(int serviceID, int vehicleID, object labourCost, string partCost, decimal totalAmount, object paid, DateTime invoiceDate)
        {
            throw new NotImplementedException();
        }

        private string Valid(int serviceID, int vehicleID, object labourCost, object partCost, string totalAmount, object paid, DateTime invoiceDate)
        {
            throw new NotImplementedException();
        }

        private string Valid(int serviceID, int vehicleID, object labourCost, object partCost, decimal totalAmount, object paid, string invoiceDate)
        {
            throw new NotImplementedException();
        }

        private string Valid(int serviceID, int vehicleID, object labourCost, object partCost, decimal totalAmount, string paid, DateTime invoiceDate)
        {
            throw new NotImplementedException();
        }

        internal string Valid(string labourCosts, string partCosts, string serviceID, string vehicleID, string totalAmount, string invoiceDate)
        {
            throw new NotImplementedException();
        }

        private string Valid(string serviceID, int vehicleID, object labourCosts, object partCosts, decimal totalAmount, object paid, DateTime invoiceDate)
        {
            throw new NotImplementedException();
        }

        internal void Add(clsInvoice testItem)
        {
            throw new NotImplementedException();
        }

        public static implicit operator List<object>(clsInvoice v)
        {
            throw new NotImplementedException();
        }
    }

    internal class DataTable
    {
        public object Rows { get; internal set; }
    }
}
