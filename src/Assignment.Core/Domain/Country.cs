using System;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Domain
{
    public class Country : AuditedEntity<Guid>
    {
        [Required]
        public string Name { get; set; }
        // Other country-specific properties
    }
}
