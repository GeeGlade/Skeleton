using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the staff
            //in this case the data needs to be a list of objects 

            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //set its properties 
            TestItem.Employed = true;
            TestItem.StaffID = 1;
            TestItem.FirstName = "Matthew";
            TestItem.LastName = "Smith";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Salary = 30000;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        

        [TestMethod]
        public void ThisStaffPropertyOK()
        {

            //create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the staff
            clsStaff TestStaff = new clsStaff();
            //set its properties 
            TestStaff.Employed = true;
            TestStaff.StaffID = 1;
            TestStaff.FirstName = "Matthew";
            TestStaff.LastName = "Smith";
            TestStaff.DateAdded = DateTime.Now.Date;
            TestStaff.Salary = 30000;
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);

        }

        [TestMethod]
        public void ListAndCountOK()
        {


            //create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the staff
            //in this case the data needs to be a list of objects 

            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //set its properties 
            TestItem.Employed = true;
            TestItem.StaffID = 1;
            TestItem.FirstName = "Matthew";
            TestItem.LastName = "Smith";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Salary = 30000;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);

        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffID = 25;
            TestItem.FirstName = "Paul";
            TestItem.LastName = "Brown";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Salary = 90000;
            TestItem.Employed = true;
            //set ThisAnStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //setthe primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);




        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffID = 1;
            TestItem.FirstName = "Matthew";
            TestItem.LastName = "Smith";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Salary = 30000;
            TestItem.Employed = true;
            //set ThisstaffMember to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //setthe primary key of the test data
            TestItem.StaffID = PrimaryKey;

            //set its properties
            TestItem.StaffID = 1;
            TestItem.FirstName = "Robert";
            TestItem.LastName = "Phillips";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Salary = 40000;
            TestItem.Employed = false;
            AllStaff.ThisStaff = TestItem;
            AllStaff.Update();

            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);




        }



    }


}
