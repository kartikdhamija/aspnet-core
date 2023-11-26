using System;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace Assignment.Domain
{
    public class Country : AuditedEntity<Guid>
    {
        public string Name { get; set; }
        // Other country-specific properties
    }
}