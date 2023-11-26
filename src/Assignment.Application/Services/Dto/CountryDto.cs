using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Assignment.Domain;
using System;

namespace Assignment.Services
{
    [AutoMapFrom(typeof(Country))]
    public class CountryDto : AuditedEntityDto<Guid>
    {
     public string Name { get; set; }
    }
}