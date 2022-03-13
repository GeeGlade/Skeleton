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
        public void ActivePropertOk()
        {
            clsStaff AnStaff = new clsStaff();

            Boolean TestData = true;

            AnStaff.Active = TestData;

            Assert.AreEqual(AnStaff.Active, TestData);
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
        public void DOBOk()
        {
            clsStaff AnStaff = new clsStaff();

            String TestData = "23/04/2000";

            AnStaff.DOB = TestData;

            Assert.AreEqual(AnStaff.DOB, TestData);
        }

        [TestMethod]
        public void UsernameOk()
        {
            clsStaff AnStaff = new clsStaff();

            String TestData = "User123";

            AnStaff.Username = TestData;

            Assert.AreEqual(AnStaff.Username, TestData);
        }

        [TestMethod]
        public void PasswordOk()
        {
            clsStaff AnStaff = new clsStaff();

            String TestData = "Password234";

            AnStaff.Password = TestData;

            Assert.AreEqual(AnStaff.Password, TestData);
        }

        [TestMethod]
        public void GenderOk()
        {
            clsStaff AnStaff = new clsStaff();

            String TestData = "M";

            AnStaff.Gender = TestData;

            Assert.AreEqual(AnStaff.Gender, TestData);
        }

        [TestMethod]
        public void SalaryOk()
        {
            clsStaff AnStaff = new clsStaff();

            float TestData = 20000;

            AnStaff.Salary = TestData;

            Assert.AreEqual(AnStaff.Salary, TestData);
        }
    }
}
