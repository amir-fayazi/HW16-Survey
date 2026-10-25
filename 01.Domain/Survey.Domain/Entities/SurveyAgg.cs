using Survey.Domain.Enums;
using static System.Net.Mime.MediaTypeNames;

namespace Survey.Domain.Entities
{
    public class SurveyAgg : BaseEntity
    {
        public string Title { get; private set; } = string.Empty;
        private readonly List<Question> _questions = [];

        public SurveyStatus SurveyStatus { get; private set; }

        private SurveyAgg(){
        }
        
        public SurveyAgg(string title, SurveyStatus surveyStatus)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Title is required", nameof(title));

            if(surveyStatus is not (SurveyStatus.Draft or SurveyStatus.Active))
                throw new ArgumentOutOfRangeException(nameof(surveyStatus));


            Title = title;
            SurveyStatus = surveyStatus;
        }

        #region Navigation
        public IReadOnlyCollection<Question> Questions => _questions.AsReadOnly();


        #endregion


    }
}
