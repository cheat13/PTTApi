using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTTApi.Models
{
    public class QuestionA
    {
        public int QuestionId { get; set; }

        //public int QuestionNumber { get; set; }

        public string Content { get; set; }

        public Project project { get; set; }

        public QuestionCategory QuestionCategory { get; set; }

        public IEnumerable<QuestionChoiceA> QuestionChoiceAs { get; set; }

        public QuestionA()
        {
            QuestionCategory = new QuestionCategory();
            QuestionChoiceAs = new List<QuestionChoiceA>();
        }
    }
}
