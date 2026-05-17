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

        private bool mPaid;



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



        // Paid property

        public bool Paid

        {

            get

            {

                return mPaid;

            }

            set

            {

                mPaid = value;

            }

        }

        public bool Find(int PartID)
        {
            mPartID = 21;
            mPartName = "Brake Pad";
            mQuantity = 10;
            mPrice = 5.99;
            mInStock = true;
            mPaid = false;

            return true;
        }
    }

    }