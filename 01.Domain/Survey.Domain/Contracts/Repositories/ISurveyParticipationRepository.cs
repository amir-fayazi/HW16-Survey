

namespace Survey.Domain.Contracts.Repositories
{
    public interface ISurveyParticipationRepository
    {
        bool HasParticipatedInSurvey(int SurveyId, int personId);
        int GetParticipantCountBySurveyId(int surveyId);
    }
}
