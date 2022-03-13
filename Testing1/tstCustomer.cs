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

        [TestMethod]
        public void CustomerIDOK()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Test data generated
            Int32 testData = 1;
            //Set property equal to test data
            TestCustomer.CustomerID = testData;
            //Test to see if it functions as expected
            Assert.AreEqual(TestCustomer.CustomerID, testData);
        }

        [TestMethod]
        public void CustomerUsernameOK()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Test data generated
            String testData = "TestName12345";
            //Set property equal to test data
            TestCustomer.CustomerUsername = testData;
            //Test to see if it functions as expected
            Assert.AreEqual(TestCustomer.CustomerUsername, testData);
        }

        [TestMethod]
        public void CustomerPasswordOK()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Test data generated
            String testData = "TestPass12345";
            //Set property equal to test data
            TestCustomer.CustomerPassword = testData;
            //Test to see if it functions as expected
            Assert.AreEqual(TestCustomer.CustomerPassword, testData);
        }

        [TestMethod]
        public void DateAddedOK()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Test data generated
            DateTime testData = DateTime.Now.Date;
            //Set property equal to test data
            TestCustomer.DateAdded = testData;
            //Test to see if it functions as expected
            Assert.AreEqual(TestCustomer.DateAdded, testData);
        }

        [TestMethod]
        public void Over18PropertyOK()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Test data generated
            Boolean testData = true;
            //Set property equal to test data
            TestCustomer.Over18 = testData;
            //Test to see if it functions as expected
            Assert.AreEqual(TestCustomer.Over18, testData);
        }

        public void BillingShippingAddressOK()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Test data generated
            String testData = "fake street 123";
            //Set property equal to test data
            TestCustomer.BillingShippingAddress = testData;
            //Test to see if it functions as expected
            Assert.AreEqual(TestCustomer.BillingShippingAddress, testData);
        }
    }
}
