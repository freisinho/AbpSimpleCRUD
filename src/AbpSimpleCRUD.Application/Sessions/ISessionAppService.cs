using System.Threading.Tasks;
using Abp.Application.Services;
using AbpSimpleCRUD.Sessions.Dto;

namespace AbpSimpleCRUD.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
