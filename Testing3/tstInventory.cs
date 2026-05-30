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

        public decimal Testdata { get; private set; }

        [TestMethod]

        public void InstanceOK()

        {

            clsInventory AnInventory = new clsInventory();

            Assert.IsNotNull(AnInventory);

        }



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

            AnInventory.Price = (decimal)Testdata;


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
            AnInventory.Price = 25.99m;

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



            if (AnInventory.Price != 25.99m)

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


 //VALID METHOD TEST

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
    

    [TestMethod]
        public void PartNameMin()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            string PartName = "a";

            Error = AnInventory.Valid(PartName, Category, Quantity, Price, InStock);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PartNameMid()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            string PartName = "Brake";

            Error = AnInventory.Valid(PartName, Category, Quantity, Price, InStock);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PartNameMax()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            string PartName = "";
            PartName = PartName.PadRight(50, 'a');

            Error = AnInventory.Valid(PartName, Category, Quantity, Price, InStock);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PartNameMaxPlusOne()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            string PartName = "";
            PartName = PartName.PadRight(51, 'a');

            Error = AnInventory.Valid(PartName, Category, Quantity, Price, InStock);

            Assert.AreNotEqual(Error, "");
        }

        //========================
        // CATEGORY TESTS
        //========================

        [TestMethod]
        public void CategoryMinLessOne()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            string Category = "";

            Error = AnInventory.Valid(PartName, Category, Quantity, Price, InStock);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMid()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            string Category = "Engine";

            Error = AnInventory.Valid(PartName, Category, Quantity, Price, InStock);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMaxPlusOne()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            string Category = "";
            Category = Category.PadRight(51, 'a');

            Error = AnInventory.Valid(PartName, Category, Quantity, Price, InStock);

            Assert.AreNotEqual(Error, "");
        }

        //========================
        // QUANTITY TESTS
        //========================

        [TestMethod]
        public void QuantityMinLessOne()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            string Quantity = "";

            Error = AnInventory.Valid(PartName, Category, Quantity, Price, InStock);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMid()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            string Quantity = "50";

            Error = AnInventory.Valid(PartName, Category, Quantity, Price, InStock);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityInvalid()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            string Quantity = "abc";

            Error = AnInventory.Valid(PartName, Category, Quantity, Price, InStock);

            Assert.AreNotEqual(Error, "");
        }

        //========================
        // PRICE TESTS
        //========================

        [TestMethod]
        public void PriceMinLessOne()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            string Price = "";

            Error = AnInventory.Valid(PartName, Category, Quantity, Price, InStock);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            string Price = "25.99";

            Error = AnInventory.Valid(PartName, Category, Quantity, Price, InStock);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceInvalid()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            string Price = "abc";

            Error = AnInventory.Valid(PartName, Category, Quantity, Price, InStock);

            Assert.AreNotEqual(Error, "");
        }

        //========================
        // INSTOCK TESTS
        //========================

        [TestMethod]
        public void InStockValid()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            string InStock = "true";

            Error = AnInventory.Valid(PartName, Category, Quantity, Price, InStock);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InStockInvalid()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            string InStock = "maybe";

            Error = AnInventory.Valid(PartName, Category, Quantity, Price, InStock);

            Assert.AreNotEqual(Error, "");
        }
    }
}