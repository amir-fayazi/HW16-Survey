using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Survey.Domain.Entities;

namespace Survey.Infrastructure.Configurations
{
    public class OptionConfiguration : IEntityTypeConfiguration<Option>
    {
        public void Configure(EntityTypeBuilder<Option> builder)
        {


            builder.HasOne(x => x.Question)
                .WithMany(x => x.Options)
                .HasForeignKey(x => x.QuestionId);

            builder.HasMany(x => x.Votes)
                .WithOne(x => x.Option)
                .HasForeignKey(x => x.OptionId)
                .OnDelete(DeleteBehavior.Cascade);
            
        }
    }

}
