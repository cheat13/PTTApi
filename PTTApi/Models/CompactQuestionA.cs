using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTTApi.Models
{
    public class CompactQuestionA
    {
        public int QuestionCategoryId { get; set; }

        public string Content { get; set; }

        public int QuestionNo { get; set; }

        public int TestTakeGroupId { get; set; }

        public IEnumerable<QuestionChoiceA> Choice { get; set; }

        public IEnumerable<QuestionAMedia> Media  { get; set; }
    }
}
