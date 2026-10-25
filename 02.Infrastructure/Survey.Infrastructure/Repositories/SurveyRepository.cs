

using Survey.Domain.Contracts.Repositories;
using Survey.Domain.Dtos;
using Survey.Domain.Entities;
using Survey.Domain.Enums;
using Survey.Infrastructure.Persistence;

namespace Survey.Infrastructure.Repositories
{
    public class SurveyRepository : ISurveyRepository
    {
        private readonly AppDbContext _context;

        public SurveyRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Add(SurveyAgg survey)
        {
            _context.Surveys.Add(survey);
        }

        public void Delete(int surveyId)
        {
            var survey = GetById(surveyId);

            if (survey is null)
                throw new KeyNotFoundException("Survey not found.");

            _context.Surveys.Remove(survey);
        }

        public IReadOnlyCollection<SurveyListDto> GetAllSurveys()
        {
            return _context.Surveys
                 .Select(x => new SurveyListDto
                 {
                     Id = x.Id,
                     Title = x.Title
                 })
                 .ToList();
        }
        public IReadOnlyCollection<SurveyListDto> GetAllActiveSurveys()
        {
            return _context.Surveys
                .Where(x => x.SurveyStatus == SurveyStatus.Active)
                .Select(x => new SurveyListDto
                {
                    Id = x.Id,
                    Title = x.Title
                })
                .ToList();
        }

        private SurveyAgg? GetById(int surveyId)
        {
            return _context.Surveys.SingleOrDefault(x => x.Id == surveyId);
        }
    }
}
