using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.MobileControls;

public partial class Chat : MobilePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["login"] == null)
            RedirectToMobilePage("Login.aspx");
        else
            m_labelWelcome.Text = "Hallo " + Session["login"];
    }

    protected void m_butLogout_Click(object sender, EventArgs e)
    {
        Session.Clear();
        RedirectToMobilePage("Login.aspx");
    }
}