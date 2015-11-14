using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Uranus.Service.Abstract;
using Microsoft.Practices.Unity;
using Uranus.Domain.ViewModels;
using Uranus.Domain.Entities;
using Uranus.Service.Implementation;

namespace Uranus.Utility
{
    public class GlobalSetupHelper
    {

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
        public void SetGlobalSetup()
        {



            var company = new Company();
            var company1 = companyService.GetAll().FirstOrDefault();
            //if (company1 != null)
            //{
            //    GlobalSetup.Company = company1;
            //}
            //else
            //{
            GlobalSetup.Company = company;
            //  }





        }
    }
}