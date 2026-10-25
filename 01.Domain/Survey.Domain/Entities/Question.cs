

namespace Survey.Domain.Entities
{
    public class Question : BaseEntity
    {
        public string Text { get; private set; } = string.Empty;
        private readonly List<Option> _options = [];
        private readonly List<Vote> _votes = [];

        private Question() { }

        public Question(string text, int surveyId, IReadOnlyCollection<Option> options)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentException( "Text is required", nameof(text));

            if (surveyId <= 0)
                throw new ArgumentException( "SurveyId cannot be negative or 0", nameof(surveyId));

            if(options is null)
                throw new ArgumentException("Options cannot be null.", nameof(options));

            if(options.Any(x => x is null))
                throw new ArgumentException("Options cannot contain null items.", nameof(options));
            
            if(options.Count != 4)
                throw new ArgumentException("Exactly 4 options are required.", nameof(options));

            
            Text = text;
            SurveyId = surveyId;
            _options.AddRange(options);
        }

        #region Navigation
        public IReadOnlyCollection<Vote> Votes => _votes.AsReadOnly() ;
        public IReadOnlyCollection<Option> Options => _options.AsReadOnly();

        public SurveyAgg Survey { get; private set; } = null!;
        #endregion
        public int SurveyId { get; private set; }


    }
}
