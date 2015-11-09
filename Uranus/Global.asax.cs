
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Uranus.App_Start;
using Uranus.Service.Utility;

namespace Uranus
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
          
            UnityConfig.Initialise();
            GlobalSetupHelper obj = new GlobalSetupHelper();
            obj.SetGlobalSetup();
            //Database.SetInitializer(new ProductDatabaseInitializer());
        }
    }
}
