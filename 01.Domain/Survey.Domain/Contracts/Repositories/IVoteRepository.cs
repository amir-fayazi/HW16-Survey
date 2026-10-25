using Survey.Domain.Dtos;
using Survey.Domain.Entities;


namespace Survey.Domain.Contracts.Repositories
{
    public interface IVoteRepository
    {
        IReadOnlyCollection<Person> GetParticipantsBySurveyId(int surveyId);
        
        IReadOnlyCollection<OptionVoteResultDto> GetOptionVotePercentages(int questionId);
        int GetVoteCountByOptionId(int optionId);
        bool HasParticipatedInSurvey(int surveyId, int personId);
    }
}
