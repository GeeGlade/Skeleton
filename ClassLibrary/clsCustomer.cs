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
            //Create insatnce of clsDataConnection class
            clsDataConnection DB = new clsDataConnection();
            //Add parameter of ID to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //Execute stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //If database is found
            if(DB.Count == 1)
            {
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mCustomerUsername = Convert.ToString(DB.DataTable.Rows[0]["CustomerUsername"]);
                mCustomerPassword = Convert.ToString(DB.DataTable.Rows[0]["CustomerPassword"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mOver18 = Convert.ToBoolean(DB.DataTable.Rows[0]["Over18"]);
                mBillingShippingAddress = Convert.ToString(DB.DataTable.Rows[0]["BillingShippingAddress"]);

                return true;
            }
            //If database is not found
            return false;
        }

        public string Valid(string customerUsername, string customerPassword, string dateAdded, string billingShippingAddress)
        {
            string Error = "";


            if(customerUsername.Length == 0)
            {
                Error += "Username must not be empty. ";
            }

            if (customerUsername.Length > 20)
            {
                Error += "Username must be at most 20 characters. ";
            }

            if (customerPassword.Length == 0)
            {
                Error += "Password must not be empty. ";
            }

            if (customerPassword.Length > 20)
            {
                Error += "Password must be at most 20 characters. ";
            }

            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTime  DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error += "Date cannot be in the past. ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error += "Date cannot be in the future. ";
                }
            }
            catch
            {
                //record the error
                Error += "Invalid date. ";
            }

            if (billingShippingAddress.Length == 0)
            {
                Error += "Billing Shipping Address must not be empty. ";
            }

            if (billingShippingAddress.Length > 50)
            {
                Error += "Billing Shipping Address must be at most 50 characters. ";
            }

            return Error;
        }
    }
}