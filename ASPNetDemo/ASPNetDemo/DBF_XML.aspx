<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DBF_XML.aspx.cs" Inherits="ASPNetDemo.DBF_XML" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <label>Select XML File</label>  <asp:FileUpload ID="btnFileUpload" runat="server" /> <br />
        
        <asp:Button ID="btnXMLUpload" runat="server"
            Text="Upload" onclick="btnXMLUpload_Click" />
            <div id="uploadstatus" runat="server"></div>
    </div>
    </form>
</body>
</html>
