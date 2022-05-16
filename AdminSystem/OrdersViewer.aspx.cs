using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrders AnOrder = new clsOrders();
        //get the data from the session object
        AnOrder = (clsOrders)Session["AnOrder"];
        //display the input on the page
        Response.Write(AnOrder.OrderID + "\n");
        Response.Write(AnOrder.OrderContents + "\n");
        Response.Write(AnOrder.OrderDate + "\n");
        Response.Write(AnOrder.TotalPrice + "\n");
        Response.Write(AnOrder.DeliveryAddress + "\n");
    }
}