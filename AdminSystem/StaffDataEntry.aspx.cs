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
        clsStaff AnStaff = new clsStaff();

        AnStaff.FirstName = txtFirstName.Text;
        AnStaff.LastName = txtLastName.Text;
        AnStaff.DateAdded = Convert.ToDateTime (txtDateAdded.Text);
        AnStaff.Employed = chkEmployed.Checked;
        //AnStaff.StaffID = Convert.ToInt32(txtStaffID.Text);

        Session["AnStaff"] = AnStaff;

        Response.Redirect("StaffViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //creates an instnace of the staff class
        clsStaff AnStaff = new clsStaff();
        //variable to store primary key
        Int32 StaffID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key ententerd by the user 
        StaffID = Convert.ToInt32(txtStaffID.Text);
        //find the record 
        Found = AnStaff.Find(StaffID);
        //if found
        if (Found == true)
        {
            //display the values if the properties of the form 
            txtFirstName.Text = AnStaff.FirstName;
            txtLastName.Text = AnStaff.LastName;
            txtDateAdded.Text = AnStaff.DateAdded.ToString();
            txtSalary.Text = AnStaff.Salary.ToString();

        }
    }
}