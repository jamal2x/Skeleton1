using System;



namespace ClassLibrary

{

    public class clsInvoice

    {

        public int ServiceID { get; set; }

        public int VehicleID { get; set; }

        public decimal LabourCosts { get; set; }

        public decimal PartsCost { get; set; }

        public decimal TotalAmount { get; set; }

        public DateTime InvoiceDate { get; set; }

        public bool Paid { get; set; }

    }

}