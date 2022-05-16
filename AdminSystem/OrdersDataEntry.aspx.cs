using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // creates a new instance of clsOrders
       clsOrders AnOrder = new clsOrders();
        string OrderID = txtOrderID.Text;
        //Capture the all of the inputs
      AnOrder.OrderContents = txtOrderContents.Text;
      AnOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
        AnOrder.TotalPrice = (float)Convert.ToDecimal(txtTotalPrice.Text);
      AnOrder.DeliveryAddress = txtDeliveryAddress.Text;
        // store the address in the session object
        Session["AnOrder"] = AnOrder;
        
        //navigate to the viewer page
        Response.Redirect("OrdersViewer.aspx");
    }

    
}