using System;
using System.Collections.Generic;
using System.Text;

namespace ANHAdmin
{
    public static class clsDBStrings
    {
        public static string maindbcon = "Server=" + System.Configuration.ConfigurationManager.AppSettings["mainhost"] + ";Uid=" + System.Configuration.ConfigurationManager.AppSettings["mainuser"] + ";Pwd=" + System.Configuration.ConfigurationManager.AppSettings["mainpassword"] + ";Database=" + System.Configuration.ConfigurationManager.AppSettings["maindatabase"] + ";";

        public static string configdbcon = "Server=" + System.Configuration.ConfigurationManager.AppSettings["confighost"] + ";Uid=" + System.Configuration.ConfigurationManager.AppSettings["configuser"] + ";Pwd=" + System.Configuration.ConfigurationManager.AppSettings["configpassword"] + ";Database=" + System.Configuration.ConfigurationManager.AppSettings["configdatabase"] + ";";

        public static string astromechdbcon = "Server=" + System.Configuration.ConfigurationManager.AppSettings["astromechhost"] + ";Uid=" + System.Configuration.ConfigurationManager.AppSettings["astromechuser"] + ";Pwd=" + System.Configuration.ConfigurationManager.AppSettings["astromechpassword"] + ";Database=" + System.Configuration.ConfigurationManager.AppSettings["astromechdatabase"] + ";";

        public static string logdbcon = "Server=" + System.Configuration.ConfigurationManager.AppSettings["loghost"] + ";Uid=" + System.Configuration.ConfigurationManager.AppSettings["loguser"] + ";Pwd=" + System.Configuration.ConfigurationManager.AppSettings["logpassword"] + ";Database=" + System.Configuration.ConfigurationManager.AppSettings["logdatabase"] + ";";

        public static string archivedbcon = "Server=" + System.Configuration.ConfigurationManager.AppSettings["archivehost"] + ";Uid=" + System.Configuration.ConfigurationManager.AppSettings["archiveuser"] + ";Pwd=" + System.Configuration.ConfigurationManager.AppSettings["archivepassword"] + ";Database=" + System.Configuration.ConfigurationManager.AppSettings["archivedatabase"] + ";";

        public static string toolsdbcon = "Server=" + System.Configuration.ConfigurationManager.AppSettings["toolshost"] + ";Uid=" + System.Configuration.ConfigurationManager.AppSettings["toolsuser"] + ";Pwd=" + System.Configuration.ConfigurationManager.AppSettings["toolspassword"] + ";Database=" + System.Configuration.ConfigurationManager.AppSettings["toolsdatabase"] + ";"; 
    }
}
