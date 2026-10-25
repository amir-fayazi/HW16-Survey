using Survey.Domain.Enums;
using static System.Net.Mime.MediaTypeNames;

namespace Survey.Domain.Entities
{
    public class Person : BaseEntity
    {
        private readonly List<Vote> _votes = [];
        private readonly List<SurveyParticipation> _surveyParticipations = [];

        public string Username { get; private set; } = string.Empty;
        public string Password { get; private set; } = string.Empty;
        public Role Role { get; private set; }


        private Person(){ }

        public Person(string username, string password, Role role = Role.User)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("username is required", nameof(username));

            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("password is required", nameof(password));

            Username = username;
            Password = password;
            Role = role;
        }

        #region Navigation
        public IReadOnlyCollection<Vote> Votes => _votes.AsReadOnly();
        public IReadOnlyCollection<SurveyParticipation> SurveyParticipations => _surveyParticipations.AsReadOnly();
        


        #endregion


    }
}
