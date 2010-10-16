using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.MobileControls;

public partial class _Default : MobilePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void m_butSubmit_Click(object sender, EventArgs e)
    {
        m_labelResult.Text = "Hallo " + m_tbName.Text;
        ActiveForm = form2;
    }
}