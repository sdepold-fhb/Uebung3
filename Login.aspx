<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Login.aspx.cs" Inherits="Login" %>
<%@ Register Namespace="System.Web.UI.MobileControls" TagPrefix="mobile" Assembly="System.Web.Mobile" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server"></head>
<body>
    <mobile:Form id="form_login" runat="server" EnableViewState="False">
        <mobile:Label ID="test" runat="server" EnableViewState="False">bla</mobile:Label>
        <mobile:Label ID="m_labelError" Runat="server"></mobile:Label>
        <mobile:Label id="m_labelName" Runat="server">Name</mobile:Label>
        <mobile:TextBox ID="m_tbName" Runat="server"></mobile:TextBox>
        <mobile:Label id="m_labelPassword" Runat="server">Password</mobile:Label>
        <mobile:TextBox Password="True" ID="m_tbPassword" Runat="server"></mobile:TextBox>
        <mobile:Command ID="m_butLogin" Runat="server" OnClick="m_butLogin_Click">Login</mobile:Command>
    </mobile:Form>
</body>
</html>
