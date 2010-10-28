using System;
using System.Web.UI.MobileControls;
using de.fhb.mobileSysteme.Uebung3.Manager;
using de.fhb.mobileSysteme.Uebung3.Entities;

public partial class Login : MobilePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["login"] != null)
            RedirectToMobilePage("Chat.aspx");
    }

    protected void m_butLogin_Click(object sender, EventArgs e)
    {
        User user = new User(m_tbName.Text, m_tbPassword.Text);

        if (UserManager.Authenticate(user))
        {
            Session["login"] = user;
            RedirectToMobilePage("Chat.aspx");
        }
        else
        {
            Session["login"] = null;
            m_labelError.Text = "Wrong name and/or password!";
        }
    }
}