using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using RQCore.Configuration.Dto;

namespace RQCore.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : RQCoreAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
