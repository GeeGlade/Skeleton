using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testing1
{
    /// <summary>
    /// Summary description for tstCustomerCollection
    /// </summary>
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create instance of clsCustomerCollection class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //Test to see if class was created
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //Create instance of clsCustomerCollection class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //List of objects created
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Object to add to list
            clsCustomer TestItem = new clsCustomer();
            //Object properties
            TestItem.CustomerID = 1;
            TestItem.CustomerUsername = "john";
            TestItem.CustomerPassword = "smith";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.BillingShippingAddress = "house lane";
            TestItem.Over18 = true;
            //Add object to list
            TestList.Add(TestItem);
            //Set property in collection to the created list
            AllCustomers.CustomerList = TestList;
            //Test to see if both lists are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //Create instance of clsCustomerCollection class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //Test data
            clsCustomer TestCustomer = new clsCustomer();
            //Set properties of test data
            TestCustomer.CustomerID = 1;
            TestCustomer.CustomerUsername = "john";
            TestCustomer.CustomerPassword = "smith";
            TestCustomer.DateAdded = DateTime.Now.Date;
            TestCustomer.BillingShippingAddress = "house lane";
            TestCustomer.Over18 = true;
            //Assign data to clsCustomerCollection instance
            AllCustomers.ThisCustomer = TestCustomer;
            //Test to see if both objects are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //Create instance of clsCustomerCollection class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //List of objects created
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Object to add to list
            clsCustomer TestItem = new clsCustomer();
            //Object properties
            TestItem.CustomerID = 1;
            TestItem.CustomerUsername = "john";
            TestItem.CustomerPassword = "smith";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.BillingShippingAddress = "house lane";
            TestItem.Over18 = true;
            //Add object to list
            TestList.Add(TestItem);
            //Set property in collection to the created list
            AllCustomers.CustomerList = TestList;
            //Test to see if both lists are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //Create instance of clsCustomerCollection class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //Test data
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            //Set properties of test data
            TestItem.CustomerUsername = "john";
            TestItem.CustomerPassword = "smith";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.BillingShippingAddress = "house lane";
            TestItem.Over18 = true;
            //Assign data to clsCustomerCollection instance
            AllCustomers.ThisCustomer = TestItem;
            //Add record
            PrimaryKey = AllCustomers.Add();
            //Set primary key to primary key of test data
            TestItem.CustomerID = PrimaryKey;
            //Find record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //Test to see if both objects are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //Create instance of clsCustomerCollection class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //Test data
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            //Set properties of test data
            TestItem.CustomerUsername = "john";
            TestItem.CustomerPassword = "smith";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.BillingShippingAddress = "house lane";
            TestItem.Over18 = true;
            //Assign data to clsCustomerCollection instance
            AllCustomers.ThisCustomer = TestItem;
            //Add record
            PrimaryKey = AllCustomers.Add();
            //Set primary key to primary key of test data
            TestItem.CustomerID = PrimaryKey;
            //Modify properties of test data
            TestItem.CustomerUsername = "james";
            TestItem.CustomerPassword = "roberts";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.BillingShippingAddress = "flat road";
            TestItem.Over18 = false;
            //Assign data to clsCustomerCollection instance
            AllCustomers.ThisCustomer = TestItem;
            //Add record
            AllCustomers.Update();
            //Find record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //Test to see if both objects are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //Create instance of clsCustomerCollection class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //Test data
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            //Set properties of test data
            TestItem.CustomerUsername = "john";
            TestItem.CustomerPassword = "smith";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.BillingShippingAddress = "house lane";
            TestItem.Over18 = true;
            //Assign data to clsCustomerCollection instance
            AllCustomers.ThisCustomer = TestItem;
            //Add record
            PrimaryKey = AllCustomers.Add();
            //Set primary key to primary key of test data
            TestItem.CustomerID = PrimaryKey;
            //Find record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //Delete record
            AllCustomers.Delete();
            //Find if it has been deleted
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //Test to see if both objects are the same
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void FilterByUsernameMethodOK()
        {
            //Create filtered and unfiltered list
            clsCustomerCollection UnfilteredCustomers = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //Run filter that should do nothing
            FilteredCustomers.FilterByUsername("");
            //Test to see if two lists are the same
            Assert.AreEqual(UnfilteredCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void FilterByUsernameNoneFound()
        {
            //Object to be filtered
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //Username that does not exist
            FilteredCustomers.FilterByUsername("asdfghjkl1");
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void FilterByUsernameDataFound()
        {
            //Object to be filtered
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //Store outcome, assumed true
            Boolean OK = true;
            //Username that exists for testing (1 and 2)
            FilteredCustomers.FilterByUsername("TestUsernameFilter");
            //Check both are found
            if(FilteredCustomers.Count == 2)
            {
                if(FilteredCustomers.CustomerList[0].CustomerID != 25 ||
                    FilteredCustomers.CustomerList[1].CustomerID != 26)
                {
                    OK = false;
                }

            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
