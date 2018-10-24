using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTTApi.Models
{
    public class QuestionB
    {
        public int QuestionId { get; set; }

        //public int QuestionNumber { get; set; }

        public string Content { get; set; }

        public Project project { get; set; }

        public QuestionCategory QuestionCategory { get; set; }

        public IEnumerable<QuestionCObservedAction> ObservedAction { get; set; }

        public QuestionB()
        {
            QuestionCategory = new QuestionCategory();
            ObservedAction = new List<QuestionCObservedAction>();
        }
    }
}
