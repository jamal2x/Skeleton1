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

        // public properties

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
    }
}