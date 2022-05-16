﻿using ClassLibrary;
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
        public void TestMethod1()
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
    }
}