using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.Domain.Dtos
{
    public class SurveyParticipantDto
    {
        public int PersonId { get; set; }
        public string Username { get; set; } = string.Empty;
        public DateTime ParticipatedAt { get; set; }
    }
}
