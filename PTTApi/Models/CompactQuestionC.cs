using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTTApi.Models
{
    public class CompactQuestionC
    {
        public int QuestionCategoryId { get; set; }

        public string Content { get; set; }

        public IEnumerable<string> ObservedActionContents { get; set; }

        public IEnumerable<QuestionCComment> Comments { get; set; }
    }
}
