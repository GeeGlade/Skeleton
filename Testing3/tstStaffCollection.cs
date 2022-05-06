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
            TestItem.StaffID = 123;
            TestItem.FirstName = "test";
            TestItem.LastName = "testname";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Salary = 60000;
            TestItem.Employed = false;
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
            TestItem.FirstName = "Robert";
            TestItem.LastName = "Johnson";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Salary = 70000;
            TestItem.Employed = false;
            //set ThisstaffMember to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //setthe primary key of the test data
            TestItem.StaffID = PrimaryKey;

            //set its properties
            TestItem.FirstName = "Paul";
            TestItem.LastName = "Wilkinson";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Salary = 50000;
            TestItem.Employed = true;
            AllStaff.ThisStaff = TestItem;
            AllStaff.Update();

            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);




        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffID = 123;
            TestItem.FirstName = "test";
            TestItem.LastName = "testname";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Salary = 60000;
            TestItem.Employed = false;
            //set ThisstaffMember to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //setthe primary key of the test data
            TestItem.StaffID = PrimaryKey;

            AllStaff.ThisStaff.Find(PrimaryKey);
            AllStaff.Delete();

            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByFirstNameMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaffCollection FilteredStaff = new clsStaffCollection();

            FilteredStaff.ReportByFirstName("");
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }


        [TestMethod]
        public void ReportByFirstNameNoneFound()
        {
            clsStaffCollection FilteredStaff = new clsStaffCollection();

            FilteredStaff.ReportByFirstName("xxxxxxxxxx");
            Assert.AreEqual(0, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByFirstNameDataFound()
        {
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            Boolean OK = true;
            FilteredStaff.ReportByFirstName("Matthew");
            if (FilteredStaff.Count == 1)
            {
                if (FilteredStaff.StaffList[0].StaffID != 1)
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
