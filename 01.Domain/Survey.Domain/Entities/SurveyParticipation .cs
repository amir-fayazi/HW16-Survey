

namespace Survey.Domain.Entities
{
    public class SurveyParticipation : BaseEntity
    {

        public int PersonId { get; private set; }
        public Person Person { get; private set; } = null!;

        public int SurveyId { get; private set; }
        public SurveyAgg Survey { get; private set; } = null!;
        
        private SurveyParticipation(){}    
        
        public SurveyParticipation(int personId, int surveyId)
        {
            if (personId <= 0)
                throw new ArgumentException(
                    "Invalid PersonId", nameof(personId));

            if (surveyId <= 0)
                throw new ArgumentException(
                    "Invalid SurveyId", nameof(surveyId));

            PersonId = personId;
            SurveyId = surveyId;
           
        }




    }
}
