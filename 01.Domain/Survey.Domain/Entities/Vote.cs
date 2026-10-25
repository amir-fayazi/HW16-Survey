namespace Survey.Domain.Entities
{
    public class Vote : BaseEntity
    {

        private Vote() { }

        public Vote(int personId, int questionId, int optionId)
        {
            PersonId = personId;
            QuestionId = questionId;
            OptionId = optionId;
        }

        #region Navigation
        public int PersonId { get; private set; }
        public Person Person { get; set; }

        public int QuestionId { get; private set; }
        public Question Question { get; set; }

        public int OptionId { get; private set; }
        public Option Option { get; set; }


        #endregion
    }
}
