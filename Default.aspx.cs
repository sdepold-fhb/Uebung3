using System;
using System.Web.UI.MobileControls;
using de.fhb.mobileSysteme.Uebung3.Manager;
using de.fhb.mobileSysteme.Uebung3.Entities;

public partial class Default : MobilePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
            RedirectToMobilePage("Chat.aspx");
    }

}