using System;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace Assignment.Domain
{
    public class State : AuditedEntity<Guid>
    {

        [Required]
        public string SName { get; set; }
        public Guid CountryId { get; set; } // Foreign key for Country

        // Other state-specific properties
    }
}