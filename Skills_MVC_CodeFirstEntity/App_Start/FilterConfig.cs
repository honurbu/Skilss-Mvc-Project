using System.Web;
using System.Web.Mvc;

namespace Skills_MVC_CodeFirstEntity
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
