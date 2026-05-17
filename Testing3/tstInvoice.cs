using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstInvoice
    {
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
        public decimal PartsCost { get; set; }
        public decimal LabourCost { get; set; }
        public int VehicleID { get; set; }
        public int ServiceID { get; set; }
    }
}
