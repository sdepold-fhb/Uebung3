<%@ Application Language="C#" %>
<%@ Import Namespace="System.Collections.Generic" %>
<%@ Import Namespace="System.IO" %>
<%@ Import Namespace="de.fhb.mobileSysteme.Uebung3.Manager" %>
<script RunAt="server">
    protected String AppDataPath = AppDomain.CurrentDomain.BaseDirectory + "/App_Data/";

    void Application_Start(object sender, EventArgs e)
    {
        ConfigureLogging();
        UserManager.Init(AppDataPath + "users.xml");

        //first initialization
        if (!UserManager.LoadUsers())
        {
            UserManager.AddUser("koerner", "koerner");
            UserManager.AddUser("depold", "depold");
            UserManager.AddUser("koerner", "koerner");
        }

        UserManager.LoadUsers();
    }

    protected void ConfigureLogging()
    {
        string logFile = HttpContext.Current.Request.PhysicalApplicationPath + "log4net.config";
        if (System.IO.File.Exists(logFile))
        {
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new System.IO.FileInfo(logFile));
        }
    }

    
    void Application_End(object sender, EventArgs e)
    {
        //  Code, der beim Beenden der Anwendung ausgeführt wird.

    }

    void Application_Error(object sender, EventArgs e)
    {
        // Code, der bei einem nicht behandelten Fehler ausgeführt wird.


    }

    void Session_Start(object sender, EventArgs e)
    {
        // Code, der beim Starten einer neuen Sitzung ausgeführt wird.



    }

    void Session_End(object sender, EventArgs e)
    {
        // Code, der am Ende einer Sitzung ausgeführt wird. 
        // Hinweis: Das Session_End-Ereignis wird nur ausgelöst, wenn der sessionstate-Modus
        // in der Datei "Web.config" auf InProc festgelegt wird. Wenn der Sitzungsmodus auf StateServer 
        // oder SQLServer festgelegt wird, wird das Ereignis nicht ausgelöst.


    }
       
</script>
