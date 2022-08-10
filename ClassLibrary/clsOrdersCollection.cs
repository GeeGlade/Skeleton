using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    //constructro for teh class
  
    public class clsOrdersCollection
        
    {
        //private data member for the list
        List<clsOrders> mOrdersList = new List<clsOrders>();

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

        public clsOrders ThisOrders { get; set; }

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

    }
}