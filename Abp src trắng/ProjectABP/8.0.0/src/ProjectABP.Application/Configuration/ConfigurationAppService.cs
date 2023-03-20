using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ProjectABP.Configuration.Dto;

namespace ProjectABP.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ProjectABPAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
