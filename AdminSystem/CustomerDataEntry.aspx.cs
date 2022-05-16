using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if(!IsPostBack && CustomerID != -1)
        {
            DisplayCustomers();
        }
    }

    void DisplayCustomers()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ThisCustomer.Find(CustomerID);
        txtCustomerID.Text = Customers.ThisCustomer.CustomerID.ToString();
        txtCustomerUsername.Text = Customers.ThisCustomer.CustomerUsername.ToString();
        txtCustomerPassword.Text = Customers.ThisCustomer.CustomerPassword.ToString();
        txtDateAdded.Text = Customers.ThisCustomer.DateAdded.ToString();
        txtBSA.Text = Customers.ThisCustomer.BillingShippingAddress.ToString();
        chkOver18.Checked = Customers.ThisCustomer.Over18;
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
            ACustomer.CustomerID = CustomerID;
            ACustomer.CustomerUsername = CustomerUsername;
            ACustomer.CustomerPassword = CustomerPassword;
            ACustomer.DateAdded = Convert.ToDateTime(DateAdded);
            ACustomer.BillingShippingAddress = BillingShippingAddress;
            ACustomer.Over18 = chkOver18.Checked;

            //New instance of CustomerList to add to
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            if (CustomerID == -1)
            { 
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Add();
            }
            else
            {
                CustomerList.ThisCustomer.Find(CustomerID);
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Update();
            }

            //Navigate to list page
            Response.Redirect("CustomerList.aspx");
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