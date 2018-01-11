using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.AutoMapper;
using AbpSimpleCRUD.Clients.Dtos;
using AbpSimpleCRUD.Domain.Clients;

namespace AbpSimpleCRUD.Clients
{
    public class ClientAppService : IClientAppService
    {
        private IClientManager _clientManager;

        public ClientAppService(IClientManager clientManager)
        {
            _clientManager = clientManager;
        }

        public async Task<CreateClientOutput> CreateClient(CreateClientInput input)
        {
            var client = input.MapTo<Client>();
            var createdClientId = await _clientManager.Create(client);
            return new CreateClientOutput { Id = createdClientId };
        }

        public async Task DeleteClient(long id)
        {
            await _clientManager.Delete(id);
        }

        public async Task<GetAllClientsOutput> GetAllClients()
        {
            var clients = await _clientManager.GetAll();
            return new GetAllClientsOutput
            {
                Clients = clients.MapTo<List<GetAllClientsItem>>()
            };
        }

        public async Task<GetClientByIdOutput> GetById(long id)
        {
            var client = await _clientManager.GetById(id);
            return client.MapTo<GetClientByIdOutput>();
        }

        public async Task<UpdateClientOutput> UpdateClient(UpdateClientInput input)
        {
            var client = input.MapTo<Client>();
            var clientUpdated = await _clientManager.Update(client);
            return clientUpdated.MapTo<UpdateClientOutput>();
        }
    }
}
