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

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        ACustomer.CustomerUsername = txtCustomerUsername.Text;
        ACustomer.CustomerPassword = txtCustomerPassword.Text;
        //ACustomer.DateAdded = txtDateAdded.Text;
        ACustomer.BillingShippingAddress = txtBSA.Text;
        ACustomer.Over18 = chkOver18.Checked;

        Session["ACustomer"] = ACustomer;
        //Navigate to viewer page
        Response.Redirect("CustomerViewer.aspx");
    }
}