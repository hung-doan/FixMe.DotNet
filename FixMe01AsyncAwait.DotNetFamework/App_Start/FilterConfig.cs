using System.Web;
using System.Web.Mvc;

namespace FixMe01AsyncAwait
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
