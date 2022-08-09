<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblOrderID" runat="server" Text="Order ID" width="105px"></asp:Label>
        <asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
        <div>
            <asp:Label ID="lblOrderContents" runat="server" Text="Order Content" width="105px"></asp:Label>
            <asp:TextBox ID="txtOrderContent" runat="server" OnTextChanged="txtOrderContents_TextChanged"></asp:TextBox>
        </div>
        <asp:Label ID="lblOrderDate" runat="server" Text="Order Date" width="105px"></asp:Label>
        <asp:TextBox ID="txtOrderDate" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblTotalPrice" runat="server" Text="Total Price" width="105px"></asp:Label>
            <asp:TextBox ID="txtTotalPrice" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblDeliveryAddress" runat="server" Text="Delivery Address"></asp:Label>
        <asp:TextBox ID="txtDeliveryAddress" runat="server" EnableTheming="True"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkDispatchedStatus" runat="server" Text="Dispatched" />
        </p>
        <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
