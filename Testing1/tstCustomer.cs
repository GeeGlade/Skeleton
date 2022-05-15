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

        [TestMethod]
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

        [TestMethod]
        public void FindMethodOK()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Boolean stores validation results
            Boolean Found = false;
            //Test data generated
            Int32 CustomerID = 3;
            //Invoke Find method
            Found = TestCustomer.Find(CustomerID);
            //Test to see if it functions as expected
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Boolean stores validation results
            Boolean Found = false;
            //Data validity boolean (assumed true)
            Boolean OK = true;
            //Test data generated
            Int32 CustomerID = 3;
            //Invoke Find method
            Found = TestCustomer.Find(CustomerID);
            //Check data validity
            if(TestCustomer.CustomerID != 3)
            {
                OK = false;
            }
            //Test to see if it functions as expected
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerUsernameFound()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Boolean stores validation results
            Boolean Found = false;
            //Data validity boolean (assumed true)
            Boolean OK = true;
            //Test data generated
            Int32 CustomerID = 3;
            //Invoke Find method
            Found = TestCustomer.Find(CustomerID);
            //Check data validity
            if (TestCustomer.CustomerUsername != "test")
            {
                OK = false;
            }
            //Test to see if it functions as expected
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerPasswordFound()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Boolean stores validation results
            Boolean Found = false;
            //Data validity boolean (assumed true)
            Boolean OK = true;
            //Test data generated
            Int32 CustomerID = 3;
            //Invoke Find method
            Found = TestCustomer.Find(CustomerID);
            //Check data validity
            if (TestCustomer.CustomerPassword != "testpass")
            {
                OK = false;
            }
            //Test to see if it functions as expected
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Boolean stores validation results
            Boolean Found = false;
            //Data validity boolean (assumed true)
            Boolean OK = true;
            //Test data generated
            Int32 CustomerID = 3;
            //Invoke Find method
            Found = TestCustomer.Find(CustomerID);
            //Check data validity
            if (TestCustomer.DateAdded != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //Test to see if it functions as expected
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOver18Found()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Boolean stores validation results
            Boolean Found = false;
            //Data validity boolean (assumed true)
            Boolean OK = true;
            //Test data generated
            Int32 CustomerID = 3;
            //Invoke Find method
            Found = TestCustomer.Find(CustomerID);
            //Check data validity
            if (!TestCustomer.Over18)
            {
                OK = false;
            }
            //Test to see if it functions as expected
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBillingShippingAddressFound()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Boolean stores validation results
            Boolean Found = false;
            //Data validity boolean (assumed true)
            Boolean OK = true;
            //Test data generated
            Int32 CustomerID = 3;
            //Invoke Find method
            Found = TestCustomer.Find(CustomerID);
            //Check data validity
            if (TestCustomer.BillingShippingAddress != "123 test street")
            {
                OK = false;
            }
            //Test to see if it functions as expected
            Assert.IsTrue(OK);
        }


        string CustomerUsername = "test";
        string CustomerPassword = "test2";
        string DateAdded = DateTime.Now.Date.ToString();
        string BillingShippingAddress = "21 house lane";

        [TestMethod]
        public void CustomerUsernameMinLessOne()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Create error message variable
            String Error = "";
            //Should fail
            CustomerUsername = "";
            Error = TestCustomer.Valid(CustomerUsername, CustomerPassword, DateAdded, BillingShippingAddress);
            //Test to see if result is expected
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerUsernameMin()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Create error message variable
            String Error = "";
            //Should pass
            CustomerUsername = "a";
            Error = TestCustomer.Valid(CustomerUsername, CustomerPassword, DateAdded, BillingShippingAddress);
            //Test to see if result is expected
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerUsernameMinPlusOne()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Create error message variable
            String Error = "";
            //Should pass
            CustomerUsername = "aa";
            Error = TestCustomer.Valid(CustomerUsername, CustomerPassword, DateAdded, BillingShippingAddress);
            //Test to see if result is expected
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerUsernameMaxLessOne()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Create error message variable
            String Error = "";
            //Should pass
            CustomerUsername = "";
            CustomerUsername = CustomerUsername.PadRight(19, 'a');
            Error = TestCustomer.Valid(CustomerUsername, CustomerPassword, DateAdded, BillingShippingAddress);
            //Test to see if result is expected
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerUsernameMax()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Create error message variable
            String Error = "";
            //Should pass
            CustomerUsername = "";
            CustomerUsername = CustomerUsername.PadRight(20, 'a');
            Error = TestCustomer.Valid(CustomerUsername, CustomerPassword, DateAdded, BillingShippingAddress);
            //Test to see if result is expected
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerUsernameMaxPlusOne()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Create error message variable
            String Error = "";
            //Should fail
            CustomerUsername = "";
            CustomerUsername = CustomerUsername.PadRight(21, 'a');
            Error = TestCustomer.Valid(CustomerUsername, CustomerPassword, DateAdded, BillingShippingAddress);
            //Test to see if result is expected
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerUsernameMid()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Create error message variable
            String Error = "";
            //Should pass
            CustomerUsername = "";
            CustomerUsername = CustomerUsername.PadRight(10, 'a');
            Error = TestCustomer.Valid(CustomerUsername, CustomerPassword, DateAdded, BillingShippingAddress);
            //Test to see if result is expected
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerUsernameMaxExtreme()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Create error message variable
            String Error = "";
            //Should fail
            CustomerUsername = "";
            CustomerUsername = CustomerUsername.PadRight(499, 'a');
            Error = TestCustomer.Valid(CustomerUsername, CustomerPassword, DateAdded, BillingShippingAddress);
            //Test to see if result is expected
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMinLessOne()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Create error message variable
            String Error = "";
            //Should fail
            CustomerPassword = "";
            Error = TestCustomer.Valid(CustomerUsername, CustomerPassword, DateAdded, BillingShippingAddress);
            //Test to see if result is expected
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMin()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Create error message variable
            String Error = "";
            //Should pass
            CustomerPassword = "a";
            Error = TestCustomer.Valid(CustomerUsername, CustomerPassword, DateAdded, BillingShippingAddress);
            //Test to see if result is expected
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPasswordMinPlusOne()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Create error message variable
            String Error = "";
            //Should pass
            CustomerPassword = "aa";
            Error = TestCustomer.Valid(CustomerUsername, CustomerPassword, DateAdded, BillingShippingAddress);
            //Test to see if result is expected
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPasswordMaxLessOne()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Create error message variable
            String Error = "";
            //Should pass
            CustomerPassword = "";
            CustomerPassword = CustomerPassword.PadRight(19, 'a');
            Error = TestCustomer.Valid(CustomerUsername, CustomerPassword, DateAdded, BillingShippingAddress);
            //Test to see if result is expected
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPasswordMax()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Create error message variable
            String Error = "";
            //Should pass
            CustomerPassword = "";
            CustomerPassword = CustomerPassword.PadRight(20, 'a');
            Error = TestCustomer.Valid(CustomerUsername, CustomerPassword, DateAdded, BillingShippingAddress);
            //Test to see if result is expected
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPasswordMaxPlusOne()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Create error message variable
            String Error = "";
            //Should fail
            CustomerPassword = "";
            CustomerPassword = CustomerPassword.PadRight(21, 'a');
            Error = TestCustomer.Valid(CustomerUsername, CustomerPassword, DateAdded, BillingShippingAddress);
            //Test to see if result is expected
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPasswordMid()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Create error message variable
            String Error = "";
            //Should pass
            CustomerPassword = "";
            CustomerPassword = CustomerPassword.PadRight(10, 'a');
            Error = TestCustomer.Valid(CustomerUsername, CustomerPassword, DateAdded, BillingShippingAddress);
            //Test to see if result is expected
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPasswordMaxExtreme()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Create error message variable
            String Error = "";
            //Should fail
            CustomerPassword = CustomerPassword.PadRight(500, 'a');
            Error = TestCustomer.Valid(CustomerUsername, CustomerPassword, DateAdded, BillingShippingAddress);
            //Test to see if result is expected
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BillingShippingAddressMinLessOne()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Create error message variable
            String Error = "";
            //Should fail
            BillingShippingAddress = "";
            Error = TestCustomer.Valid(CustomerUsername, CustomerPassword, DateAdded, BillingShippingAddress);
            //Test to see if result is expected
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BillingShippingAddressMin()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Create error message variable
            String Error = "";
            //Should pass
            BillingShippingAddress = "a";
            Error = TestCustomer.Valid(CustomerUsername, CustomerPassword, DateAdded, BillingShippingAddress);
            //Test to see if result is expected
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BillingShippingAddressMinPlusOne()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Create error message variable
            String Error = "";
            //Should pass
            BillingShippingAddress = "aa";
            Error = TestCustomer.Valid(CustomerUsername, CustomerPassword, DateAdded, BillingShippingAddress);
            //Test to see if result is expected
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BillingShippingAddressMaxLessOne()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Create error message variable
            String Error = "";
            //Should pass
            BillingShippingAddress = "";
            BillingShippingAddress = BillingShippingAddress.PadRight(49, 'a');
            Error = TestCustomer.Valid(CustomerUsername, CustomerPassword, DateAdded, BillingShippingAddress);
            //Test to see if result is expected
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BillingShippingAddressMax()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Create error message variable
            String Error = "";
            //Should pass
            BillingShippingAddress = "";
            BillingShippingAddress = BillingShippingAddress.PadRight(50, 'a');
            Error = TestCustomer.Valid(CustomerUsername, CustomerPassword, DateAdded, BillingShippingAddress);
            //Test to see if result is expected
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BillingShippingAddressMaxPlusOne()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Create error message variable
            String Error = "";
            //Should fail
            BillingShippingAddress = "";
            BillingShippingAddress = BillingShippingAddress.PadRight(51, 'a');
            Error = TestCustomer.Valid(CustomerUsername, CustomerPassword, DateAdded, BillingShippingAddress);
            //Test to see if result is expected
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void BillingShippingAddressMid()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Create error message variable
            String Error = "";
            //Should pass
            BillingShippingAddress = "";
            BillingShippingAddress = BillingShippingAddress.PadRight(25, 'a');
            Error = TestCustomer.Valid(CustomerUsername, CustomerPassword, DateAdded, BillingShippingAddress);
            //Test to see if result is expected
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BillingShippingAddressMaxExtreme()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Create error message variable
            String Error = "";
            //Should fail
            BillingShippingAddress = "";
            BillingShippingAddress = BillingShippingAddress.PadRight(500, 'a');
            Error = TestCustomer.Valid(CustomerUsername, CustomerPassword, DateAdded, BillingShippingAddress);
            //Test to see if result is expected
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Create error message variable
            String Error = "";
            //Should fail
            //Set Date 100 years ago as a string
            DateAdded = DateTime.Now.Date.AddYears(-100).ToString();
            Error = TestCustomer.Valid(CustomerUsername, CustomerPassword, DateAdded, BillingShippingAddress);
            //Test to see if result is expected
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Create error message variable
            String Error = "";
            //Should fail
            //Set Date 1 day ago as a string
            DateAdded = DateTime.Now.Date.AddDays(-1).ToString();
            Error = TestCustomer.Valid(CustomerUsername, CustomerPassword, DateAdded, BillingShippingAddress);
            //Test to see if result is expected
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void DateAddedMin()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Create error message variable
            String Error = "";
            //Should fail
            //Set Date today day ago as a string
            DateAdded = DateTime.Now.Date.ToString();
            Error = TestCustomer.Valid(CustomerUsername, CustomerPassword, DateAdded, BillingShippingAddress);
            //Test to see if result is expected
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Create error message variable
            String Error = "";
            //Should fail
            //Set Date 1 day forward as a string
            DateAdded = DateTime.Now.Date.AddDays(1).ToString();
            Error = TestCustomer.Valid(CustomerUsername, CustomerPassword, DateAdded, BillingShippingAddress);
            //Test to see if result is expected
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Create error message variable
            String Error = "";
            //Should fail
            //Set Date 100 years forward as a string
            DateAdded = DateTime.Now.Date.AddYears(100).ToString();
            Error = TestCustomer.Valid(CustomerUsername, CustomerPassword, DateAdded, BillingShippingAddress);
            //Test to see if result is expected
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateAddedInvalid()
        {
            //Create instance of clsCustomer class
            clsCustomer TestCustomer = new clsCustomer();
            //Create error message variable
            String Error = "";
            //Should fail
            //Set Date to invalid date
            DateAdded = "friday";
            Error = TestCustomer.Valid(CustomerUsername, CustomerPassword, DateAdded, BillingShippingAddress);
            //Test to see if result is expected
            Assert.AreNotEqual(Error, "");

        }

    }
}
