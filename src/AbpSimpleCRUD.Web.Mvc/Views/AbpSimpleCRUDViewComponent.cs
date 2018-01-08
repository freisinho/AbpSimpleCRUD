using Abp.AspNetCore.Mvc.ViewComponents;

namespace AbpSimpleCRUD.Web.Views
{
    public abstract class AbpSimpleCRUDViewComponent : AbpViewComponent
    {
        protected AbpSimpleCRUDViewComponent()
        {
            LocalizationSourceName = AbpSimpleCRUDConsts.LocalizationSourceName;
        }
    }
}
