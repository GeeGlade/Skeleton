using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrders
    {

        [TestMethod]
        public void FindMethodOK()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Int32 OrderID = 1;
            Found = AnOrder.Find(OrderID);
            Assert.IsTrue(Found);
        }

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
        
        
        

        [TestMethod]
        public void TestOrderIDFound()
        {
            clsOrders  AnOrder = new clsOrders();

            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 21;
            Found = AnOrder.Find(OrderID);
            if(AnOrder.OrderID  !=21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]

        public void TestOrderDateFound()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 21;
            Found = AnOrder.Find(OrderID);
            if(AnOrder.OrderDate!= Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrdersContentFound()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 21;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.OrderContents != "Test Order content")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 21;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.Active != true)
            { 
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestTotalPriceFound()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 21;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.TotalPrice != (float)Convert.ToDecimal("34.34"));
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDeliveryAddressFound()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 21;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.DeliveryAddress != "Test delivery address")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        }
    }
