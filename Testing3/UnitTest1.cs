using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
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

            String FirstName = "Matthew";

            Found = AnStaff.Find(FirstName);

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void FirstNameFound()
        {

            clsStaff AnStaff = new clsStaff();

            Boolean Found = false;

            Boolean OK = true;

            String FirstName = "Jimmy";

            Found = AnStaff.Find(FirstName);

            if (AnStaff.FirstName != "Jimmy")
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

            String FirstName = "Jimmy";

            Found = AnStaff.Find(FirstName);

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

            String FirstName = "Jimmy";

            Found = AnStaff.Find(FirstName);

            if (AnStaff.DateAdded != Convert.ToDateTime("01/05/2000"))
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

            String FirstName = "Jimmy";

            Found = AnStaff.Find(FirstName);

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

            String FirstName = "Jimmy";

            Found = AnStaff.Find(FirstName);

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

            String FirstName = "Jimmy";

            Found = AnStaff.Find(FirstName);

            if (AnStaff.StaffID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
