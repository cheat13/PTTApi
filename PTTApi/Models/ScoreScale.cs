using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTTApi.Models
{
    public class ScoreScale
    {
        public int Id { get; set; }

        public string Choice { get; set; }

        public int Score { get; set; }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var r = obj as ScoreScale;
            return this.Choice == r.Choice && this.Score == r.Score;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return this.Choice.GetHashCode() + this.Score.GetHashCode();
        }
    }
}
