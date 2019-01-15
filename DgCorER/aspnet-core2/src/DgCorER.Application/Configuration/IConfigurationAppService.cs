using System.Threading.Tasks;
using DgCorER.Configuration.Dto;

namespace DgCorER.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
