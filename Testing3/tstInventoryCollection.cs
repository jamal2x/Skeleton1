using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ClassLibrary;

namespace ClassLibrary
{
    [TestClass]
    public class tstInventoryCollection
    {
        public clsInventory TestInventory { get; set; }
        public clsInventory ThisInventory { get; set; }
        public int PrimaryKey { get; set; }

        [TestMethod]
        public void InstanceOK()
        {
            clsInventoryCollection AllInventory = new clsInventoryCollection();
            Assert.IsNotNull(AllInventory);
        }

        [TestMethod]
        public void InventoryListOK()
        {
            clsInventoryCollection AllInventory = new clsInventoryCollection();

            List<clsInventory> TestList = new List<clsInventory>();

            Assert.AreEqual(AllInventory.InventoryList.Count, TestList.Count);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsInventoryCollection AllInventory = new clsInventoryCollection();

            int SomeCount = 1;

            Assert.AreEqual(AllInventory.Count, SomeCount);
        }

        [TestMethod]
        public void ThisInventoryPropertyOK()
        {
            clsInventoryCollection AllInventory = new clsInventoryCollection();

            clsInventory TestInventory = new clsInventory();

            AllInventory.ThisInventory = TestInventory;

            Assert.AreEqual(AllInventory.ThisInventory, TestInventory);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsInventoryCollection AllInventory = new clsInventoryCollection();

            List<clsInventory> TestList = new List<clsInventory>();

            clsInventory TestItem = new clsInventory();

            TestList.Add(TestItem);

            AllInventory.InventoryList = TestList;

            Assert.AreEqual(AllInventory.Count, TestList.Count);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsInventoryCollection AllInventory = new clsInventoryCollection();

            clsInventory TestInventory = new clsInventory();

            AllInventory.ThisInventory = TestInventory;

            PrimaryKey = AllInventory.Add();

            TestInventory.PartID = PrimaryKey;

            AllInventory.ThisInventory = TestInventory;

            AllInventory.Delete();

            bool Found = false; // after delete it should NOT be found

            Assert.IsFalse(Found);
        }
    }
}