<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Register Namespace="System.Web.UI.MobileControls" TagPrefix="mobile" Assembly="System.Web.Mobile" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>WTF!</title>
</head>
<body>
    <mobile:Form id="form1" runat="server" EnableViewState="False">
        <mobile:Label id="m_labelName" Runat="server">Name</mobile:Label>
        <mobile:TextBox ID="m_tbName" Runat="server"></mobile:TextBox>
        <mobile:Command ID="m_butSubmit" Runat="server" OnClick="m_butSubmit_Click">Submit</mobile:Command>
    </mobile:Form>
    <mobile:Form id="form2" runat="server" EnableViewState="False">
        <mobile:Label id="m_labelResult" Runat="server"></mobile:Label>
        <mobile:Link ID="m_link" Runat="server" NavigateUrl="#form1">back!</mobile:Link>
    </mobile:Form>
</body>
</html>
