using Survey.Domain.Dtos;
using Survey.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.Domain.Contracts.Repositories
{
    public interface IVoteRepository
    {
        IReadOnlyCollection<Person> GetParticipantsBySurveyId(int surveyId);
        int GetParticipantCountBySurveyId(int surveyId);
        IReadOnlyCollection<OptionVoteResultDto> GetOptionVotePercentages(int questionId);
        int GetVoteCountByOptionId(int optionId);
        bool HasParticipatedInSurvey(int surveyId, int personId);
    }
}
