using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Uranus.Service.Abstract;

namespace Uranus.Controllers
{
    public class HomeController : Controller
    {
        public readonly ICompanyService CompanyService;
        
        public HomeController(ICompanyService companyService)
        {
            CompanyService = companyService;
        }
        public ActionResult Index()
        {
            CompanyService.SetGlobalSetupOfCompany();
            return View();
        }
    }
}