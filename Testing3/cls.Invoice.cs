using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing3
{
    [TestMethod]
    public void QuantityPropertyOK()
    {
        clsInvoice AnInvoice = new clsInvoice();
        AnInvoice.Quantity = 5;
        Assert.AreEqual(5, AnInvoice.Quantity);
    }

    class clsInvoice
    {
        internal int Quantity;

        public clsInvoice()
        {
        }
    }
}
}
