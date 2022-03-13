using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public bool Over18 { get; set; }
        public int CustomerID { get; set; }
        public string CustomerUsername { get; set; }
        public string CustomerPassword { get; set; }
        public DateTime DateAdded { get; set; }
        public string BillingShippingAddress { get; set; }
    }
}