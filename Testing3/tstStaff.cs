using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStaff { 

        string FirstName = "Matthew";
        string LastName = "Smith";
        string DateAdded= DateTime.Now.Date.ToString();
        string Salary = 30000.ToString();

    
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff AnStaff = new clsStaff ();

            Assert.IsNotNull(AnStaff);

        }

        [TestMethod]
        public void StaffIDOk()
        {
            clsStaff AnStaff = new clsStaff();

            Int32 TestData = 324780;

            AnStaff.StaffID = TestData;

            Assert.AreEqual(AnStaff.StaffID, TestData);
        }

        [TestMethod]
        public void FirstNameOk()
        {
            clsStaff AnStaff = new clsStaff();

            String TestData = "Bob";

            AnStaff.FirstName = TestData;

            Assert.AreEqual(AnStaff.FirstName, TestData);
        }

        [TestMethod]
        public void LastNameOk()
        {
            clsStaff AnStaff = new clsStaff();

            String TestData = "Smith";

            AnStaff.LastName = TestData;

            Assert.AreEqual(AnStaff.LastName, TestData);
        }

        [TestMethod]
        public void DateAddedOk()
        {
            clsStaff AnStaff = new clsStaff();

            DateTime TestData = DateTime.Now.Date;

            AnStaff.DateAdded = TestData;

            Assert.AreEqual(AnStaff.DateAdded, TestData);
        }


        [TestMethod]
        public void EmployedOk()
        {
            clsStaff AnStaff = new clsStaff();

            Boolean TestData = true;

            AnStaff.Employed = TestData;

            Assert.AreEqual(AnStaff.Employed, TestData);
        }

        [TestMethod]
        public void SalaryOk()
        {
            clsStaff AnStaff = new clsStaff();

            float TestData = 20000;

            AnStaff.Salary = TestData;

            Assert.AreEqual(AnStaff.Salary, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {

            clsStaff AnStaff = new clsStaff();

            Boolean Found = false;

            Int32 StaffID = 1;

            Found = AnStaff.Find(StaffID);

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void FirstNameFound()
        {

            clsStaff AnStaff = new clsStaff();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StaffID = 1;

            Found = AnStaff.Find(StaffID);

            if (AnStaff.FirstName != "Matthew")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameFound()
        {

            clsStaff AnStaff = new clsStaff();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StaffID = 1;

            Found = AnStaff.Find(StaffID);

            if (AnStaff.LastName != "Smith")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DateAddedFound()
        {

            clsStaff AnStaff = new clsStaff();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StaffID = 1;

            Found = AnStaff.Find(StaffID);

            if (AnStaff.DateAdded != Convert.ToDateTime("06/05/2022"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmployedFound()
        {

            clsStaff AnStaff = new clsStaff();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StaffID = 1;

            Found = AnStaff.Find(StaffID);

            if (AnStaff.Employed != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SalaryFound()
        {

            clsStaff AnStaff = new clsStaff();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StaffID = 1;

            Found = AnStaff.Find(StaffID);

            if (AnStaff.Salary != 30000)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffIDFound()
        {

            clsStaff AnStaff = new clsStaff();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StaffID = 1;

            Found = AnStaff.Find(StaffID);

            if (AnStaff.StaffID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        public void ValidMethodOk()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            Error = AnStaff.Valid(FirstName,LastName,DateAdded,Salary);
            Assert.AreEqual(Error, "");
        }


    [TestMethod]

    public void FirstNameMinLessOne()

    {

        //create an instance of the class we want to create

        clsStaff AnStaff = new clsStaff();

        //string variable to store any error message

        String Error = "";

        //invoke the method

        //create some test data to pass the method

        string FirstName = "";

        Error = AnStaff.Valid(FirstName, LastName, DateAdded, Salary);

        //test to see that the result is correct 

        Assert.AreNotEqual(Error, "");





    }

    public void FirstNameMin()

    {

        //create an instance of the class we want to create

        clsStaff AnStaff = new clsStaff();

        //string variable to store any error message

        String Error = "";

        //create some test data to pass to the method

        string FirstName = "a"; //this should be ok

        //invoke the method

        Error = AnStaff.Valid(FirstName, LastName,  DateAdded, Salary);

        //test to see that the result is correct

        Assert.AreEqual(Error, "");

    }



    [TestMethod]

    public void FirstNameMinPlusOne()

    {

        //create an instance of the class we want to create

        clsStaff AnStaff = new clsStaff();

        //string variable to store any error message

        String Error = "";

        //create some test data to pass to the method

        string FirstName = "aa"; //this should be ok

        //invoke the method

        Error = AnStaff.Valid(FirstName, LastName,  DateAdded,  Salary);

        //test to see that the result is correct

        Assert.AreEqual(Error, "");

    }



    [TestMethod]

    public void FirstNameMaxLessOne()

    {

        //create an instance of the class we want to create

        clsStaff AnStaff = new clsStaff();

        //string variable to store any error message

        String Error = "";

        //create some test data to pass to the method

        string FirstName = "aaaaa"; //this should be ok

        //invoke the method

        Error = AnStaff.Valid(FirstName, LastName,DateAdded, Salary);

        //test to see that the result is correct

        Assert.AreEqual(Error, "");

    }

    [TestMethod]

    public void FirstNameMax()

    {

        //create an instance of the class we want to create

        clsStaff AnStaff = new clsStaff();

        //string variable to store any error message

        String Error = "";

        //create some test data to pass to the method

        string FirstName = "aaaaaa"; //this should be ok

        //invoke the method

        Error = AnStaff.Valid(FirstName, LastName,DateAdded,  Salary);

        //test to see that the result is correct

        Assert.AreEqual(Error, "");

    }



    [TestMethod]

    public void FirstNameMid()

    {

        //create an instance of the class we want to create

        clsStaff AnStaff = new clsStaff();

        //string variable to store any error message

        String Error = "";

        //create some test data to pass to the method

        string FirstName = "aaa"; //this should be ok

        //invoke the method

        Error = AnStaff.Valid(FirstName, LastName, DateAdded, Salary);

        //test to see that the result is correct

        Assert.AreEqual(Error, "");

    }



    [TestMethod]

    public void FirstNameMaxPlusOne()

    {

        //create an instance of the class we want to create

        clsStaff AnStaff = new clsStaff();

        //string variable to store any error message

        String Error = "";

        //create some test data to pass to the method

        string FirstName = "aaaaaaa"; //this should be ok

        //invoke the method

        Error = AnStaff.Valid(FirstName, LastName, DateAdded, Salary);

        //test to see that the result is correct

        Assert.AreEqual(Error, "");

    }



    [TestMethod]

    public void FirstNameExtremeMax()

    {

        //create an instance of the class we want to create

        clsStaff AnStaff = new clsStaff();

        //string variable to store any error message

        String Error = "";

        //create some test data to pass to the method

        string FirstName = "";

        FirstName = FirstName.PadRight(500, 'a');//this should be ok

        //invoke the method

        Error = AnStaff.Valid(FirstName, LastName, DateAdded, Salary);

        //test to see that the result is correct

        Assert.AreNotEqual(Error, "");

    }





    [TestMethod]

    public void LastNameMinLessOne()

    {

        //create an instance of the class we want to create

        clsStaff AnStaff = new clsStaff();

        //string variable to store any error message

        String Error = "";

        //invoke the method

        //create some test data to pass the method

        string LastName = "";

        Error = AnStaff.Valid(FirstName, LastName,  DateAdded, Salary);

        //test to see that the result is correct 

        Assert.AreNotEqual(Error, "");





    }

    public void LastNameMin()

    {

        //create an instance of the class we want to create

        clsStaff AnStaff = new clsStaff();

        //string variable to store any error message

        String Error = "";

        //create some test data to pass to the method

        string LastName = "a"; //this should be ok

        //invoke the method

        Error = AnStaff.Valid(FirstName, LastName,  DateAdded,Salary);

        //test to see that the result is correct

        Assert.AreEqual(Error, "");

    }



    [TestMethod]

    public void LastNameMinPlusOne()

    {

        //create an instance of the class we want to create

        clsStaff AnStaff = new clsStaff();

        //string variable to store any error message

        String Error = "";

        //create some test data to pass to the method

        string LastName = "aa"; //this should be ok

        //invoke the method

        Error = AnStaff.Valid(FirstName, LastName, DateAdded, Salary);

        //test to see that the result is correct

        Assert.AreEqual(Error, "");

    }



    [TestMethod]

    public void LastNameMaxLessOne()

    {

        //create an instance of the class we want to create

        clsStaff AnStaff = new clsStaff();

        //string variable to store any error message

        String Error = "";

        //create some test data to pass to the method

        string LastName = "aaaaa"; //this should be ok

        //invoke the method

        Error = AnStaff.Valid(FirstName, LastName, DateAdded,  Salary);

        //test to see that the result is correct

        Assert.AreEqual(Error, "");

    }

    [TestMethod]

    public void LastNameMax()

    {

        //create an instance of the class we want to create

        clsStaff AnStaff = new clsStaff();

        //string variable to store any error message

        String Error = "";

        //create some test data to pass to the method

        string LastName = "aaaaaa"; //this should be ok

        //invoke the method

        Error = AnStaff.Valid(FirstName, LastName, DateAdded, Salary);

        //test to see that the result is correct

        Assert.AreEqual(Error, "");

    }



    [TestMethod]

    public void LastNameMid()

    {

        //create an instance of the class we want to create

        clsStaff AnStaff = new clsStaff();

        //string variable to store any error message

        String Error = "";

        //create some test data to pass to the method

        string LastName = "aaa"; //this should be ok

        //invoke the method

        Error = AnStaff.Valid(FirstName, LastName, DateAdded, Salary);

        //test to see that the result is correct

        Assert.AreEqual(Error, "");

    }



    [TestMethod]

    public void LastNameMaxPlusOne()

    {

        //create an instance of the class we want to create

        clsStaff AnStaff = new clsStaff();

        //string variable to store any error message

        String Error = "";

        //create some test data to pass to the method

        string LastName = "aaaaaaa"; //this should be ok

        //invoke the method

        Error = AnStaff.Valid(FirstName, LastName, DateAdded,  Salary);

        //test to see that the result is correct

        Assert.AreEqual(Error, "");

    }



    [TestMethod]

    public void LastNameExtremeMax()

    {

        //create an instance of the class we want to create

        clsStaff AnStaff = new clsStaff();

        //string variable to store any error message

        String Error = "";

        //create some test data to pass to the method

        string LastName = "";

        LastName = LastName.PadRight(500, 'a');//this should be ok

        //invoke the method

        Error = AnStaff.Valid(FirstName, LastName,  DateAdded, Salary);

        //test to see that the result is correct

        Assert.AreNotEqual(Error, "");

    }



    [TestMethod]

    public void DateAddedExtremeMin()

    {

        //create an instance of the class we want to create

        clsStaff AnStaff = new clsStaff();

        //string variable to store any error message

        String Error = "";

        //create a variable to store the test date data

        DateTime TestDate;

        //set the date totodays date

        TestDate = DateTime.Now.Date;

        //change the date to whatever the date is less 100 years

        TestDate = TestDate.AddYears(-100);

        //convert the date variable to a string variable

        string DateAdded = TestDate.ToString();

        //invoke the method

        Error = AnStaff.Valid(FirstName, LastName,DateAdded,  Salary);

        //test to see that the result is correct

        Assert.AreNotEqual(Error, "");

    }



    [TestMethod]

    public void DateAddedMinLessOne()

    {

        //create an instance of the class we want to create

        clsStaff AnStaff = new clsStaff();

        //string variable to store any error message

        String Error = "";

        //create a variable to store the test date data

        DateTime TestDate;

        //set the date totodays date

        TestDate = DateTime.Now.Date;

        //change the date to whatever the date is less 1 day

        TestDate = TestDate.AddDays(-1);

        //convert the date variable to a string variable

        string DateAdded = TestDate.ToString();

        //invoke the method

        Error = AnStaff.Valid(FirstName, LastName, DateAdded,Salary);

        //test to see that the result is correct

        Assert.AreNotEqual(Error, "");

    }



    [TestMethod]

    public void DateAddedAddedMin()

    {

        //create an instance of the class we want to create

        clsStaff AnStaff = new clsStaff();

        //string variable to store any error message

        String Error = "";

        //create a variable to store the test date data

        DateTime TestDate;

        //set the date totodays date

        TestDate = DateTime.Now.Date;

        //convert the date variable to a string variable

        string DateAdded = TestDate.ToString();

        //invoke the method

        Error = AnStaff.Valid(FirstName, LastName, DateAdded, Salary);

        //test to see that the result is correct

        Assert.AreEqual(Error, "");

    }

    [TestMethod]

    public void DateAddedMinPlusOne()

    {

        //create an instance of the class we want to create

        clsStaff AnStaff = new clsStaff();

        //string variable to store any error message

        String Error = "";

        //create a variable to store the test date data

        DateTime TestDate;

        //set the date totodays date

        TestDate = DateTime.Now.Date;

        //change the date to whatever the date is plus 1 day

        TestDate = TestDate.AddDays(1);

        //convert the date variable to a string variable

        string DateAdded = TestDate.ToString();

        //invoke the method

        Error = AnStaff.Valid(FirstName, LastName, DateAdded, Salary);

        //test to see that the result is correct

        Assert.AreNotEqual(Error, "");

    }



    [TestMethod]

    public void DateAddedExtremeMax()

    {

        //create an instance of the class we want to create

        clsStaff AnStaff = new clsStaff();

        //string variable to store any error message

        String Error = "";

        //create a variable to store the test date data

        DateTime TestDate;

        //set the date totodays date

        TestDate = DateTime.Now.Date;

        //change the date to whatever the date is plus 100 years

        TestDate = TestDate.AddYears(100);

        //convert the date variable to a string variable

        string DateAdded = TestDate.ToString();

        //invoke the method

        Error = AnStaff.Valid(FirstName, LastName, DateAdded, Salary);

        //test to see that the result is correct

        Assert.AreNotEqual(Error, "");

    }





    [TestMethod]

    public void DateAddedInvalidData()

    {

        //create an instance of the class we want to create

        clsStaff AnStaff = new clsStaff();

        //string variable to store any error message

        String Error = "";

        //create som etest date to pass the method

        string FirstName = "Matthew";

        string LastName = "Smith";

        string Salary = 30000.ToString();

            //set the DateAdded to a non date value

            string DateAdded = "this is not a date value";

        //invoke the method

        Error = AnStaff.Valid(FirstName, LastName, DateAdded,  Salary);

        //test to see that the result is correct

        Assert.AreNotEqual(Error, "");

    }




    [TestMethod]

    public void SalaryExtremeMin()

    {

        //create an instance of the class we want to create

        clsStaff AnStaff = new clsStaff();

        //string variable to store any error message

        String Error = "";

        //create some test data to pass to the method

        string Salary = "";

        //invoke the method

        Error = AnStaff.Valid(FirstName, LastName,  DateAdded,Salary);

        //test to see that the result is correct

        Assert.AreNotEqual(Error, "");

    }







    [TestMethod]

    public void SalaryInvalidData()

    {

        //create an instance of the class we want to create

        clsStaff AnStaff = new clsStaff();

        //string variable to store any error message

        String Error = "";

        //create som etest date to pass the method

        string FirstName = "Matthew";

        string LastName = "Smith";

        string DateAdded = "01/05/2000";

            //set the DateAdded to a non date value

            string Salary = "this is not a number value";

        //invoke the method

        Error = AnStaff.Valid(FirstName, LastName,DateAdded, Salary);

        //test to see that the result is correct

        Assert.AreNotEqual(Error, "");

    }


}
}
