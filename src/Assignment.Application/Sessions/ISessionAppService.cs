using System.Threading.Tasks;
using Abp.Application.Services;
using Assignment.Sessions.Dto;

namespace Assignment.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
