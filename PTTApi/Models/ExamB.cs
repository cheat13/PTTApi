using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTTApi.Models
{
    public class ExamB
    {
        public string[] ChoiceHeader { get; set; }

        public IEnumerable<Sheet1Question> Questions { get; set; }

        public class Sheet1Question
        {
            public int QuestionNo { get; set; }
            public string Question { get; set; }
            public int CategoryID { get; set; }

            // override object.Equals
            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                {
                    return false;
                }

                var r = obj as Sheet1Question;
                return this.QuestionNo == r.QuestionNo && this.Question == r.Question && this.CategoryID == r.CategoryID;
            }

            // override object.GetHashCode
            public override int GetHashCode()
            {
                return this.QuestionNo.GetHashCode() + this.CategoryID.GetHashCode();
            }
        }
    }
}
