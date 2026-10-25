using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Survey.Domain.Entities;

namespace Survey.Infrastructure.Configurations
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {

            builder.HasMany(x => x.Votes)
                .WithOne(x => x.Question)
                .HasForeignKey(x => x.QuestionId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Survey)
                .WithMany(x => x.Questions)
                .HasForeignKey(x => x.SurveyId)
                .OnDelete(DeleteBehavior.Cascade);

            
        }
    }

}
