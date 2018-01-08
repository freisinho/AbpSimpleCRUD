using System.Threading.Tasks;
using Abp.Application.Services;
using AbpSimpleCRUD.Authorization.Accounts.Dto;

namespace AbpSimpleCRUD.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
