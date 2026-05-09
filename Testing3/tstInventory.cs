using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestMethod]
    public void InstanceOK()
    {
        clsInventory AnInventory = new clsInventory();
        Assert.IsNotNull(AnInventory);
    }

    class clsInventory
    {
        private int Quantity;

        public clsInventory()
        {
        }


        [TestMethod]
        public void QuantityPropertyOK()
        {
            clsInventory AnInventory = new clsInventory();
            Int32 TestData = 10;
            AnInventory.Quantity = TestData;
            Assert.AreEqual(AnInventory.Quantity, TestData);
        }

        [TestMethod]
        public void PartNamePropertyOK()
        {
            clsInventory AnInventory = new clsInventory();
            string TestData = "Brake Pad";
            AnInventory.PartName = TestData;
            Assert.AreEqual(AnInventory.PartName, TestData);
        }

        [TestMethod]
        public void PartIDPropertyOK()
        {
            clsInventory AnInventory = new clsInventory();
            int TestData = 1;
            AnInventory.PartID = TestData;
            Assert.AreEqual(AnInventory.PartID, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            clsInventory AnInventory = new clsInventory();
            decimal TestData = 45.99m;
            AnInventory.Price = TestData;
            Assert.AreEqual(AnInventory.Price, TestData);
        }


        [TestMethod]
        public void PaidPropertyOK()
        {
            clsInventory AnInventory = new clsInventory();

            Boolean TestData = true;

            AnInventory.Paid = TestData;

            Assert.AreEqual(AnInventory.Paid, TestData);
        }

        [TestMethod]
        public void InStockPropertyOK()
        {
            clsInventory AnInventory = new clsInventory();

            Boolean TestData = true;

            AnInventory.InStock = TestData;

            Assert.AreEqual(AnInventory.InStock, TestData);
        }
    }
}