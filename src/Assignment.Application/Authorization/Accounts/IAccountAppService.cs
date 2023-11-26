using System.Threading.Tasks;
using Abp.Application.Services;
using Assignment.Authorization.Accounts.Dto;

namespace Assignment.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
