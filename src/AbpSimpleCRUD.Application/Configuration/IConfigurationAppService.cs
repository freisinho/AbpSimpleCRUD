using System.Threading.Tasks;
using AbpSimpleCRUD.Configuration.Dto;

namespace AbpSimpleCRUD.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
