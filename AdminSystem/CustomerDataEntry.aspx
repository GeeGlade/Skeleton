<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID" width="147px"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCustomerUsername" runat="server" Text="Customer Username" width="147px"></asp:Label>
            <asp:TextBox ID="txtCustomerUsername" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCustomerPassword" runat="server" Text="Customer Password" width="147px"></asp:Label>
            <asp:TextBox ID="txtCustomerPassword" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblDateAdded" runat="server" Text="Date Added" width="147px"></asp:Label>
            <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCustomerBSA" runat="server" Text="Billing Shipping Address"></asp:Label>
            <asp:TextBox ID="txtBSA" runat="server"></asp:TextBox>
            <br />
            <asp:CheckBox ID="chkOver18" runat="server" Text="Over 18" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="Ok" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
