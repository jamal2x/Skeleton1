using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestMethod]
    public void InstanceOK()
    {
        tstInventory AnInventory = new tstInventory();
        Assert.IsNotNull(AnInventory);
    }

    class tstInventory
    {
        private int Quantity;

        public string PartName { get; private set; }
        public bool InStock { get; private set; }
        public decimal Price { get; private set; }
        public bool Paid { get; private set; }
        public int PartID { get; private set; }

        public tstInventory()
        {
        }


        [TestMethod]
        public void QuantityPropertyOK()
        {
            tstInventory AnInventory = new tstInventory();
            Int32 TestData = 10;
            AnInventory.Quantity = TestData;
            Assert.AreEqual(AnInventory.Quantity, TestData);
        }

        [TestMethod]
        public void PartNamePropertyOK()
        {
            tstInventory AnInventory = new tstInventory();
            string TestData = "Brake Pad";
            AnInventory.PartName = TestData;
            Assert.AreEqual(AnInventory.PartName, TestData);
        }

        [TestMethod]
        public void PartIDPropertyOK()
        {
            tstInventory AnInventory = new tstInventory();
            int TestData = 1;
            AnInventory.PartID = TestData;
            Assert.AreEqual(AnInventory.PartID, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            tstInventory AnInventory = new tstInventory();
            decimal TestData = 45.99m;
            AnInventory.Price = TestData;
            Assert.AreEqual(AnInventory.Price, TestData);
        }


        [TestMethod]
        public void PaidPropertyOK()
        {
            tstInventory AnInventory = new tstInventory();

            Boolean TestData = true;

            AnInventory.Paid = TestData;

            Assert.AreEqual(AnInventory.Paid, TestData);
        }

        [TestMethod]
        public void InStockPropertyOK()
        {
            tstInventory AnInventory = new tstInventory();

            Boolean TestData = true;

            AnInventory.InStock = TestData;

            Assert.AreEqual(AnInventory.InStock, TestData);
        }
    }
}