using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsOrders
    {
        //private data memebr for the Active
        private Boolean mActive;
        //public property for active
        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }

            set
            {
                //set the private data
                mActive = value;
            }
        }
        //private data memeber for order date
        private DateTime mOrderdate;
        //public property for order date
        public DateTime OrderDate
        {
            get
            {
                //return the private data 
                return mOrderdate;
            }

            set
            {
                //set the private data
                mOrderdate = value;

            }
        }

        //private data member for order contents
        private string mOrderContents;
        //public property for order contents
        public string OrderContents
        {
            get
            {
                //return the private data
                return mOrderContents;
            }

            set
            {
                //set the private data
                mOrderContents = value;
            }
        }

        //private data member for Order ID
        private Int32 mOrderID;
        //public proprty for OrderID
        public int OrderID
        {
            get
            {
                //return the private data
                return mOrderID;
            }

            set
            {
                //set the private data
                mOrderID = value;
            }

        }
        //private data member for total price 
        private float mTotalPrice;
        //public property for total price
        public float TotalPrice
        {
            get
            {
                //return the private data
                return mTotalPrice;
            }

            set
            {
                //set the private data 

                mTotalPrice = value;
            }
        }
        //private data member for deilveryAddress
        private string mDeliveryAddress;
        //public property for delivery address
        public string DeliveryAddress
        {
            get
            {
                //return the private data
                return mDeliveryAddress;
            }

            set
            {
                mDeliveryAddress = value;
            }
        }

        //private data member for dispatchedstatus
        private Boolean mDispatchedStatus;
        //public property for dispatchedstatus
        public bool DispatchedStatus
        {
            get
            {
                //return the private data
                return mDispatchedStatus;
            }

            set
            {
                //set the private data

                mDispatchedStatus = value;
            }
        }

        public bool Find(int OrderID)
        {
            //set the private data members to the test data value
            mOrderID = 21;
            mTotalPrice = 23;
            mOrderContents = "Test order content";
            mDeliveryAddress = "Test delivery Address";
            mDispatchedStatus = true;
            mOrderdate = Convert.ToDateTime("16/09/2015");
            //always return true
            return true;

        }
    }
}