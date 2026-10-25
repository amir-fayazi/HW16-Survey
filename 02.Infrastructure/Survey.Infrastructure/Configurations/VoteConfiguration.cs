using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Survey.Domain.Entities;

namespace Survey.Infrastructure.Configurations
{
    public class VoteConfiguration : IEntityTypeConfiguration<Vote>
    {
        public void Configure(EntityTypeBuilder<Vote> builder)
        {
            builder.HasOne(x => x.Person)
                .WithMany(x => x.Votes)
                .HasForeignKey(x => x.PersonId);

            builder.HasIndex(x => new { x.PersonId, x.QuestionId })
                .IsUnique();

        }
    }

}
