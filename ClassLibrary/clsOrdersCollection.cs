using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    //constructro for teh class
  
    public class clsOrdersCollection
        
    {
        //private data member for the list
        List<clsOrders> mOrdersList = new List<clsOrders>();
        clsOrders mThisOrders = new clsOrders();

        public List<clsOrders> OrdersList
        {
            get
            {
                //return the private data
                return mOrdersList;
            }
            set
            {
                //set the private data
                mOrdersList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrdersList.Count;
            }

            set
            {

            }
        }

        public clsOrders ThisOrders
        {
            get
            {
                //return the private data
                return mThisOrders;
            }

            set
            {
                //set the private data
                mThisOrders = value;

            }
        }
        public clsOrdersCollection()
        {
            //var for the index 
            Int32 Index = 0;
            //var tos tore the record count
            Int32 RecordCount = 0;
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procdedure
            DB.Execute("sproc_tblOrders_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //whil;e there are records to process
            while ( Index < RecordCount)
            {
                //create a blank address
                clsOrders AnOrders = new clsOrders();
                //read in the fields from the current record
                AnOrders.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrders.OrderContent = Convert.ToString(DB.DataTable.Rows[Index]["Ordercontent"]);
                AnOrders.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["Orderdate"]);
                AnOrders.TotalPrice = Convert.ToInt32(DB.DataTable.Rows[Index]["TotalPrice"]);
                AnOrders.DispatchedStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["DispatchedStatus"]);
                AnOrders.DeliveryAddress = Convert.ToString(DB.DataTable.Rows[Index]["DeliveryAddress"]);
                //add the record to the private data member
                mOrdersList.Add(AnOrders);
                //poijnt at thge next record
                Index++;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisOrders
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderContent", mThisOrders.OrderContent);
            DB.AddParameter("@OrderDate", mThisOrders.OrderDate);
            DB.AddParameter("@DispatchedStatus", mThisOrders.DispatchedStatus);
            DB.AddParameter("@TotalPrice", mThisOrders.TotalPrice);
            DB.AddParameter("@DeliveryAddress", mThisOrders.DeliveryAddress);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrders_Insert");

        }

        public void Update()
        {
            //update am existing record based on the values of thisOrders
            //connect to the database
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stored procedure
            DB.AddParameter("@OrderID", mThisOrders.OrderID);
            DB.AddParameter("@OrderContent", mThisOrders.OrderContent);
            DB.AddParameter("@OrderDate", mThisOrders.OrderDate);
            DB.AddParameter("@DispatchedStatus", mThisOrders.DispatchedStatus);
            DB.AddParameter("@TotalPrice", mThisOrders.TotalPrice);
            DB.AddParameter("@DeliveryAddress", mThisOrders.DeliveryAddress);
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_Update");
        }
    }
}