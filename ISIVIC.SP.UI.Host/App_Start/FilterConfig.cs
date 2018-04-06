using System.Web;
using System.Web.Mvc;

namespace ISIVIC.SP.UI.Host
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
