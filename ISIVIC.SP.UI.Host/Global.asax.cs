using System.Web.Http;

namespace ISIVIC.SP.UI.Host
{
    public class WebApiApplication : System.Web.HttpApplication
    {

        protected void Application_Start()
        {
            //GlobalConfiguration.Configure(WebApiConfig.Register);
            GlobalConfiguration.Configure(WebApiConfig.Register);
            DependencyResolverConfigurator.RegisterComponents();

        }
    }
}
