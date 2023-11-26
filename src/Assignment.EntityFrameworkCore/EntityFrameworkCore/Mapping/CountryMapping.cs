using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Assignment.Domain;

namespace Assignment.EntityFrameworkCore.Mapping
{
    public class CountryMapping : IEntityTypeConfiguration<Country>
    {
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.Property(x=>x.Name)
              .IsRequired();
    }
    }
}