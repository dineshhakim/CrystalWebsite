using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uranus.Data.Abstract;
using Uranus.Data.Infrastucture;
using Uranus.Domain.Entities;

namespace Uranus.Data.Implementation
{
    public class ClientRepository : RepositoryBase<Clients> , IClientRepository
    {
        public ClientRepository(DatabaseFactory databasefactory) : base(databasefactory)
        { }
    }
}
