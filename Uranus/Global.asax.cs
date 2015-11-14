
using Microsoft.Practices.Unity;
using System;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Uranus.App_Start;
using Uranus.Service.Abstract;
using Uranus.Utility;

namespace Uranus
{
    public class MvcApplication : System.Web.HttpApplication
    {
        //[Dependency]
        // public readonly ICompanyService CompanyService;
        private ICompanyService companyService;


        [Dependency]
        public ICompanyService CompanyService
        {
            get { return companyService; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                companyService = value;
            }
        }
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            UnityConfig.Initialise();
            // GlobalSetupHelper obj = new GlobalSetupHelper();
            // obj.SetGlobalSetup();
            CompanyService.GetAll();
            //Database.SetInitializer(new ProductDatabaseInitializer());
        }
    }
}
