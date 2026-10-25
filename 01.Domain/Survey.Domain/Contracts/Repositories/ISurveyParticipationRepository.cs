

using Survey.Domain.Dtos;
using Survey.Domain.Entities;

namespace Survey.Domain.Contracts.Repositories
{
    public interface ISurveyParticipationRepository
    {
        bool HasParticipatedInSurvey(int SurveyId, int personId);
        int? GetParticipantCountBySurveyId(int surveyId);
        IReadOnlyCollection<SurveyParticipantDto>? GetParticipantsBySurveyId(int surveyId);
        
    }
}
