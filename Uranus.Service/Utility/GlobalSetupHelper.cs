using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uranus.Data.Abstract;
using Uranus.Domain.Entities;
using Uranus.Domain.ViewModels;

namespace Uranus.Service.Utility
{
    public class GlobalSetupHelper
    {
        private ICompanyRepository CompanyRepository;

        
       
     
        public void SetGlobalSetup()
        {
            var company = new Company();
            var company1 = CompanyRepository.GetAll().FirstOrDefault();
            GlobalSetup.Company = company;

        }
    }
}
