<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStaffID" runat="server" Text="Staff ID" width="67px"></asp:Label>
            <asp:TextBox ID="txtStaffID" runat="server" style="margin-left: 15px"></asp:TextBox>
        </div>
        <asp:Label ID="lblFirstName" runat="server" Text="First Name" width="67px"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblDOB" runat="server" Text="DOB" width="67px"></asp:Label>
        <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblSalary" runat="server" Text="Salary" width="67px"></asp:Label>
            <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkEmployed" runat="server" Text="Employed" />
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="margin-left: 7px" Text="Cancel" />
    </form>
</body>
</html>
