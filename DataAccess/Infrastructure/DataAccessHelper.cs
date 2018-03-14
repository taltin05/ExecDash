using System.Configuration;

namespace ExecDash.DataAccess.Infrastructure
{
    public static class DataAccessHelper
    {
        public static string GetDB2Schema()
        {
            string schema = string.Empty;

#if DEBUG
            schema = ConfigurationManager.AppSettings["DevDB2Schema"].ToString();
#else
            schema = ConfigurationManager.AppSettings["ProdDB2Schema"].ToString();
#endif

            return schema;
        }
    }
}
