using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using DgCorER.Configuration.Dto;

namespace DgCorER.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DgCorERAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
