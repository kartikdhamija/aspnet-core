using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Assignment.Domain;

namespace Assignment.EntityFrameworkCore.Mapping
{
    public class StateMapping : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.Property(x => x.SName).IsRequired();
            builder.HasOne<Country>().WithMany().HasForeignKey(x => x.CountryId);
            // Other configurations if needed
        }
    }
}
