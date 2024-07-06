using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Utilities
{
    public static class SystemSettings
    {
        public static string ThemeForegroundColor { get; private set; } = "darkblue";

        public static string ThemeBackgroundColor { get; private set; } = "lightcyan";

        public static string SqlServerName { get; private set; } = "SQLExpress";

        public static string OperatingStatus { get; private set; } = "Production";

        public static void SetSqlServerName()
        {
            string machineName = System.Environment.MachineName;

            if (machineName == "DESKTOP-H3MOQ6L")
            {
                SqlServerName = "SQLExpress01";
            }
        }

        public static string ConnectionString
        {
            get
            {
                return "Server=.\\" + SqlServerName + ";Database=ArmsSpectrumDevelopment;Trusted_Connection=Yes;TrustServerCertificate=True";
            }
        }
    }
}
