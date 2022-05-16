using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        public bool Active { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderContents { get; set; }
        public int OrderID { get; set; }
        public float TotalPrice { get; set; }
        public string DeliveryAddress { get; set; }
    }
}