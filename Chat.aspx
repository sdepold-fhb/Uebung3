<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Chat.aspx.cs" Inherits="Chat" %>

<%@ Register Namespace="System.Web.UI.MobileControls" TagPrefix="mobile" Assembly="System.Web.Mobile" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
</head>
<body>
    <mobile:Form ID="form_chat" Runat="server" EnableViewState="True">
        <b>CHAT</b> -
<mobile:Label ID="m_labelWelcome" Runat="server" BreakAfter="False">
        </mobile:Label>
<br />
        Text:
<mobile:TextBox Runat="server" ID="m_tbMessage" BreakAfter="False">
        </mobile:TextBox>
        <mobile:Command ID="m_butSubmit" Runat="server" OnClick="m_butSubmit_Click" >Submit/Refresh
        </mobile:Command>
        <mobile:List ID="m_listMessages" Runat="server">
        </mobile:List>
        
        <mobile:Command ID="m_butLogout" Runat="server" OnClick="m_butLogout_Click">Logout</mobile:Command>
    </mobile:Form>
</body>
</html>
