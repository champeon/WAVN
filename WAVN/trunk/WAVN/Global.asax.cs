using System.Web.Mvc;
using System.Web.Routing;
using WAVN.App_Start;

namespace WAVN.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            IoCConfig.RegisterDependencies();
        }
    }
}
