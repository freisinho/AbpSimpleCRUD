using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AbpSimpleCRUD.MultiTenancy.Dto;

namespace AbpSimpleCRUD.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
