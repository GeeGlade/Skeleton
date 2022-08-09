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
        private string mOrderContent;
        //public property for order contents
        public string OrderContent
        {
            get
            {
                //return the private data
                return mOrderContent;
            }

            set
            {
                //set the private data
                mOrderContent = value;
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
            //creates an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Order ID to search for
            DB.AddParameter("@OrderID", OrderID);
            //execute the store procedure
            DB.Execute("sproc_tblOrders_FilterByOrderID");
            //of one record is found (there should either one or zero)
            if( DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mTotalPrice = Convert.ToInt32(DB.DataTable.Rows[0]["TotalPrice"]);
                mOrderContent = Convert.ToString(DB.DataTable.Rows[0]["OrderContent"]);
                mDeliveryAddress = Convert.ToString(DB.DataTable.Rows[0]["DeliveryAddress"]);
                mDispatchedStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["DispatchedStatus"]);
                mOrderdate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                //return that everything worked OK
                return true;
            }
            //if mo record was found
            else
            {
                //return false indicating a problem
                return false;
            }

        }

        public string Valid(string orderContent, string orderDate, string deliveryAddress, string totalPrice)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporay variable to store data values
            DateTime DateTemp;
            //create a temporay variable to store data values
            Int32 TotalPriceTemp;
            //if the ordercontent is blank

            if (orderContent.Length == 0)
            {
                //record the error
                Error = Error + "The order content may not be blank; ";
            }
            //if the order content greater than 50
            if(orderContent.Length >50)
            {
                //record the Error
                Error = Error + "The Order content can't be greater than 50 characters";
            }
            try
            {


                //copy the orderDate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(orderDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date can not be in the past: ";
                }
                //check to see if the date is greater than todays date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date can not be in the future";
                }
               
            }

            catch
            {
                //record the error
                Error = Error + "The date was not a valid date: ";
            }

            if(deliveryAddress.Length ==0)
            {
                //record the error
                Error = Error + "The delivery address can not be blank";
            }
            if (deliveryAddress.Length > 50)
            {
                //record the Error
                Error = Error + "The delivery addresss can't be greater than 50 characters";
            }

            //copying the price to the temporay variable
           
            try
            {
                TotalPriceTemp = Convert.ToInt32(totalPrice);
                if (TotalPriceTemp < 0)
                {
                    Error = Error + "The total price can not be lower than or be £0";
                }
                else
                    Error = Error + "That is not a valid input for total price";
            }
            catch
            {
                Error = Error + "That is not a valid input for total price";
            }

            return Error;
        }

       
    }
}