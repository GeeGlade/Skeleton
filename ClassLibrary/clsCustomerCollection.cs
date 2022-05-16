using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();

        public clsCustomerCollection()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblCustomer_SelectAll");

            PopulateArray(DB);
        }

        

        public List<clsCustomer> CustomerList { 
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }
        public clsCustomer ThisCustomer {
            get
            {
                return mThisCustomer;
            }

            set
            {
                mThisCustomer = value;
            }

        }
        public int Count { 
            get
            {
                return mCustomerList.Count;
            }
            set
            {

            }
        }

        public int Add()
        {
            //Adds mThisCustomer to database
            clsDataConnection DB = new clsDataConnection();
            //Parameters for stored procedure
            DB.AddParameter("CustomerUsername", mThisCustomer.CustomerUsername);
            DB.AddParameter("CustomerPassword", mThisCustomer.CustomerPassword);
            DB.AddParameter("DateAdded", mThisCustomer.DateAdded);
            DB.AddParameter("BillingShippingAddress", mThisCustomer.BillingShippingAddress);
            DB.AddParameter("Over18", mThisCustomer.Over18);
            //Returns primary key and adds to table
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            //Updates data in database with new values from mThisCustomer
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("CustomerUsername", mThisCustomer.CustomerUsername);
            DB.AddParameter("CustomerPassword", mThisCustomer.CustomerPassword);
            DB.AddParameter("DateAdded", mThisCustomer.DateAdded);
            DB.AddParameter("BillingShippingAddress", mThisCustomer.BillingShippingAddress);
            DB.AddParameter("Over18", mThisCustomer.Over18);

            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            //Deletes record pointed to by ThisCustomer
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("CustomerID", mThisCustomer.CustomerID);

            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void FilterByUsername(string filter)
        {
            //Filters records based on filter parameter
            clsDataConnection DB = new clsDataConnection();
            //Adds filter paramater to databse
            DB.AddParameter("@CustomerUsername", filter);
            //Execute stored procedure filter
            DB.Execute("sproc_tblCustomer_FilterByUsername");
            //Fills array with data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;

            RecordCount = DB.Count;

            mCustomerList = new List<clsCustomer>();

            while (Index < RecordCount)
            {
                clsCustomer ACustomer = new clsCustomer();

                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.CustomerUsername = Convert.ToString(DB.DataTable.Rows[Index]["CustomerUsername"]);
                ACustomer.CustomerPassword = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPassword"]);
                ACustomer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                ACustomer.BillingShippingAddress = Convert.ToString(DB.DataTable.Rows[Index]["BillingShippingAddress"]);
                ACustomer.Over18 = Convert.ToBoolean(DB.DataTable.Rows[Index]["Over18"]);

                mCustomerList.Add(ACustomer);

                Index++;
            }
        }
    }
}