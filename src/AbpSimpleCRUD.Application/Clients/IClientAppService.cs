using Abp.Application.Services;
using AbpSimpleCRUD.Clients.Dtos;
using System.Threading.Tasks;

namespace AbpSimpleCRUD.Clients
{
    public interface IClientAppService : IApplicationService
    {
        Task<CreateClientOutput> CreateClient(CreateClientInput input);
        Task<UpdateClientOutput> UpdateClient(UpdateClientInput input);
        Task DeleteClient(long id);
        Task<GetClientByIdOutput> GetById(long id);
        Task<GetAllClientsOutput> GetAllClients();
    }
}
