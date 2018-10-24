using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTTApi.Models
{
    public class QuestionC
    {
        public int QuestionId { get; set; }

        //public int QuestionNumber { get; set; }

        public string Content { get; set; }

        //public Project project { get; set; }

        public int QuestionCategoryId { get; set; }

        public IEnumerable<QuestionCObservedAction> ObservedAction { get; set; }

        public IEnumerable<QuestionCComment> Comment { get; set; }

        public QuestionC()
        {
            //QueestionCategory = new Models.QuestionCategory();
            ObservedAction = new List<QuestionCObservedAction>();
            Comment = new List<QuestionCComment>();
        }
    }
}
