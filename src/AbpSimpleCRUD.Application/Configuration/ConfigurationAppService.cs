using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AbpSimpleCRUD.Configuration.Dto;

namespace AbpSimpleCRUD.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AbpSimpleCRUDAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
