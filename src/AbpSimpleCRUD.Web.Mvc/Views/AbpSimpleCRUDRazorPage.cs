using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace AbpSimpleCRUD.Web.Views
{
    public abstract class AbpSimpleCRUDRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected AbpSimpleCRUDRazorPage()
        {
            LocalizationSourceName = AbpSimpleCRUDConsts.LocalizationSourceName;
        }
    }
}
