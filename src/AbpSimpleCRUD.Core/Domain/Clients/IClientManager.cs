using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AbpSimpleCRUD.Domain.Clients
{
    public interface IClientManager
    {
        Task<long> Create(Client client);
        Task<Client> Update(Client client);
        Task Delete(long id);
        Task<Client> GetById(long id);
    }
}
