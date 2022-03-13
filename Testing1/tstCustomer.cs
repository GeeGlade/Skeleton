using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Test to see if it exists
            Assert.IsNotNull(TestCustomer);
        }
    }
}
