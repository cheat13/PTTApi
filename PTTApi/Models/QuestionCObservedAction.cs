using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTTApi.Models
{
    public class QuestionCObservedAction : QuestionC
    {
        public string Content { get; set; }      

        public int ScoreScaleId { get; set; }

        public ScoreScale ScoreScale { get; set; }

        public QuestionCObservedAction()
        {           
            ScoreScale = new ScoreScale();
        }
    }
}
