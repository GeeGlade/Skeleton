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

        string CustomerUsername = txtCustomerUsername.Text;
        string CustomerPassword = txtCustomerPassword.Text;
        string DateAdded = txtDateAdded.Text;
        string BillingShippingAddress = txtBSA.Text;



        string Error = ACustomer.Valid(CustomerUsername, CustomerPassword, DateAdded, BillingShippingAddress);

        if(Error == "")
        {
            ACustomer.CustomerUsername = CustomerUsername;
            ACustomer.CustomerPassword = CustomerPassword;
            ACustomer.DateAdded = Convert.ToDateTime(DateAdded);
            ACustomer.BillingShippingAddress = BillingShippingAddress;
            ACustomer.Over18 = chkOver18.Checked;

            Session["ACustomer"] = ACustomer;
            //Navigate to viewer page
            Response.Redirect("CustomerViewer.aspx");
        } else
        {
            lblError.Text = Error;
        }

        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //Create instance of clsCustomer class
        clsCustomer btnCustomer = new clsCustomer();
        //Store primary key
        Int32 CustomerID;
        //Store result of find method
        Boolean Found = false;
        //Get primary key entered by user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //Find record
        Found = btnCustomer.Find(CustomerID);
        if(Found)
        {
            //Add data to form
            txtCustomerUsername.Text = btnCustomer.CustomerUsername;
            txtCustomerPassword.Text = btnCustomer.CustomerPassword;
            txtDateAdded.Text = btnCustomer.DateAdded.ToString();
            txtBSA.Text = btnCustomer.BillingShippingAddress;
            chkOver18.Checked = btnCustomer.Over18;
        }
    }
}