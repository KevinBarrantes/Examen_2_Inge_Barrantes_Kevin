using System.Web;
using System.Web.Mvc;

namespace Examen_2_Barrantes_Kevin
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
