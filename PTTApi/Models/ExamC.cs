using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTTApi.Models
{
    public class ExamC
    {
        public string[] ChoiceHeader { get; set; }

        public IEnumerable<Sheet1Question> Questions { get; set; }

        public IEnumerable<Sheet2Comment> Comments { get; set; }

        public class Sheet1Question
        {
            public int QuestionNo { get; set; }
            public string Question { get; set; }
            public int CategoryID { get; set; }
            public string[] ChoiceContents { get; set; }

            // override object.Equals
            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                {
                    return false;
                }

                var r = obj as Sheet1Question;
                Func<bool> compareChoices = () =>
                {
                    if (this.ChoiceContents == r.ChoiceContents)
                    {
                        return true;
                    }
                    if (this.ChoiceContents == null || r.ChoiceContents == null)
                    {
                        return false;
                    }
                    if (this.ChoiceContents.Length != r.ChoiceContents.Length)
                    {
                        return false;
                    }
                    for (int i = 0; i < this.ChoiceContents.Length; i++)
                    {
                        if (this.ChoiceContents[i] != r.ChoiceContents[i])
                        {
                            return false;
                        }
                    }
                    return true;
                };
                return this.QuestionNo == r.QuestionNo && this.Question == r.Question
                    && this.CategoryID == r.CategoryID && compareChoices();
            }

            // override object.GetHashCode
            public override int GetHashCode()
            {
                return this.QuestionNo.GetHashCode() + this.CategoryID.GetHashCode();
            }
        }

        public class Sheet2Comment
        {
            public int QuestionNo { get; set; }
            public string Prefix { get; set; }
            public string Description { get; set; }

            // override object.Equals
            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                {
                    return false;
                }

                var r = obj as Sheet2Comment;
                return this.QuestionNo == r.QuestionNo && this.Prefix == r.Prefix && this.Description == r.Description;
            }

            // override object.GetHashCode
            public override int GetHashCode()
            {
                return this.QuestionNo.GetHashCode() + this.Prefix.GetHashCode();
            }
        }
    }
}
