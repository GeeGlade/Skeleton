<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 751px">
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStaffList" runat="server" Height="501px" Width="498px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Label ID="lblEnterName" runat="server" Text="Enter your first name"></asp:Label>
        <asp:TextBox ID="txtEnterName" runat="server" style="margin-left: 10px"></asp:TextBox>
        <p>
            <asp:Button ID="btnApply" runat="server" OnClick="Button1_Click" style="margin-bottom: 0px" Text="Apply" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="margin-left: 11px" Text="Clear" />
        </p>
        <asp:Label ID="lblError1" runat="server"></asp:Label>
    </form>
</body>
</html>
