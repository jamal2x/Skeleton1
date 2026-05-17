using System;



namespace ClassLibrary

{

    public class clsInventory

    {

        // private data members

        private string mPartName;

        private int mPartID;

        private int mQuantity;

        private double mPrice;

        private bool mInStock;

        private string mCategory;

        public double TotalCost { get; set; }


        // PartName property

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



        // PartID property

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



        // Quantity property

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

        public double CalculateTotal()
        {
            return Quantity * Price;
        }
        // Price property

        public double Price

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



        // InStock property

        public bool InStock

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


   


        public bool Find(int PartID)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@PartID", PartID);

            DB.Execute("sproc_tblInventory_FilterByPartID");

            if (DB.Count == 1)
            {
                mPartID = Convert.ToInt32(DB.DataTable.Rows[0]["PartID"]);

                mPartName = Convert.ToString(DB.DataTable.Rows[0]["PartName"]);

                mCategory = Convert.ToString(DB.DataTable.Rows[0]["Category"]);

                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);

                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);

                mInStock = Convert.ToBoolean(DB.DataTable.Rows[0]["InStock"]);

                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(object partID, object partName, object category, object quantity, object price, object inStock)
        {
            string Error = "";

            return Error;
        }

        public string Valid(string partName, string category, string quantity, string price, string inStock)
        {
            string Error = "";

            if (partName.Length == 0)
            {
                Error = Error + "The part name may not be blank : ";
            }

            if (partName.Length > 50)
            {
                Error = Error + "Part name too long : ";
            }

            //CATEGORY
            if (category.Length == 0)
            {
                Error = Error + "Category may not be blank : ";
            }

            if (category.Length > 30)
            {
                Error = Error + "Category too long : ";
            }

            //QUANTITY
            try
            {
                Convert.ToInt32(quantity);
            }
            catch
            {
                Error = Error + "Quantity invalid : ";
            }

            //PRICE
            try
            {
                Convert.ToDouble(price);
            }
            catch
            {
                Error = Error + "Price invalid : ";
            }

            return Error;
        }

           
    



        public string Valid(string partName, string category, string quantity, string price)
        {
            throw new NotImplementedException();
        }
    }
}

    