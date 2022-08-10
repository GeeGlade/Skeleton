using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace tstOrdersCollection
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstanceOK()
        {
            //creating an instance of teh class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //test to see that the instance exist
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]

        public void OrdersListOK()
        {
            //creating an new instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objets
            List<clsOrders> TestList = new List<clsOrders>();
            //add an item to the list
            //create the item of test data
            clsOrders TestItem = new clsOrders();
            //setting its properties
            TestItem.OrderID = 1;
            TestItem.DispatchedStatus = true;
            TestItem.DeliveryAddress = "some delivery address";
            TestItem.OrderContent = "Some Order content";
            TestItem.TotalPrice = 100;
            TestItem.OrderDate = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllOrders.OrdersList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrdersList, TestList);

        }

       

        [TestMethod]
        public void ThisOrdersPropertyOK()
        {
            //creating an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create some test data to assign to the property
            clsOrders TestOrders = new clsOrders();
            //set the properties of the test object
            TestOrders.OrderID = 1;
            TestOrders.DispatchedStatus = true;
            TestOrders.DeliveryAddress = "some delivery address";
            TestOrders.OrderContent = "Some Order content";
            TestOrders.TotalPrice = 100;
            TestOrders.OrderDate = DateTime.Now;
            //assign the data to the property
            AllOrders.ThisOrders = TestOrders;
            //test to se that the two valus are the same 
            Assert.AreEqual(AllOrders.ThisOrders, TestOrders);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //creating an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //creating some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrders> TestList = new List<clsOrders>();
            //Add item to the list
            //creating the item of test data
            clsOrders TestItem = new clsOrders();
            //set its properties
            TestItem.OrderID = 1;
            TestItem.DispatchedStatus = true;
            TestItem.DeliveryAddress = "some delivery address";
            TestItem.OrderContent = "Some Order content";
            TestItem.TotalPrice = 100;
            TestItem.OrderDate = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign teh data to the property
            AllOrders.OrdersList = TestList;
            //test ti see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);

        }
       


        
    }
}
