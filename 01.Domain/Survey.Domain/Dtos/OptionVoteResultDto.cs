using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.Domain.Dtos
{
    public class OptionVoteResultDto
    {
        public int OptionId { get; set; }
        public string OptionTitle { get; set; }
        public double Percentage { get; set; }
    }
}
