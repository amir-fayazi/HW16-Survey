

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
        public IReadOnlyCollection<OptionVoteResultDto> GetOptionVotePercentages(int questionId)
        {
            var result = _context.Options
                .Where(x => x.QuestionId == questionId)
                .Select(x => new
                {
                    OptionId = x.Id,
                    OptionText = x.Text,
                    OptionCount = x.Votes.Count()
                }).ToList();

            var totalVotes = result.Sum(x => x.OptionCount);

            return result.Select(x => new OptionVoteResultDto
            {
                OptionId = x.OptionId,
                OptionTitle = x.OptionText,
                Percentage = totalVotes == 0
                ? 0
                : x.OptionCount * 100.0 / totalVotes
            }).ToList();
                
        }



        public IReadOnlyCollection<Person> GetParticipantsBySurveyId(int surveyId)
        {
            throw new NotImplementedException();
        }

        public int GetVoteCountByOptionId(int optionId)
        {
            throw new NotImplementedException();
        }

        public bool HasParticipatedInSurvey(int surveyId, int personId)
        {
            throw new NotImplementedException();
        }
    }
}
