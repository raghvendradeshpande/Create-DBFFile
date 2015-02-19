<%@ Page Title="About Us" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="About.aspx.cs" Inherits="EnitityFramework.About" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:TextBox ID="TextBox2"
        runat="server"></asp:TextBox>
        
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><asp:TextBox ID="TextBox4"
        runat="server"></asp:TextBox><br />
    <asp:Button ID="btnSave" runat="server" Text="Save" onclick="btnSave_Click" />
    <h2>
        About
    </h2>
    <p>
        Put content here.
    </p>
</asp:Content>
