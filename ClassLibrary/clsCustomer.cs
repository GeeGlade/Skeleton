using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private bool mOver18;
        private int mCustomerID;
        private string mCustomerUsername;
        private string mCustomerPassword;
        private DateTime mDateAdded;
        private string mBillingShippingAddress;



        public bool Over18 { 
            get {
                return mOver18;
            }
            set
            {
                mOver18 = value;
            }
        }

        public int CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }
        public string CustomerUsername
        {
            get
            {
                return mCustomerUsername;
            }
            set
            {
                mCustomerUsername = value;
            }
        }
        public string CustomerPassword
        {
            get
            {
                return mCustomerPassword;
            }
            set
            {
                mCustomerPassword = value;
            }
        }
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }
        public string BillingShippingAddress
        {
            get
            {
                return mBillingShippingAddress;
            }
            set
            {
                mBillingShippingAddress = value;
            }
        }

        public bool Find(Int32 CustomerID)
        {
            mOver18 = true;
            mCustomerID = 10;
            mCustomerUsername = "test";
            mCustomerPassword = "testpass";
            mDateAdded = Convert.ToDateTime("16/9/2015");
            mBillingShippingAddress = "123 test street";



            return true;
        }
    }
}