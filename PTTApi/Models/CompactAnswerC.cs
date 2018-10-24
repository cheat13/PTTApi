using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTTApi.Models
{
    public class CompactAnswerC
    {
        public int QuestionId { get; set; }
        public int ScoreScaleId { get; set; }
        public IEnumerable<int> CommentIds { get; set; }
    }
}
