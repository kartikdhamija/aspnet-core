using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services;

namespace Assignment.Services{
    public interface ICountryAppService : IAsyncCrudAppService<CountryDto,Guid>
    {

    }

}