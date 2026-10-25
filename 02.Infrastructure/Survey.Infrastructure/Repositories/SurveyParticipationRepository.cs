using Microsoft.EntityFrameworkCore;
using Survey.Domain.Contracts.Repositories;
using Survey.Domain.Dtos;
using Survey.Domain.Entities;
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

        public int? GetParticipantCountBySurveyId(int surveyId)
        {
           return _context.Surveys
                .Where(x => x.Id == surveyId)
                .Select(x => x.SurveyParticipations.Count())
                .FirstOrDefault();
        }

        public IReadOnlyCollection<SurveyParticipantDto>? GetParticipantsBySurveyId(int surveyId)
        {
            return _context.Surveys
                 .AsNoTracking()
                 .Where(x => x.Id == surveyId)
                 .Select(x => x.SurveyParticipations
                     .Select(x => new SurveyParticipantDto
                     {
                         PersonId = x.PersonId,
                         Username = x.Person.Username,
                         ParticipatedAt = x.CreatedAt
                     }).ToList())
                 .FirstOrDefault();
        }
    }
}



