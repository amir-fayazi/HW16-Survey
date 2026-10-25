using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Survey.Domain.Entities;

namespace Survey.Infrastructure.Configurations
{
    public class SurveyAggConfiguration : IEntityTypeConfiguration<SurveyAgg>
    {
        public void Configure(EntityTypeBuilder<SurveyAgg> builder)
        {
            throw new NotImplementedException();
        }
    }

}
