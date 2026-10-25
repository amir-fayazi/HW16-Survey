namespace Survey.Domain.Entities
{
    public class Option : BaseEntity
    {


        public string Text { get; private set; } = string.Empty;

        private Option() { }

        public Option(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentException("Text is required", nameof(text));

            Text = text;
        }

        #region Navigation
        public int QuestionId { get; private set; }
        public Question Question { get; private set; } = null!;

        public List<Vote> Votes { get; set; } = [];


        #endregion
    }
}
