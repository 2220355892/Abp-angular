using System.Threading.Tasks;
using ProjectABP.Configuration.Dto;

namespace ProjectABP.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
