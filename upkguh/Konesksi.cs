namespace upkguh
{
    internal class Konesksi
    {
        public static string conn = "" +
            "Data Source = ARAN\\SQLEXPRESS01; " +
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
