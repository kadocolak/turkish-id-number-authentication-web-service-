using System.Web;
using System.Web.Mvc;

namespace TC_Kimlik_Doğrulama_Web_Servis
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
