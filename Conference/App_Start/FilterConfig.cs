using System.Web.Mvc;

namespace Conference
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            // SSL
            //filters.Add(new RequireHttpsAttribute());
        }
    }
}
