namespace upkguh
{
    internal class Konesksi
    {
        public static string conn = "" +
            //"Data Source = LAPTOP-82FOTN2U\\SQLEXPRESS01; " +
            "Data Source = ARAN\\SQLEXPRESS01; " +
            "Initial Catalog = DBUPK; " +
            "Integrated Security = True; " +
            "TrustServerCertificate = True; ";
    }

    public class Model
    {
        public static string name { get; set; }

        public static int id { get; set; }
    }
}
