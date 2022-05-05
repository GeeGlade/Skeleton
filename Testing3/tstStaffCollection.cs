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

    }

  
}
