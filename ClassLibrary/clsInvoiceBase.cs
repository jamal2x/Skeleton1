namespace ClassLibrary
{
    public class clsInvoiceBase
    {

        internal string Valid(string labourCosts, string partCosts, string serviceID, string vehicleID, string totalAmount, string invoiceDate)
        {
            //if ServiceID is blank
            if (serviceID.Length == 0)
            {
                Error = Error + "The service ID may not be blank : ";
            }

            //if ServiceID is too long
            if (serviceID.Length > 10)
            {
                Error = Error + "Service ID too long : ";

            }

        }
    }
}