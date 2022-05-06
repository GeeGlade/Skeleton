using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffID = Convert.ToInt32(Session["StaffID"]);
        if (IsPostBack == false)
        {
            if (StaffID != -1)
            {
                DisplayStaff();
            }
        }
    }

    private void DisplayStaff()
    {
        //create an instance of the staff list
        clsStaffCollection StaffBook = new clsStaffCollection();
        //find the record to update
        txtStaffID.Text = StaffBook.ThisStaff.StaffID.ToString();
        txtFirstName.Text = StaffBook.ThisStaff.FirstName;
        txtLastName.Text = StaffBook.ThisStaff.LastName;
        txtDateAdded.Text = StaffBook.ThisStaff.DateAdded.ToString();
        txtSalary.Text = StaffBook.ThisStaff.Salary.ToString();
        chkEmployed.Checked = StaffBook.ThisStaff.Employed;


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
            AnStaff.StaffID = StaffID;
            AnStaff.FirstName = FirstName;
            AnStaff.LastName = LastName;
            AnStaff.DateAdded = Convert.ToDateTime(DateAdded);
            AnStaff.Salary = Convert.ToInt32(Salary);
            AnStaff.Employed = chkEmployed.Checked;
            clsStaffCollection StaffList = new clsStaffCollection();
            
            if (StaffID == -1)
            {
                StaffList.ThisStaff = AnStaff;
                StaffList.Add();
            }

            else
            {
                StaffList.ThisStaff.Find(StaffID);
                StaffList.ThisStaff = AnStaff;
                StaffList.Update();
            }

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