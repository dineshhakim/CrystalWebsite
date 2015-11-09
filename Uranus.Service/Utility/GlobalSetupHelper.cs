using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uranus.Data.Implementation;
using Uranus.Domain.Entities;
using Uranus.Domain.ViewModels;
using Uranus.Service.Abstract;
using Uranus.Service.Implementation;

namespace Uranus.Service.Utility
{
    public class GlobalSetupHelper
    {
        public readonly ICompanyService CompanyService;
        public GlobalSetupHelper(ICompanyService companyService)
        {
            this.CompanyService = companyService;
        }

        public GlobalSetupHelper()
        {

        }
        public  void SetGlobalSetup()
        {
           

            //var company = CompanyService.GetAll().FirstOrDefault();


            //if (company == null)
            //{
               var company = new Company
                {
                    

                };

           // }
            GlobalSetup.Company = company;
        }
    }
}
