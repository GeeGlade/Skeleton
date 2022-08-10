using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page

{

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // creates a new instance of clsOrders
        clsOrders AnOrder = new clsOrders();
        //capture the order content
        string OrderContent = txtOrderContent.Text;
        //capture total price
        string TotalPrice = txtTotalPrice.Text;
        //capture orderdate
        string OrderDate = txtOrderDate.Text;
        //capture the delivery address
        string DeliveryAddress = txtDeliveryAddress.Text;
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(OrderContent, OrderDate, DeliveryAddress, TotalPrice);
        if (Error == "")
        {
            //capture the order content
            AnOrder.OrderContent = OrderContent;
            //capture the totalPrice
            AnOrder.TotalPrice = Convert.ToInt32(TotalPrice);
            //capture the date ordered
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            //capture the delivery address
            AnOrder.DeliveryAddress = DeliveryAddress;
            //capture dispatched status
            AnOrder.DispatchedStatus = chkDispatchedStatus.Checked;
            //create a new instance of the order collection
            clsOrdersCollection OrdersList = new clsOrdersCollection();
            //set ThisOrders property
            OrdersList.ThisOrders = AnOrder;
            //add the new record
            OrdersList.Add();
            //redirect back to listpage
            Response.Redirect("OrdersList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    
    
     
    }



    protected void txtOrderContents_TextChanged(object sender, EventArgs e)
    {

    }

    
}