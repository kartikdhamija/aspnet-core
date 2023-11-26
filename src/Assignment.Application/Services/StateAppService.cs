using System;
using System.Text;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using Assignment.Domain;
using Assignment.Authorization;
using Abp.Authorization;
using Assignment.Services.Dto;

namespace Assignment.Services
{
    [AbpAuthorize(PermissionNames.Pages_Users)]
    public class StateAppService : AsyncCrudAppService<State, StateDto, Guid>, IStateAppService
    {
        public StateAppService(IRepository<State, Guid> repository) : base(repository)
        {
        }

        // Implement custom methods here if needed
    }
}
