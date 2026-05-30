using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsInventoryCollection
    {
        private List<clsInventory> mInventoryList = new List<clsInventory>();
        private clsInventory mThisInventory = new clsInventory();

        public clsInventoryCollection()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblInventory_SelectAll");

            int index = 0;
            int recordCount = DB.Count;

            while (index < recordCount)
            {
                clsInventory item = new clsInventory();

                item.PartID = Convert.ToInt32(DB.DataTable.Rows[index]["PartID"]);
                item.PartName = Convert.ToString(DB.DataTable.Rows[index]["PartName"]);
                item.Category = Convert.ToString(DB.DataTable.Rows[index]["Category"]);
                item.Quantity = Convert.ToInt32(DB.DataTable.Rows[index]["Quantity"]);
                item.InStock = Convert.ToBoolean(DB.DataTable.Rows[index]["InStock"]);
                item.Price = Convert.ToDecimal(DB.DataTable.Rows[index]["Price"]);

                mInventoryList.Add(item);
                index++;
            }
        }

        public List<clsInventory> InventoryList
        {
            get { return mInventoryList; }
            set { mInventoryList = value; }
        }

        public int Count
        {
            get { return mInventoryList.Count; }
        }

        public clsInventory ThisInventory
        {
            get { return mThisInventory; }
            set { mThisInventory = value; }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@PartName", mThisInventory.PartName);
            DB.AddParameter("@Category", mThisInventory.Category);
            DB.AddParameter("@Quantity", mThisInventory.Quantity);
            DB.AddParameter("@InStock", mThisInventory.InStock);
            DB.AddParameter("@Price", mThisInventory.Price);

            return DB.Execute("sproc_tblInventory_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@PartID", mThisInventory.PartID);
            DB.AddParameter("@PartName", mThisInventory.PartName);
            DB.AddParameter("@Category", mThisInventory.Category);
            DB.AddParameter("@Quantity", mThisInventory.Quantity);
            DB.AddParameter("@InStock", mThisInventory.InStock);
            DB.AddParameter("@Price", mThisInventory.Price);

            DB.Execute("sproc_tblInventory_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@PartID", mThisInventory.PartID);
            DB.Execute("sproc_tblInventory_Delete");
        }
    }
}