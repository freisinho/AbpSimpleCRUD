using Abp.AutoMapper;
using AbpSimpleCRUD.Sessions.Dto;

namespace AbpSimpleCRUD.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
