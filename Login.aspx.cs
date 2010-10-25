using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.MobileControls;

public partial class Login : MobilePage
{
    protected String LOGIN_PATH = AppDomain.CurrentDomain.BaseDirectory + "/App_Data/logins.txt";

    protected void Page_Load(object sender, EventArgs e)
    {
        test.Text += (String)Session["login"];
        if (Session["login"] != null)
            RedirectToMobilePage("Chat.aspx");
    }

    protected String[] Get_Logins()
    {
        StreamReader streamReader = new StreamReader(LOGIN_PATH);
        String logins = streamReader.ReadToEnd();
        streamReader.Close();

        return logins.Split(new string[] { "\r\n" }, StringSplitOptions.None);
    }

    protected Boolean Does_Login_Exist(String name, String password)
    {
        Boolean result = false;
        String[] logins = Get_Logins();

        foreach (String login in logins)
        {
            String[] name_pw_split = login.Split(new string[] { ":" }, StringSplitOptions.None);
            String saved_name = name_pw_split.First();
            String saved_password = name_pw_split.Last();

            if (name == saved_name && password == saved_password)
            {
                result = true;
                break;
            }
        }

        return result;
    }

    protected void m_butLogin_Click(object sender, EventArgs e)
    {
        if (Does_Login_Exist(m_tbName.Text, m_tbPassword.Text))
        {
            Session["login"] = m_tbName.Text;
            RedirectToMobilePage("Chat.aspx");
        }
        else
            m_labelError.Text = "There is no registered user " + m_tbName.Text;
    }
}