using Abp.Application.Services;
using Assignment.Services.Dto;
using System;

namespace Assignment.Services
{
    public interface IStateAppService : IAsyncCrudAppService<StateDto, Guid>
    {
        // Define additional methods if required
    }
}
