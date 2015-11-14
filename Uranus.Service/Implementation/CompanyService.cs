using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Uranus.Data.Abstract;
using Uranus.Data.Infrastucture;
using Uranus.Domain.Entities;
using Uranus.Domain.ViewModels;
using Uranus.Service.Abstract;

namespace Uranus.Service.Implementation
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository repository;
        private readonly IUnitOfWork unitOfWork;
        public CompanyService(ICompanyRepository repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        public Company Add(Company entity)
        {
            entity = repository.Add(entity);
            unitOfWork.Commit();
            return entity;
        }


        public Company Update(Company entity)
        {
            return repository.Update(entity);
        }

        public void Delete(Company entity)
        {
            repository.Delete(entity);
        }

        public IEnumerable<Company> GetAll()
        {
            return repository.GetAll();
            
        }
        private void SetGlobalValues(IEnumerable<Company> company)
        {
            Company company1;
            if (company.ToList().Count>0)
            {
                company1 =   company.ToList().FirstOrDefault();
            }
            else
            {
                company1 = new Company();
            }
            if (GlobalSetup.Company == null)
            {
                GlobalSetup.Company = company1;
            }
          
        }

        public Company GetById(int id)
        {
            return repository.GetById(id);
        }

        public void SetGlobalSetupOfCompany()
        {
            var company = repository.GetAll();
            SetGlobalValues(company);
           
        }
    }
}