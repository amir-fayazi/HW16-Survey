using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Survey.Domain.Entities;

namespace Survey.Infrastructure.Configurations
{
    public class SurveyParticipationConfiguration : IEntityTypeConfiguration<SurveyParticipation>
    {
        public void Configure(EntityTypeBuilder<SurveyParticipation> builder)
        {
            builder.HasIndex(x => new
            {
                x.PersonId,
                x.SurveyId
            }).IsUnique();
        }
    }

}
