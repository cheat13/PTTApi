using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTTApi.Models
{
    public class QuestionCComment
    {
        public int CommentId { get; set; }

        public string Prefix { get; set; }

        public string Content { get; set; }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var r = obj as QuestionCComment;
            return this.Prefix == r.Prefix && this.Content == r.Content;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return this.Prefix.GetHashCode() + this.Content.GetHashCode();
        }
    }
}
