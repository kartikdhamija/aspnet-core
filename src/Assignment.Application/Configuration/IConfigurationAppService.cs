using System.Threading.Tasks;
using Assignment.Configuration.Dto;

namespace Assignment.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
