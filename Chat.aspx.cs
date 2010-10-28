using System;
using System.Web.UI.MobileControls;
using de.fhb.mobileSysteme.Uebung3.Entities;
using de.fhb.mobileSysteme.Uebung3.Manager;

public partial class Chat : MobilePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["login"] == null)
            RedirectToMobilePage("Login.aspx");
        else
            m_labelWelcome.Text = "Hallo " + ((User)Session["login"]).Name;

       bindMessageList();
    }

    protected void m_butLogout_Click(object sender, EventArgs e)
    {
        Session["login"] = null;
        RedirectToMobilePage("Login.aspx");
    }

    protected void m_butSubmit_Click(object sender, EventArgs e)
    {
        if (!String.IsNullOrEmpty(m_tbMessage.Text))
        {
            MessageManager.Instance.AddMessage(m_tbMessage.Text, Session["login"] as User);
            m_tbMessage.Text = null;
        }

        bindMessageList();
    }

    protected void m_butRefresh_Click(object sender, EventArgs e)
    {
       bindMessageList();
    }

    private void bindMessageList()
    {
        m_listMessages.DataSource = MessageManager.Instance.GetMessages();
        m_listMessages.DataBind();
    }

}