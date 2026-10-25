using Survey.Domain.Contracts.Repositories;
using Survey.Infrastructure.Persistence;

namespace Survey.Infrastructure.Repositories
{
    public class SurveyParticipationRepository : ISurveyParticipationRepository
    {
        private readonly AppDbContext _context;

        public SurveyParticipationRepository(AppDbContext context)
        {
            _context = context;
        }
        public bool HasParticipatedInSurvey(int surveyId, int personId)
        {
            return _context.SurveyParticipations.Any(x => x.PersonId == personId && x.SurveyId == surveyId);
        }

        public int GetParticipantCountBySurveyId(int surveyId)
        {
            return _context.SurveyParticipations
                 .Count(x => x.SurveyId == surveyId);
        }
    }
}
