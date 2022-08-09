using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrders
    {
        //good test data
        //creating test data to pass to the method

        String OrderDate = DateTime.Now.Date.ToString();
        String OrderContent = "Test Content";
        String DeliveryAddress = "Some address";
        String TotalPrice = " £10";

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
        public void OrderContentPropertyOK()
        {
            //This creates a instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            // this creates some test data to assign to the property
            String TestData = "Test Content";
            // Assign the data to the property
            AnOrder.OrderContent = TestData;
            //Test to see that the two values are the same 
            Assert.AreEqual(AnOrder.OrderContent, TestData);
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
            float TestData = 35;
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
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            // boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderID = 6;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void TestDispatchedStatusFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //booleans variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (Assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 6;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the propery
            if (AnOrder.DispatchedStatus != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create 
            clsOrders AnOrder = new clsOrders();
            //booleans variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (Assume it is_
            Boolean OK = true;
            //create some tersrt data to use with the method 
            Int32 OrderID = 6;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.OrderDate != Convert.ToDateTime("14/09/1999"))
            {
                OK = false;

            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderContentFound()
        { //create an instance of the class we want to create 
            clsOrders AnOrder = new clsOrders();
            //booleans variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (Assume it is_
            Boolean OK = true;
            //create some tersrt data to use with the method 
            Int32 OrderID = 6;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.OrderContent != "TestContent")
            {
                OK = false;

            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]

        public void TestOrderIDFound()
        {
            //create an instance of the class we want to create 
            clsOrders AnOrder = new clsOrders();
            //booleans variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (Assume it is_
            Boolean OK = true;
            //create some tersrt data to use with the method 
            Int32 OrderID = 6;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the Order ID
            if (AnOrder.OrderID != 6)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestTotalPriceFound()
        {
            //create an instance of the class we want to create 
            clsOrders AnOrder = new clsOrders();
            //booleans variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (Assume it is_
            Boolean OK = true;
            //create some tersrt data to use with the method 
            Int32 OrderID = 6;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.TotalPrice != 200)
            {
                OK = false;

            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestDeliveryAddressFound()
        {
            //create an instance of the class we want to create 
            clsOrders AnOrder = new clsOrders();
            //booleans variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (Assume it is_
            Boolean OK = true;
            //create some tersrt data to use with the method 
            Int32 OrderID = 6;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.DeliveryAddress != "testAddress")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]

        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error messages
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(OrderContent, OrderDate, DeliveryAddress, TotalPrice);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void OrderContentMinLessOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string OrderContent = "";
            Error = AnOrder.Valid(OrderContent, OrderDate, DeliveryAddress, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderContentMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string OrderContent = "b"; //this should be okay
            //invoke the method
            Error = AnOrder.Valid(OrderContent, OrderDate, DeliveryAddress, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderContentMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string OrderContent = "bb"; //this should be okay
            //invoke the method
            Error = AnOrder.Valid(OrderContent, OrderDate, DeliveryAddress, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        
        [TestMethod]
        public void OrderContentMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string OrderContent = " ";
            OrderContent = OrderContent.PadRight(49, 'b');
            //invoke the method
            Error = AnOrder.Valid(OrderContent, OrderDate, DeliveryAddress, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderContentMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string OrderContent = "";//this should be okay
            OrderContent = OrderContent.PadRight(50, 'b');
            //invoke the method
            Error = AnOrder.Valid(OrderContent, OrderDate, DeliveryAddress, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderContentMid()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string OrderContent = "bbbbbbbbbbbbbbbbbbbbbbbbb"; //this should be okay
            //invoke the method
            Error = AnOrder.Valid(OrderContent, OrderDate, DeliveryAddress, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderContentMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string OrderContent = ""; //this should fail
            OrderContent = OrderContent.PadRight(51, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderContent, OrderDate, DeliveryAddress, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderContentExtremeMax()
        {

            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string OrderContent = ""; //this should fail
            OrderContent = OrderContent.PadRight(500, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderContent, OrderDate, DeliveryAddress, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
   
  
    }
