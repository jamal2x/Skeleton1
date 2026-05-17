using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

using ClassLibrary;



namespace Testing3

{

    [TestClass]

    public class tstInventory

    {

        //good test data

        string PartID = "1";

        string PartName = "Brake Pad";

        string Category = "Brakes";

        string Quantity = "10";

        string Price = "25.99";

        string InStock = "true";



        //=================================================

        // INSTANCE TEST

        //=================================================



        [TestMethod]

        public void InstanceOK()

        {

            clsInventory AnInventory = new clsInventory();

            Assert.IsNotNull(AnInventory);

        }



        //=================================================

        // PROPERTY TESTS

        //=================================================



        [TestMethod]

        public void PartIDPropertyOK()

        {

            clsInventory AnInventory = new clsInventory();



            Int32 TestData = 1;

            AnInventory.PartID = TestData;



            Assert.AreEqual(AnInventory.PartID, TestData);

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

        public void CategoryPropertyOK()

        {

            clsInventory AnInventory = new clsInventory();



            string TestData = "Brakes";

            AnInventory.Category = TestData;



            Assert.AreEqual(AnInventory.Category, TestData);

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

        public void PricePropertyOK()

        {

            clsInventory AnInventory = new clsInventory();



            decimal TestData = 25.99m;

            AnInventory.Price = (double)TestData;



            Assert.AreEqual(AnInventory.Price, TestData);

        }



        [TestMethod]

        public void InStockPropertyOK()

        {

            clsInventory AnInventory = new clsInventory();



            Boolean TestData = true;

            AnInventory.InStock = TestData;



            Assert.AreEqual(AnInventory.InStock, TestData);

        }


        [TestMethod]
        public void CalculateTotalOK()
        {
            clsInventory AnInventory = new clsInventory();

            AnInventory.Quantity = 2;
            AnInventory.Price = 25.99;

            AnInventory.CalculateTotal();

            Assert.AreEqual(51.98, AnInventory.TotalCost);
        }


        //=================================================

        // FIND METHOD TEST

        //=================================================



        [TestMethod]

        public void FindMethodOK()

        {

            clsInventory AnInventory = new clsInventory();



            Boolean Found = false;



            Int32 PartID = 1;



            Found = AnInventory.Find(PartID);



            Assert.IsTrue(Found);

        }



        //=================================================

        // TEST DATA FOUND

        //=================================================



        [TestMethod]

        public void TestPartIDFound()

        {

            clsInventory AnInventory = new clsInventory();



            Boolean Found = false;

            Boolean OK = true;



            Int32 PartID = 1;



            Found = AnInventory.Find(PartID);



            if (AnInventory.PartID != 1)

            {

                OK = false;

            }



            Assert.IsTrue(OK);

        }



        [TestMethod]

        public void TestPartNameFound()

        {

            clsInventory AnInventory = new clsInventory();



            Boolean Found = false;

            Boolean OK = true;



            Int32 PartID = 1;



            Found = AnInventory.Find(PartID);



            if (AnInventory.PartName != "Brake Pad")

            {

                OK = false;

            }



            Assert.IsTrue(OK);

        }



        [TestMethod]

        public void TestCategoryFound()

        {

            clsInventory AnInventory = new clsInventory();



            Boolean Found = false;

            Boolean OK = true;



            Int32 PartID = 1;



            Found = AnInventory.Find(PartID);



            if (AnInventory.Category != "Brakes")

            {

                OK = false;

            }



            Assert.IsTrue(OK);

        }



        [TestMethod]

        public void TestQuantityFound()

        {

            clsInventory AnInventory = new clsInventory();



            Boolean Found = false;

            Boolean OK = true;



            Int32 PartID = 1;



            Found = AnInventory.Find(PartID);



            if (AnInventory.Quantity != 10)

            {

                OK = false;

            }



            Assert.IsTrue(OK);

        }



        [TestMethod]

        public void TestPriceFound()

        {

            clsInventory AnInventory = new clsInventory();



            Boolean Found = false;

            Boolean OK = true;



            Int32 PartID = 1;



            Found = AnInventory.Find(PartID);



            if (AnInventory.Price != 25.99)

            {

                OK = false;

            }



            Assert.IsTrue(OK);

        }



        [TestMethod]

        public void TestInStockFound()

        {

            clsInventory AnInventory = new clsInventory();



            Boolean Found = false;

            Boolean OK = true;



            Int32 PartID = 1;



            Found = AnInventory.Find(PartID);



            if (AnInventory.InStock != true)

            {

                OK = false;

            }



            Assert.IsTrue(OK);

        }



        //=================================================

        // VALID METHOD TEST

        //=================================================



        [TestMethod]

        public void ValidMethodOK()

        {

            clsInventory AnInventory = new clsInventory();



            String Error = "";


            Error = AnInventory.Valid(PartName, Category, Quantity, Price, InStock);


            Assert.AreEqual(Error, "");

        }


        [TestMethod]
public void PartNameMinLessOne()
{
    clsInventory AnInventory = new clsInventory();

    string Error = "";

    string PartName = "";

    Error = AnInventory.Valid
    (
        PartName,
        Category,
        Quantity,
        Price
    );

    Assert.AreNotEqual(Error, "");
}
    }

}