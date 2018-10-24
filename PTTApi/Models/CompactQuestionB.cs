using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTTApi.Models
{
    public class CompactQuestionB
    {
        public int QuestionCategoryId { get; set; }

        public string Content { get; set; }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var r = obj as CompactQuestionB;
            return this.QuestionCategoryId == r.QuestionCategoryId && this.Content == r.Content;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return this.QuestionCategoryId.GetHashCode() + this.Content.GetHashCode();
        }
    }
}
