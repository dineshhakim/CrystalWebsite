using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uranus.Data.Abstract;
using Uranus.Data.Infrastucture;
using Uranus.Domain.Entities;
using Uranus.Service.Abstract;

namespace Uranus.Service.Implementation
{
    public class ClientService: IClientService
    {
        private readonly IClientRepository repository;
        private readonly IUnitOfWork unitofwork;
        public ClientService(IClientRepository repository, IUnitOfWork unitofwork)
        {
            this.repository = repository;
            this.unitofwork = unitofwork;
        }
        public Clients Add(Clients entity)
        {
            entity = repository.Add(entity);
            unitofwork.Commit();
            return entity;
        }
        public Clients Update(Clients entity)
        {
            entity=repository.Update(entity);
            unitofwork.Commit();
            return entity;
        }
        public void Delete(Clients entity)
        {
            repository.Delete(entity);
            unitofwork.Commit();
        }
        public IEnumerable<Clients> GetAll()
        {
            return repository.GetAll();
        }
        public Clients GetById(int id)
        {
            return repository.GetById(id);
        }
    }
}
