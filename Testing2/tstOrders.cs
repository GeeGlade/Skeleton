using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrders
    {
        [TestMethod]
        public void InstanceOK()
        {
            //This creates a instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            // this test to see if its exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void DispatchedStatusPropertyOK()
        {
            // this creates a instance of the class we want to create 
            clsOrders AnOrder = new clsOrders();
            // this creates test data to assign to the property
            Boolean TestData = true;
            AnOrder.Active = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.Active, TestData);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            //This creates a instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //This creates test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            // this assigns the data to the property
            AnOrder.OrderDate = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);

        }

        [TestMethod]
        public void OrderContentsPropertyOK()
        {
            //This creates a instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            // this creates some test data to assign to the property
            String TestData = "36GB RAM";
            // Assign the data to the property
            AnOrder.OrderContents = TestData;
            //Test to see that the two values are the same 
            Assert.AreEqual(AnOrder.OrderContents, TestData);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //This creates a instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //this creates some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderID = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

        [TestMethod]

        public void TotalPricePropertyOK()
        {
            // this creates a instance of the class we want to create 
            clsOrders AnOrder = new clsOrders();
            // this creates some test data to assign to the property
            float TestData = 54;
            //Assign the data to the property
            AnOrder.TotalPrice = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnOrder.TotalPrice, TestData);

        }

        [TestMethod]

        public void DeliveryAddressPropertyOK()
        {
            //this creates a instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //this creates some test data to assign to the property
            String TestData = "25 Thisway Street Leicester";
            // assign the data to the property
            AnOrder.DeliveryAddress = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.DeliveryAddress, TestData);
        }
            
    }
}
