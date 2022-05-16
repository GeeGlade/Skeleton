<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 477px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" Height="284px" Width="310px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        </p>
        <p>
            <asp:Label ID="lblFilter" runat="server" Text="Filter Username by: "></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
        </p>
        
        <p>
            <asp:Button ID="btnApply" runat="server" Text="Apply" OnClick="btnApply_Click" />
            <asp:Button ID="btnClear" runat="server" style="margin-bottom: 0px" Text="Clear" OnClick="btnClear_Click" />
        </p>

        <asp:Label ID="lblError" runat="server"></asp:Label>
    </form>
</body>
</html>
