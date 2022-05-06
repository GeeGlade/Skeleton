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
        //capture the firstname 
        string FirstName = txtFirstName.Text;
        //capture the lastname
        string LastName = txtLastName.Text;
        //capture DateAdded
        string DateAdded = txtDateAdded.Text;
        //capture the salary
        string Salary = txtSalary.Text;
        //variable to store error messages
        string Error = "";
        //validate the date
        Error = AnStaff.Valid(FirstName, LastName, DateAdded, Salary);

        if (Error == "")
        {
            AnStaff.FirstName =FirstName;
            AnStaff.LastName = LastName;
            AnStaff.DateAdded = Convert.ToDateTime(DateAdded);
            AnStaff.Salary = Convert.ToInt32(Salary);
            AnStaff.Employed = chkEmployed.Checked;
            clsStaffCollection StaffList = new clsStaffCollection();
            StaffList.ThisStaff = AnStaff;
            StaffList.Add();
            Response.Redirect("StaffViewer.aspx");
        }

        else
        {
            //display the error
            lblError.Text = Error;
        }

       

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