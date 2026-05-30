using System;



namespace ClassLibrary

{

    public class clsInventory

    {

        //private data member for the part id property

        private Int32 mPartID;



        //part name private member

        private string mPartName;



        //category private member

        private string mCategory;



        //quantity private member

        private Int32 mQuantity;



        //price private member

        private decimal mPrice;



        //instock private member

        private Boolean mInStock;



        // PUBLIC PROPERTIES





        public int PartID

        {

            get

            {

                return mPartID;

            }

            set

            {

                mPartID = value;

            }

        }



        public string PartName

        {

            get

            {

                return mPartName;

            }

            set

            {

                mPartName = value;

            }

        }



        public string Category

        {

            get

            {

                return mCategory;

            }

            set

            {

                mCategory = value;

            }

        }



        public int Quantity

        {

            get

            {

                return mQuantity;

            }

            set

            {

                mQuantity = value;

            }

        }



        public decimal Price

        {

            get

            {

                return mPrice;

            }

            set

            {

                mPrice = value;

            }

        }



        public Boolean InStock

        {

            get

            {

                return mInStock;

            }

            set

            {

                mInStock = value;

            }

        }

        public double TotalCost { get; set; }




        // FIND METHOD




        public bool Find(int PartID)

        {

            //temporary hard coded data

            mPartID = 1;

            mPartName = "Brake Pad";

            mCategory = "Brakes";

            mQuantity = 10;

            mPrice = 25.99m;

            mInStock = true;



            return true;

        }




        // VALID METHOD





        public string Valid(string partName,

                            string category,

                            string quantity,

                            string price,

                            string inStock)

        {

            //string variable to store error messages

            String Error = "";



            //temporary variables

            Int32 QuantityTemp;

            Decimal PriceTemp;

            Boolean InStockTemp;




            // PART NAME VALIDATION



            if (partName.Length == 0)

            {

                Error = Error + "Part name may not be blank : ";

            }



            if (partName.Length > 50)

            {

                Error = Error + "Part name must be less than 50 characters : ";

            }


            // CATEGORY VALIDATION



            if (category.Length == 0)

            {

                Error = Error + "Category may not be blank : ";

            }



            if (category.Length > 50)

            {

                Error = Error + "Category must be less than 50 characters : ";

            }



            // QUANTITY VALIDATION




            try

            {

                QuantityTemp = Convert.ToInt32(quantity);



                if (QuantityTemp < 0)

                {

                    Error = Error + "Quantity cannot be negative : ";

                }

            }

            catch

            {

                Error = Error + "Quantity must be a number : ";

            }




            try

            {

                PriceTemp = Convert.ToDecimal(price);



                if (PriceTemp < 0)

                {

                    Error = Error + "Price cannot be negative : ";

                }

            }

            catch

            {

                Error = Error + "Price must be numeric : ";

            }


            // INSTOCK VALIDATION


            try

            {

                InStockTemp = Convert.ToBoolean(inStock);

            }

            catch

            {

                Error = Error + "InStock must be true or false : ";

            }


            //return any error messages

            return Error;

        }

    


        public decimal CalculateTotal()

        {

            return Quantity * Price;

        }

        public string Valid(string partName, string category, string quantity, string price)
        {
            throw new NotImplementedException();
        }

        public string Valid(string partID, string partName, string category, string quantity, string inStock, string price)
        {
            throw new NotImplementedException();
        }
    }

}