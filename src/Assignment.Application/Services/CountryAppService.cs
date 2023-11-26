using System;
using System.Text;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using Assignment.Domain;
using Assignment.Authorization;
using Abp.Authorization;

namespace Assignment.Services
{
    [AbpAuthorize(PermissionNames.Pages_Users)]
    public class CountryAppService : AsyncCrudAppService<Country, CountryDto, Guid>, ICountryAppService
    {
        public CountryAppService(IRepository<Country, Guid> repository) : base(repository)
        {
        }
    }
}