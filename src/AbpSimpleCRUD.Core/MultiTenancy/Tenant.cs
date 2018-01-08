using Abp.MultiTenancy;
using AbpSimpleCRUD.Authorization.Users;

namespace AbpSimpleCRUD.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
