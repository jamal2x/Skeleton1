using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary
{
    [TestClass]
    public class tstInvoiceCollection
    {
        public clsInvoice TestInvoice { get; private set; }
        public clsInvoice ThisInvoice { get; set; }
        public int PrimaryKey { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            clsInvoiceCollection AllInvoices = new clsInvoiceCollection();
            Assert.IsNotNull(AllInvoices);
        }

        [TestMethod]
        public void InvoiceListOK()
        {
            clsInvoiceCollection AllInvoices = new clsInvoiceCollection();

            List<clsInvoice> TestList = new List<clsInvoice>();

            clsInvoice TestInvoice = new clsInvoice();
            Assert.AreEqual(AllInvoices.InvoiceList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsInvoiceCollection AllInvoices = new clsInvoiceCollection();

            Int32 SomeCount =3 ;

            AllInvoices.Count = SomeCount;

            Assert.AreEqual(AllInvoices.Count, SomeCount);
        }


        [TestMethod]
        public void ThisInvoicePropertyOK()
        {
            clsInvoiceCollection AllInvoices = new clsInvoiceCollection();

            clsInvoice TestInvoice = new clsInvoice();

            AllInvoices.ThisInvoice = TestInvoice;

            Assert.AreEqual(AllInvoices.ThisInvoice, TestInvoice);
        }

        public void ListAndCountOK()
        {
            ListAndCountOK(TestInvoice);
        }

        private void ListAndCountOK(clsInvoice testInvoice)
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void ListAndCountOK(List<clsInvoice> testInvoice)
        {
            clsInvoiceCollection AllInvoices = new clsInvoiceCollection();

            List<clsInvoice> TestInovice = new List<clsInvoice>();

            clsInvoice TestItem = new clsInvoice();

            TestInvoice.Add(TestItem);

            AllInvoices.InvoiceList = testInvoice;

            Assert.AreEqual(AllInvoices.Count, TestInvoice.Count);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {
             clsInvoiceCollection AllInvoices = new clsInvoiceCollection();
            clsInvoice TestInvoice = new clsInvoice();
       AllInvoices.ThisInvoice = TestInvoice;
            PrimaryKey = AllInvoices.Add();
            TestInvoice.InvoiceID = PrimaryKey;
            AllInvoices.ThisInvoice.Find(PrimaryKey);
            AllInvoices.Delete();
            Boolean Found = AllInvoices.ThisInvoice.Find(PrimaryKey);
            Assert.IsFalse(Found);


     
        }


        [TestMethod]
        public void ReportByVehicleIDMethodOK()
        {
            clsInvoiceCollection AllInvoices = new clsInvoiceCollection();
            clsInvoiceCollection FilteredInvoices = new clsInvoiceCollection();

            FilteredInvoices.ReportByVehicleID("");

            Assert.AreEqual(AllInvoices.Count, FilteredInvoices.Count);
        }

        [TestMethod]
        public void ReportByVehicleIDNoneFound()
        {
            clsInvoiceCollection FilteredInvoices = new clsInvoiceCollection();

            FilteredInvoices.ReportByVehicleID("XXXXX");

            Assert.AreEqual(0, FilteredInvoices.Count);
        }

    }
}