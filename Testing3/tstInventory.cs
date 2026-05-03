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
    } }