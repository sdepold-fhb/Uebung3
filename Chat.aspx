<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Chat.aspx.cs" Inherits="Chat" %>
<%@ Register Namespace="System.Web.UI.MobileControls" TagPrefix="mobile" Assembly="System.Web.Mobile" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>WTF!</title>
</head>
<body>
    <mobile:Form id="form_chat" runat="server" EnableViewState="False">
        <mobile:Label ID="m_labelWelcome" Runat="server"></mobile:Label>
        <br />

        chat stuff goes here!

        <mobile:Label id="m_labelResult" Runat="server"></mobile:Label>
        <mobile:Command ID="m_butLogout" Runat="server" OnClick="m_butLogout_Click">Logout</mobile:Command>
    </mobile:Form>
</body>
</html>
