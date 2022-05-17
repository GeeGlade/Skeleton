using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        private Int32 mOrderID;
        public Int32 OrderID
        {

            get
            {

                return mOrderID;
            }
            set
            {
                mOrderID = value;
            }
        }
        private DateTime mOrderDate;
        public DateTime OrderDate
        {

            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
            }
        }
        private Boolean mActive;
        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }


        private string mOrdercontents;
        public string OrderContents
        {
            get
            {
                return mOrdercontents;
            }

            set
            {
                mOrdercontents = value;
            }
        }

        private float mTotalPrice;
        public float TotalPrice
        {
            get
            {
                return mTotalPrice;
            }

            set
            {
                mTotalPrice = value;
            }
        }

        private string mDeliveryAddress;

        public string DeliveryAddress
        {
            get
            {
                return mDeliveryAddress;
            }
            set
            {
                mDeliveryAddress = value;
            }
        }

        public bool Find(int orderID)
        {
            mOrderID = 21;
            mOrderDate = Convert.ToDateTime("16/9/2015");
            mActive = true;
            mOrdercontents = " Test content";
            mTotalPrice = (float)Convert.ToInt32("34.34");
            mDeliveryAddress = " Test delivery address";
            return true;
        }

    }
}