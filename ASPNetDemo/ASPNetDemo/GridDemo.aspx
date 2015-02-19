<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="GridDemo.aspx.cs" Inherits="ASPNetDemo.GridDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:GridView ID="GridView1" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White"
    runat="server" AutoGenerateColumns="false" OnRowDataBound="OnRowDataBound"
    OnSelectedIndexChanged="OnSelectedIndexChanged">
    <Columns>
        <asp:BoundField DataField="Name" HeaderText="Name" ItemStyle-Width="150" />
        <asp:BoundField DataField="Country" HeaderText="Country" ItemStyle-Width="150" />
    </Columns>
</asp:GridView>
    </form>
</body>
</html>
