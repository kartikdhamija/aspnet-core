using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Assignment.Domain;
using System;

namespace Assignment.Services.Dto
{
    [AutoMapFrom(typeof(State))]
    public class StateDto : AuditedEntityDto<Guid>
    {
        public string SName { get; set; }
        public Guid CountryId { get; set; } // Foreign key for Country
        public string CountryName { get; set; } // Add this property to show Country name in UI
        // Other state-specific properties
    }
}
