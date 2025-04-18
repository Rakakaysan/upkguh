using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upkguh
{
    internal class Konesksi
    {
        public static string conn = "" +
            "Data Source = AVATARR\\MSSQLSERVER01; " +
            "Initial Catalog = DBUPK; " +
            "Integrated Security = True; " +
            "TrustServerCertificate = True; ";
    }

    public class Model
    {
        public static string name { get; set; }

        public static string id { get; set; }
    }
}
