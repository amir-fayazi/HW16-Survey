using Survey.Domain.Dtos;
using Survey.Domain.Entities;


namespace Survey.Domain.Contracts.Repositories
{
    public interface ISurveyRepository
    {
        void Add(SurveyAgg survey);
        void Delete(int survetId);
        IReadOnlyCollection<SurveyListDto> GetAllSurveys();
        IReadOnlyCollection<SurveyListDto> GetAllActiveSurveys();


    }
}
