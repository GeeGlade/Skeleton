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
        clsStaff AnStaff = new clsStaff();
        AnStaff = (clsStaff)Session["AnStaff"];
        Response.Write(AnStaff.StaffID + "\n");
        Response.Write(AnStaff.FirstName + "\n");
        Response.Write(AnStaff.LastName + "\n");
        Response.Write(AnStaff.DateAdded + "\n");
        Response.Write(AnStaff.Salary + "\n");
        Response.Write(AnStaff.Employed);
    }
}