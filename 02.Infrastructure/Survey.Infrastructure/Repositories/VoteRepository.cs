

using Survey.Domain.Contracts.Repositories;
using Survey.Domain.Dtos;
using Survey.Domain.Entities;
using Survey.Infrastructure.Persistence;

namespace Survey.Infrastructure.Repositories
{
    public class VoteRepository : IVoteRepository
    {
        private readonly AppDbContext _context;

        public VoteRepository(AppDbContext context)
        {
            _context = context;
        }



        public IReadOnlyCollection<OptionVoteResultDto>? GetOptionVotePercentages(int questionId)
        {
            var options = _context.Questions
                .Where(q => q.Id == questionId)
                .Select(q => q.Options
                    .Select(o => new
                    {
                        OptionId = o.Id,
                        OptionText = o.Text,
                        OptionCount = o.Votes.Count()
                    })
                    .ToList())
                .FirstOrDefault();

            if (options is null)
                return null;

            var totalVotes = options.Sum(x => x.OptionCount);

            return options
                .Select(x => new OptionVoteResultDto
                {
                    OptionId = x.OptionId,
                    OptionTitle = x.OptionText,
                    Percentage = totalVotes == 0
                        ? 0
                        : x.OptionCount * 100.0 / totalVotes
                })
                .ToList();
        }




        public int? GetVoteCountByOptionId(int optionId)
        {
            return _context.Options
                 .Where(x => x.Id == optionId)
                 .Select(x => x.Votes.Count())
                 .FirstOrDefault();
        }


    }
}
